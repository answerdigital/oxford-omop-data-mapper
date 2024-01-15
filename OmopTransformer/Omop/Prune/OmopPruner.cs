using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Dapper;
using Microsoft.Data.SqlClient;

namespace OmopTransformer.Omop.Prune;

internal class OmopPruner
{
    private readonly Configuration _configuration;
    private readonly ILogger<OmopPruner> _logger;

    public OmopPruner(IOptions<Configuration> configuration, ILogger<OmopPruner> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task Prune(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Clearing incomplete omop records.");

        var connection = new SqlConnection(_configuration.OmopConnectionString);

        await connection.OpenAsync(cancellationToken);

        await connection.ExecuteAsync("cdm.prune_omop");
    }
}