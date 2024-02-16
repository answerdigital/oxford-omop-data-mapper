using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class ConceptSnomedResolver
{
    private readonly Configuration _configuration;
    private readonly ILogger<ConceptSnomedResolver> _logger;

    private Dictionary<int, IReadOnlyCollection<int>>? _mappings;
    private readonly object _loadingLock = new ();

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
            "	and c1.vocabulary_id in ('ICD10', 'OPCS4'); ";

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

        _logger.LogInformation($"Concept code {conceptId} mapped to 0 snomed codes. Results may be excluded from OMOP database.");

        return new List<int>();
    }

    private class Row
    {
        public int ConceptId { get; init; }

        public int SnomedConceptId { get; init; }
    }
}