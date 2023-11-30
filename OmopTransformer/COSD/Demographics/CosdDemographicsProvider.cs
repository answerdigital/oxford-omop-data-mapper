using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Demographics;

internal class CosdDemographicsProvider
{
    private readonly Configuration _configuration;
    private readonly ILogger<CosdDemographicsProvider> _logger;
    private readonly IQueryLocator _queryLocator;

    public CosdDemographicsProvider(IOptions<Configuration> configuration, ILogger<CosdDemographicsProvider> logger, IQueryLocator queryLocator)
    {
        _configuration = configuration.Value;
        _logger = logger;
        _queryLocator = queryLocator;
    }

    public async Task<IReadOnlyCollection<CosdDemographics>> GetPatientDemographics(CancellationToken cancellationToken)
    {
        _logger.LogInformation("Querying COSD demographics.");

        var sourceQuery = (SourceQueryAttribute)typeof(CosdDemographics).GetCustomAttributes(typeof(SourceQueryAttribute), inherit: false).Single();

        var query = _queryLocator.GetQuery(sourceQuery.QueryFileName);

        await using var connection = new SqlConnection(_configuration.StagingConnectionString);

        await connection.OpenAsync(cancellationToken);

        const int oneHourInSeconds = 60 * 60;

        var results =
            await connection.QueryAsync<CosdDemographics>(
                sql: query.Sql!,
                commandTimeout: oneHourInSeconds);

        return results.ToList();
    }
}