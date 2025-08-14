using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.Omop.Prune;

internal class OmopFinaliser
{
    private readonly Configuration _configuration;
    private readonly ILogger<OmopFinaliser> _logger;

    public OmopFinaliser(IOptions<Configuration> configuration, ILogger<OmopFinaliser> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Prune(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Clearing incomplete omop records.");

        var connection = RetryConnection.CreateSqlServer(_configuration.ConnectionString!);

        await connection.ExecuteLongTimeoutAsync("cdm.prune_omop");

        _logger.LogInformation("Apply data fixes.");

        await connection.ExecuteLongTimeoutAsync("cdm.dqd_corrections");

        _logger.LogInformation("Rebuilding era tables.");

        await connection.ExecuteLongTimeoutAsync("cdm.build_era");
    }
}