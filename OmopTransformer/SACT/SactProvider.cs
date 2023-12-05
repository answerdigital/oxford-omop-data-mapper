using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.SACT;

internal class SactProvider : ISactProvider
{
    private readonly Configuration _configuration;
    private readonly ILogger<SactProvider> _logger;

    public SactProvider(ILogger<SactProvider> logger, IOptions<Configuration> configuration)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public async Task<IReadOnlyCollection<Sact>> GetRecords(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Reading staged data.");

        var connection = new SqlConnection(_configuration.OmopConnectionString);

        await connection.OpenAsync(cancellationToken);

        var records = await connection.QueryAsync<Sact>("select * from sact_staging;");

        return records.ToList();
    }
}