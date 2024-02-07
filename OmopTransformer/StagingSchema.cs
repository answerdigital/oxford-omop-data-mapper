using System.Data.SqlClient;
using Dapper;
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

    protected abstract string[] ClearStagingSql { get; }

    public async Task ClearStagingTables(CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        _logger.LogInformation("Clearing staging tables.");

        const int TenMinutesInSeconds = 10 * 60;

        foreach (string sql in ClearStagingSql)
        {
            await connection.ExecuteAsync(sql, commandTimeout: TenMinutesInSeconds);
        }
    }
}