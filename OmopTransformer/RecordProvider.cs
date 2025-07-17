using Microsoft.Data.SqlClient;
using OmopTransformer.Annotations;
using Dapper;
using Microsoft.Extensions.Options;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.Logging;

namespace OmopTransformer;

internal class RecordProvider : IRecordProvider
{
    private readonly Configuration _configuration;
    private readonly IQueryLocator _queryLocator;
    private readonly ILogger<RecordProvider> _logger;

    public RecordProvider(IOptions<Configuration> configuration, IQueryLocator queryLocator, ILogger<RecordProvider> logger)
    {
        _configuration = configuration.Value;
        _queryLocator = queryLocator;
        _logger = logger;
    }

    public async IAsyncEnumerable<IReadOnlyCollection<T>> GetRecordsBatched<T>([EnumeratorCancellation] CancellationToken cancellationToken)
    {
        const int defaultTimeoutInSeconds = 120 * 60; // 2 hours
        const int batchSize = 3000000;

        var query = GetQuery<T>();

        await using var connection = new SqlConnection(_configuration.ConnectionString);
        await connection.OpenAsync(cancellationToken);

        if (ContainsOrderByClause(query))
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

                query = query.TrimEnd(';', '\n', '\t');

                var batchQuery = $"{query} OFFSET {offset} ROWS FETCH NEXT {batchSize} ROWS ONLY";

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
            _logger.LogInformation("Running query. Pagination disabled (order by clause missing).");

            var results = await connection.QueryAsync<T>(
                new CommandDefinition(
                    commandText: query,
                    commandTimeout: defaultTimeoutInSeconds,
                    cancellationToken: cancellationToken));

            yield return results.ToList().AsReadOnly();
        }
    }

    private string GetQuery<T>()
    {
        var sourceQuery = (SourceQueryAttribute)typeof(T).GetCustomAttributes(typeof(SourceQueryAttribute), inherit: false).Single();
        var query = _queryLocator.GetQuery(sourceQuery.QueryFileName);
        return query.Sql!;
    }

    private static bool ContainsOrderByClause(string query) => query.ToUpperInvariant().Contains("ORDER BY");
}