using Dapper;
using DuckDB.NET.Data;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class StandardConceptResolver
{
    private readonly Configuration _configuration;
    private readonly ILogger<StandardConceptResolver> _logger;

    private Dictionary<int, IGrouping<int, Row>>? _mappings;
    private Dictionary<int, IReadOnlyCollection<int>>? _devicesByConceptId;

    private readonly object _loadingLock = new();

    private readonly Dictionary<int, int> _unableToMapByFrequency = new();
    private readonly object _unableToMapByFrequencyLock = new();

    public StandardConceptResolver(IOptions<Configuration> configuration, ILogger<StandardConceptResolver> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    private Dictionary<int, IGrouping<int, Row>> GetMappings()
    {
        _logger.LogInformation("Loading mappings codes.");

        var connection = new DuckDBConnection(_configuration.ConnectionString!);
        connection.Open();

        var results = connection.Query<Row>("select * from omop_staging.concept_code_map", CancellationToken.None);

        return
            results
                .GroupBy(row => row.source_concept_id!)
                .ToDictionary(row => row.Key!);
    }

    private Dictionary<int, IReadOnlyCollection<int>> GetDevices()
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

    private void EnsureMapping()
    {
        if (_mappings != null) 
            return;

        lock (_loadingLock)
        {
            _mappings ??= GetMappings();

            if (_mappings.Count == 0)
            {
                throw new InvalidOperationException("concept_code_map table is empty. Call stored procedure omop_staging.generate_concept_code_map first.");
            }
        }
    }

    private void EnsureDeviceMapping()
    {
        lock (_loadingLock)
        {
            _devicesByConceptId ??= GetDevices();
        }
    }

    public int[] GetConcepts(int conceptId, string? domain)
    {
        const int unknownConceptId = 0;

        EnsureMapping();
        bool foundMapping = false;

        if (_mappings!.TryGetValue(conceptId, out var value))
        {
            foundMapping = true;

            var results =
                value
                    .Where(row => domain == null || row.domain_id!.Equals(domain, StringComparison.OrdinalIgnoreCase))
                    .Select(row => row.target_concept_id)
                    .ToArray();

            if (results.Length > 0)
                return results;
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

        // if no domain specified, return unknown concept
        // if domain specified, and mapping not found, return unknown concept
        // if domain specified, and mapping found but it is in the wrong domain, return empty 

        if (domain == null || foundMapping == false)
        {
            return new int[] { unknownConceptId };
        }

        return new int[] { };
    }

    public IReadOnlyCollection<int> GetConceptDevices(int conceptId)
    {
        EnsureDeviceMapping();

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
        public int source_concept_id { get; init; }
        public int target_concept_id { get; init; }
        public string? domain_id { get; init; }
        public byte mapped_from_standard { get; init; }
    }

    private class ConceptRelationshipRow
    {
        public int concept_id { get; init; }
        public int device_concept_id { get; init; }
    }
}