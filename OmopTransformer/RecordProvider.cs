using System.Data;
using Dapper;
using DuckDB.NET.Data;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OmopTransformer.Annotations;
using OmopTransformer.Transformation;
using System.Runtime.CompilerServices;

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
        const int defaultTimeoutInSeconds = 120 * 60; // 2 hours
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

            await using var connection = new DuckDBConnection("Data Source=:memory:");
            connection.Open();

            yield return await ExecuteNonBatchedQuery<T>(queryText, defaultTimeoutInSeconds, cancellationToken, connection);

        }
        else if (query.Sql!.Type is null or "mssql")
        {
            await foreach (var batch in BatchQuerySqlServer<T>(queryText, batchSize, defaultTimeoutInSeconds, cancellationToken))
            {
                yield return batch;
            }
        }
        else
        {
            throw new NotSupportedException($"Unsupported query type '{query.Sql.Type}'. Supported options are mssql, duckdb");
        }
    }

    private async IAsyncEnumerable<IReadOnlyCollection<T>> BatchQuerySqlServer<T>(string queryText, int batchSize, int defaultTimeoutInSeconds, [EnumeratorCancellation]CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_configuration.ConnectionString);
        await connection.OpenAsync(cancellationToken);

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

                var batchQuery = $"{queryText} OFFSET {offset} ROWS FETCH NEXT {batchSize} ROWS ONLY";

                var batchResults = await connection.QueryAsync<T>(
                    new CommandDefinition(
                        commandText: batchQuery,
                        commandTimeout: defaultTimeoutInSeconds,
                        cancellationToken: cancellationToken));

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
            yield return await ExecuteNonBatchedQuery<T>(queryText, defaultTimeoutInSeconds, cancellationToken, connection);
        }
    }

    private async Task<IReadOnlyCollection<T>> ExecuteNonBatchedQuery<T>(string queryText, int defaultTimeoutInSeconds, CancellationToken cancellationToken, IDbConnection connection)
    {
        _logger.LogInformation("Running query. Pagination disabled (order by clause missing).");

        var results = await connection.QueryAsync<T>(
            new CommandDefinition(
                commandText: queryText,
                commandTimeout: defaultTimeoutInSeconds,
                cancellationToken: cancellationToken));

        return results.ToList().AsReadOnly();
    }

    private Query GetQuery<T>()
    {
        var sourceQuery = (SourceQueryAttribute)typeof(T).GetCustomAttributes(typeof(SourceQueryAttribute), inherit: false).Single();
        return _queryLocator.GetQuery(sourceQuery.QueryFileName); ;
    }

    private static bool ContainsOrderByClause(string query) => query.ToUpperInvariant().Contains("ORDER BY");
}