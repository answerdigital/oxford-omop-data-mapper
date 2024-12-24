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

    public int? GetConcept(int conceptId, string? domain)
    {
        lock (_loadingLock)
        {
            _mappings ??= GetMappings();

            if (_mappings.Count == 0)
            {
                throw new InvalidOperationException("concept_code_map table is empty. Call stored procedure omop_staging.generate_concept_code_map first.");
            }
        }

        if (_mappings.TryGetValue(conceptId, out var value))
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
            foreach (var error in _unableToMapByFrequency)
            {
                _logger.LogInformation($"Concept code {error.Key} mapped to 0 codes. Results may be excluded from OMOP database. Error count: {error.Value}.");
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
}