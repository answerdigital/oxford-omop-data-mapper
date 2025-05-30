using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class ConceptResolver
{
    private readonly Configuration _configuration;
    private readonly ILogger<ConceptResolver> _logger;

    private Dictionary<int, Row>? _mappings;
    private Dictionary<int, IReadOnlyCollection<int>>? _devicesByConceptId;

    private readonly object _loadingLock = new();

    private readonly Dictionary<int, int> _unableToMapByFrequency = new();
    private readonly object _unableToMapByFrequencyLock = new();

    public ConceptResolver(IOptions<Configuration> configuration, ILogger<ConceptResolver> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    private Dictionary<int, Row> GetMappings()
    {
        _logger.LogInformation("Loading mappings codes.");

        var connection = new SqlConnection(_configuration.ConnectionString);
            
        connection.Open();

        return
            connection
                .Query<Row>(sql: "select * from omop_staging.concept_code_map")
                .ToDictionary(row => row.source_concept_id!);
    }

    private Dictionary<int, IReadOnlyCollection<int>> GetDevices()
    {
        _logger.LogInformation("Loading concept device relationships.");

        var connection = new SqlConnection(_configuration.ConnectionString);

        connection.Open();

        return
            connection
                .Query<ConceptRelationshipRow>(sql:
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
	                    and device.domain_id = 'Device'")
                .GroupBy(group => group.concept_id)
                .ToDictionary(
                    row => row.Key,
                    row => (IReadOnlyCollection<int>)row.Select(map => map.device_concept_id).ToList());
    }

    private void EnsureMapping()
    {
        lock (_loadingLock)
        {
            _mappings ??= GetMappings();
            _devicesByConceptId ??= GetDevices();

            if (_mappings.Count == 0)
            {
                throw new InvalidOperationException("concept_code_map table is empty. Call stored procedure omop_staging.generate_concept_code_map first.");
            }
        }
    }

    public int? GetConcept(int conceptId, string? domain)
    {
        EnsureMapping();

        if (_mappings!.TryGetValue(conceptId, out var value))
        {
            if (domain == null || value.domain_id!.Equals(domain, StringComparison.OrdinalIgnoreCase))
                return value.target_concept_id;

            return null;
        }

        lock (_unableToMapByFrequencyLock)
        {
            if (_unableToMapByFrequency.TryGetValue(conceptId, out int count))
            {
                _unableToMapByFrequency[conceptId] = ++count;
            }
            else
            {
                _unableToMapByFrequency.Add(conceptId, 1);
            }
        }

        return null;
    }

    public IReadOnlyCollection<int> GetConceptDevices(int conceptId)
    {
        EnsureMapping();

        if (_devicesByConceptId!.TryGetValue(conceptId, out var devices))
        {
            return devices.ToArray();
        }

        return new int[] { };
    }

    public void ResetErrors()
    {
        lock (_unableToMapByFrequencyLock)
        {
            _unableToMapByFrequency.Clear();
        }
    }

    public void PrintErrors()
    {
        lock (_unableToMapByFrequencyLock)
        {
            if (_unableToMapByFrequency.Any())
            {
                string log = "Top 10 unmappable concept codes. Unmappble concepts cannot be recorded." + Environment.NewLine;

                foreach (var error in _unableToMapByFrequency.OrderByDescending(map => map.Value).Take(10))
                {
                    log += $"- concept id: {error.Key}. error count: {error.Value}." + Environment.NewLine;
                }

                _logger.LogWarning(log);
            }
        }
    }

    private class Row
    {
        public string? source_concept_code { get; init; }
        public int source_concept_id { get; init; }
        public int target_concept_id { get; init; }
        public string? domain_id { get; init; }
        public bool mapped_from_standard { get; init; }
    }

    private class ConceptRelationshipRow
    {
        public int concept_id { get; init; }
        public int device_concept_id { get; init; }
    }
}