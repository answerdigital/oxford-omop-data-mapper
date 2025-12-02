using System.Collections.Concurrent;
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
    private DomainMapResults? _domainMappingResults;

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
    
    private static int? ResolveConcept(Row row, string domain)
    {
        const int unknownConceptId = 0;

        // Standard or non standard with relationship with standard concept in concept correct domain
        if (row.target_domain_id == domain && row.target_concept_id.HasValue)
        {
            return row.target_concept_id;
        }


        //Non standard or Standard concept in wrong domain

        if (row.target_domain_id != domain && row.target_concept_id.HasValue)
        {
            return null;
        }

        //Non standard concept in wrong domain with no relationship to standard 

        if (row.mapped_from_standard == 0 && row.source_domain_id != domain && row.target_concept_id.HasValue == false)
        {
            return null;
        }

        // Non standard concept in correct domain with no relationship to standard
        if (row.mapped_from_standard == 0 && row.source_domain_id == domain && row.target_concept_id.HasValue == false)
        {
            return unknownConceptId;
        }

        return null;
    }

    public int[] GetConcepts(int conceptId, string? domain)
    {
        EnsureMapping();

        const int unknownConceptId = 0;

        var unknownConcept = new int[] { unknownConceptId };

        //| Domain Constraint | Input | Source Concept Id | Concept Id |
        //| -------------------| -------| ------------------| ------------|
        //| No | Unknown concept | 0 | 0 |
        //| No | Standard concept | 456 | 456 |
        //| No | Non standard concept with no relationship to standard | 123 | 0 |
        //| No | Non standard concept with relationship to standard | 123 | 456 |
        //| Yes | Unknown concept | 0 | 0 |
        //| Yes | Standard concept correct domain | 456 | 456 |
        //| Yes | Non standard concept with relationship to standard in correct domain | 123 | 456 |
        //| Yes | Non standard concept in correct domain with no relationship to standard | 123 | 0 |
        //| Yes | Standard concept wrong domain | null | null |
        //| Yes | Non standard concept in wrong domain with no relationship to standard | null | null |
        //| Yes | Non standard concept with relationship to standard in wrong domain | null | null


        if (domain == null)
        {
            if (_mappings!.TryGetValue(conceptId, out var value))
            {
                if (value.Any(row => row.target_concept_id.HasValue == false))
                {
                    // Non standard concept with no relationship to standard

                    return unknownConcept;
                }

                // Standard concept or Non standard concept with relationship to standard
                return
                    value
                        .Select(row => row.target_concept_id!.Value)
                        .ToArray();
            }

            // Unknown concept
            return unknownConcept;
        }
        else
        {
            if (_mappings!.TryGetValue(conceptId, out var value))
            {

                var resolvedConcepts =
                    value
                        .Select(row => ResolveConcept(row, domain))
                        .Where(result => result.HasValue)
                        .Select(result => result!.Value)
                        .ToArray();

                if (resolvedConcepts.Length > 0)
                {
                    return resolvedConcepts;
                }
            }

            return unknownConcept;
        }
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

    public void PrintLogsAndResetLogger()
    {
        _domainMappingResults?.PrintResults(_logger);
        _domainMappingResults = null;
    }

    private class Row
    {
        public int source_concept_id { get; init; }
        public int? target_concept_id { get; init; }

        public string? source_domain_id { get; init; }
        public string? target_domain_id { get; init; }
        public byte mapped_from_standard { get; init; }
    }

    private class ConceptRelationshipRow
    {
        public int concept_id { get; init; }
        public int device_concept_id { get; init; }
    }

    private class DomainMapResults
    {
        public DomainMapResults(string intendedDomain)
        {
            _intendedDomain = intendedDomain;
        }

        private readonly ConcurrentDictionary<string, int> _domainCounts = new();
        private readonly string _intendedDomain;

        public void Record(string domain)
        {
            _domainCounts.AddOrUpdate(domain, 1, (_, count) => count + 1);
        }

        public void PrintResults(ILogger<StandardConceptResolver> logger)
        {
            if (_domainCounts.Count == 0)
                return;

            if (_domainCounts.Count == 1 && _domainCounts.ContainsKey(_intendedDomain))
                return;

            long total = _domainCounts.Sum(count => count.Value);

            string logText = $"Source concepts intended for domain {_intendedDomain} were mapped to the following domains:" + Environment.NewLine;

            foreach (var domainCount in _domainCounts.OrderByDescending(count => count.Value))
            {
                var percentage = (domainCount.Value * 100d) / total;
                logText += $"   - Domain: {domainCount.Key}. Count: {domainCount.Value}. Percentage: {Math.Round(percentage, 2)}%." + Environment.NewLine;
            }

            logger.LogInformation(logText);
        }
    }
}