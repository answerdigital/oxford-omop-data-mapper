using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OmopTransformer.Annotations;
using System.Runtime.CompilerServices;
using Query = OmopTransformer.Transformation.Query;

namespace OmopTransformer;

internal class RecordProvider : IRecordProvider
{
    private readonly Configuration _configuration;
    private readonly IQueryLocator _queryLocator;
    private readonly ILogger<RecordProvider> _logger;
    private readonly TransformOptions _transformOptions;

    public RecordProvider(IOptions<Configuration> configuration, IQueryLocator queryLocator, ILogger<RecordProvider> logger, TransformOptions transformOptions)
    {
        _configuration = configuration.Value;
        _queryLocator = queryLocator;
        _logger = logger;
        _transformOptions = transformOptions;
    }

    public async IAsyncEnumerable<IReadOnlyCollection<T>> GetRecordsBatched<T>([EnumeratorCancellation] CancellationToken cancellationToken)
    {
        const int batchSize = 3000000;

        var query = GetQuery<T>();

        string queryText = query.Sql!.Value!;

        if (query.Sql.Type == "duckdb")
        {
            if (string.IsNullOrEmpty(_transformOptions.DuckdbSource))
                throw new NotSupportedException($"'duckdb-source' argument must be specified when executing a duckdb sql query. Query was '{query.Sql.Value}'.");

            const string dbSourceConstant = "##duckdb_source##";

            if (query.Sql?.Value?.Contains(dbSourceConstant) == false)
                throw new InvalidDataException($"Query of type duckdb must contain the following replacement token '{dbSourceConstant}'. Query was '{query.Sql.Value}'.");

            queryText = queryText.Replace(dbSourceConstant, _transformOptions.DuckdbSource);

            _logger.LogTrace("Duckdb query: {0}", queryText);

            var connection = RetryConnection.CreateDuckDbInMemory();

            await foreach (var batch in BatchQuery<T>(queryText, batchSize, connection, "duckdb", cancellationToken))
            {
                yield return batch;
            }
        }
        else if (query.Sql!.Type is null or "mssql")
        {
            var connection = RetryConnection.CreateSqlServer(_configuration.ConnectionString!);
    

            await foreach (var batch in BatchQuery<T>(queryText, batchSize, connection, "mssql", cancellationToken))
            {
                yield return batch;
            }
        }
        else
        {
            throw UnsupportedType(query.Sql.Type);
        }
    }

    private static NotSupportedException UnsupportedType(string typeName) => throw new NotSupportedException($"Unsupported query type '{typeName}'. Supported options are mssql, duckdb");


    private async IAsyncEnumerable<IReadOnlyCollection<T>> BatchQuery<T>(
        string queryText, 
        int batchSize,
        RetryConnection connection,
        string dialect,
        [EnumeratorCancellation]CancellationToken cancellationToken)
    {
        if (ContainsOrderByClause(queryText))
        {
            _logger.LogInformation("Running query. Pagination enabled. Batch size {0}.", batchSize);

            int offset = 0;
            int batch = 0;
            bool hasMoreResults = true;

            while (hasMoreResults && !cancellationToken.IsCancellationRequested)
            {
                batch++;

                if (batch > 1)
                {
                    _logger.LogInformation("Batch {0}", batch);
                }

                queryText = queryText.TrimEnd(';', '\n', '\t');

                string? batchQuery = dialect switch
                {
                    "mssql" => $"{queryText} OFFSET {offset} ROWS FETCH NEXT {batchSize} ROWS ONLY",
                    "duckdb" => $"{queryText} LIMIT {batchSize} OFFSET {offset}",
                    _ => throw UnsupportedType(dialect)
                };

                var batchResults = await connection.QueryLongTimeoutAsync<T>(batchQuery, cancellationToken);

                var resultsList = batchResults.ToList();

                if (resultsList.Count is 0)
                {
                    hasMoreResults = false;
                }
                else
                {
                    if (resultsList.Count < batchSize)
                        hasMoreResults = false;

                    yield return resultsList.AsReadOnly();
                    offset += batchSize;
                }
            }
        }
        else
        {
            yield return await ExecuteNonBatchedQuery<T>(queryText, cancellationToken, connection);
        }
    }

    private async Task<IReadOnlyCollection<T>> ExecuteNonBatchedQuery<T>(string queryText, CancellationToken cancellationToken, RetryConnection connection)
    {
        _logger.LogInformation("Running query. Pagination disabled (order by clause missing).");

        var results = await connection.QueryLongTimeoutAsync<T>(queryText, cancellationToken);

        return results.ToList().AsReadOnly();
    }

    private Query GetQuery<T>()
    {
        var sourceQuery = (SourceQueryAttribute)typeof(T).GetCustomAttributes(typeof(SourceQueryAttribute), inherit: false).Single();
        return _queryLocator.GetQuery(sourceQuery.QueryFileName); ;
    }

    private static bool ContainsOrderByClause(string query) => query.ToUpperInvariant().Contains("ORDER BY");
}