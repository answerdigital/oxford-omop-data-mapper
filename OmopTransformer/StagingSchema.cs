using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal abstract class StagingSchema
{
    private readonly Configuration _configuration;
    private readonly ILogger<StagingSchema> _logger;

    protected StagingSchema(IOptions<Configuration> configuration, ILogger<StagingSchema> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    protected abstract string[] DropStagingSql { get; }
    protected abstract string TableNameForExistenceCheck { get; }
    protected abstract string[] CreateStagingSql { get; }

    public async Task CreateStagingTablesIfTheyDoNotExist(CancellationToken cancellationToken)
    {
        if (!await StagingTablesExist(cancellationToken))
        {
            await CreateTables(cancellationToken);
        }
    }

    public async Task DropStagingTables(CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_configuration.StagingConnectionString);

        await connection.OpenAsync(cancellationToken);

        _logger.LogInformation("Dropping staging tables.");

        foreach (string sql in DropStagingSql)
        {
            await connection.ExecuteAsync(sql);
        }
    }

    public async Task<bool> StagingTablesExist(CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_configuration.StagingConnectionString);

        await connection.OpenAsync(cancellationToken);

        var tableId = await connection.QuerySingleAsync<int?>($"select object_id ('{TableNameForExistenceCheck}')");

        return tableId.HasValue;
    }

    private async Task CreateTables(CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_configuration.StagingConnectionString);

        await connection.OpenAsync(cancellationToken);

        _logger.LogInformation("Creating staging tables.");

        foreach (string sql in CreateStagingSql)
        {
            await connection.ExecuteAsync(sql);
        }
    }
}