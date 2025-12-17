using Dapper;
using DuckDB.NET.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer.ConceptResolution;

internal class StandardConceptResolverDataProvider : IStandardConceptResolverDataProvider
{
    private readonly Configuration _configuration;
    private readonly ILogger<StandardConceptResolver> _logger;

    public StandardConceptResolverDataProvider(IOptions<Configuration> configuration, ILogger<StandardConceptResolver> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    public Dictionary<int, IGrouping<int, ConceptCodeMapRow>> GetMappings()
    {
        _logger.LogInformation("Loading mappings codes.");

        var connection = new DuckDBConnection(_configuration.ConnectionString!);
        connection.Open();

        var results = connection.Query<ConceptCodeMapRow>("select * from omop_staging.concept_code_map", CancellationToken.None);

        return
            results
                .GroupBy(row => row.source_concept_id!)
                .ToDictionary(row => row.Key!);
    }

    public Dictionary<int, IReadOnlyCollection<int>> GetDevices()
    {
        _logger.LogInformation("Loading concept device relationships.");

        var connection = new DuckDBConnection(_configuration.ConnectionString!);
        connection.Open();

        var results =
            connection
                .Query<ConceptRelationshipRow>(
                    @"select distinct
	                    cm.source_concept_id as concept_id,
	                    device.concept_id as device_concept_id
                    from omop_staging.concept_code_map cm
	                    inner join cdm.concept_relationship cr
		                    on cm.target_concept_id = cr.concept_id_1
	                    inner join cdm.concept device
		                    on cr.concept_id_2 = device.concept_id
                    where device.standard_concept = 'S'
	                    and cr.relationship_id like '%device%'
	                    and device.domain_id = 'Device'",
                    CancellationToken.None);

        return
            results
                .GroupBy(group => group.concept_id)
                .ToDictionary(
                    row => row.Key,
                    row => (IReadOnlyCollection<int>)row.Select(map => map.device_concept_id).ToList());
    }
}