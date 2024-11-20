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

    protected abstract string[] ClearStagingSql { get; }

    public async Task ClearStagingTables(CancellationToken cancellationToken)
    {
        await using var connection = new SqlConnection(_configuration.ConnectionString);

        await connection.OpenAsync(cancellationToken);

        _logger.LogInformation("Clearing staging tables.");
        
        foreach (string sql in ClearStagingSql)
        {
            await connection.ExecuteLongTimeoutAsync(sql);
        }
    }
}