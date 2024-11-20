using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class ConceptSnomedResolver
{
    private readonly Configuration _configuration;
    private readonly ILogger<ConceptSnomedResolver> _logger;

    private Dictionary<int, IReadOnlyCollection<int>>? _mappings;
    private readonly object _loadingLock = new();

    private readonly Dictionary<int, int> _unableToMapByFrequency = new();
    private readonly object _unableToMapByFrequencyLock = new();

    public ConceptSnomedResolver(IOptions<Configuration> configuration, ILogger<ConceptSnomedResolver> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    private Dictionary<int, IReadOnlyCollection<int>> GetSnomedMappings()
    {
        _logger.LogInformation("Loading SNOMED mappings codes.");

        var connection = new SqlConnection(_configuration.ConnectionString);
            
        connection.Open();

        string query =
"select " +
"	c1.concept_id as ConceptId, " +
"	c2.concept_id as SnomedConceptId " +
"from cdm.concept c1 " +
"	inner join cdm.concept_relationship cr " +
"		on c1.concept_id = cr.concept_id_1 " +
"	inner join cdm.concept c2 " +
"		on cr.concept_id_2 = c2.concept_id " +
"where cr.invalid_reason is null " +
"	and c1.vocabulary_id in ('ICD10', 'OPCS4') " +
"	and cr.relationship_id in ('Maps to', 'Maps to value', 'Is a') " +
"	and c2.vocabulary_id = 'SNOMED'  ";

        return
            connection
                .Query<Row>(sql: query)
                .GroupBy(code => code.ConceptId)
                .ToDictionary(
                    row => row.Key!, 
                    row => (IReadOnlyCollection<int>)row.Select(code => code.SnomedConceptId).ToList());
    }

    public IReadOnlyCollection<int> GetSnomedConcepts(int conceptId)
    {
        lock (_loadingLock)
        {
            _mappings ??= GetSnomedMappings();
        }

        if (_mappings.TryGetValue(conceptId, out var value))
        {
            return value;
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

        return new List<int>();
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
                _logger.LogInformation($"Concept code {error.Key} mapped to 0 snomed codes. Results may be excluded from OMOP database. Error count: {error.Value}.");
            }
        }
    }

    private class Row
    {
        public int ConceptId { get; init; }

        public int SnomedConceptId { get; init; }
    }
}