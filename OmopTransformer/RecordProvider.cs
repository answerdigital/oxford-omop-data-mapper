﻿using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using OmopTransformer.Annotations;
using Dapper;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class RecordProvider : IRecordProvider
{
    private readonly Configuration _configuration;
    private readonly ILogger<RecordProvider> _logger;
    private readonly IQueryLocator _queryLocator;

    public RecordProvider(IOptions<Configuration> configuration, ILogger<RecordProvider> logger, IQueryLocator queryLocator)
    {
        _configuration = configuration.Value;
        _logger = logger;
        _queryLocator = queryLocator;
    }

    public async Task<IReadOnlyCollection<T>> GetRecords<T>(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Querying {0}", typeof(T));

        var query = GetQuery<T>();

        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        const int oneHourInSeconds = 60 * 60;

        var results =
            await connection.QueryAsync<T>(
                sql: query,
                commandTimeout: oneHourInSeconds);

        return results.ToList();
    }

    private string GetQuery<T>()
    {
        var sourceQuery = (SourceQueryAttribute)typeof(T).GetCustomAttributes(typeof(SourceQueryAttribute), inherit: false).Single();

        var query = _queryLocator.GetQuery(sourceQuery.QueryFileName);

        return query.Sql!;

    }
}