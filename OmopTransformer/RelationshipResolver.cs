using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class RelationshipResolver
{
    private readonly Configuration _configuration;
    private readonly ILogger<RelationshipResolver> _logger;

    private Dictionary<string, string>? _mappings;
    private readonly object _loadingLock = new();

    public RelationshipResolver(IOptions<Configuration> configuration, ILogger<RelationshipResolver> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    private Dictionary<string, string> GetRelationshipMappings()
    {
        _logger.LogInformation("Loading relationship mappings from ICD-10 to OMOP concepts.");

        using var connection = new SqlConnection(_configuration.ConnectionString);

        connection.Open();

        string query = @"select 
                        replace(ccm.source_concept_code, '.', '') as Code,
                        cast(cr.concept_id_2 as varchar) as concept_id
                    from omop_staging.concept_code_map ccm
                    inner join cdm.concept_relationship cr
                        on ccm.source_concept_id = cr.concept_id_1
                    where cr.relationship_id = 'Maps to value'";

        var dictionary = new Dictionary<string, string>();

        foreach (var row in connection.Query<Row>(sql: query))
        {
            dictionary[row.Code!] = row.concept_id;
        }

        return dictionary;
    }

    public string? GetRelatedConceptValue(string? icd10Code)
    {
        lock (_loadingLock)
        {
            _mappings ??= GetRelationshipMappings();
        }

        if (icd10Code == null)
        {
            return null;
        }

        var code = TrimIcd10(icd10Code);

        if (_mappings.TryGetValue(code, out var value))
        {
            return value;
        }

        var parentCode = code[..^1];

        if (_mappings.TryGetValue(parentCode, out var parentValue))
        {
            return parentValue;
        }

        return null;
    }

    internal static string TrimIcd10(string code)
    {
        if (code.Length <= 2)
            throw new ArgumentException($"Code is too short. Code is {code}.", nameof(code));

        code = code.Replace(".", "");

        char firstCharOfCode = code[0];

        var remainder = code[1..];

        return firstCharOfCode + TrimAtFirstNonNumericChar(remainder);
    }

    private static string TrimAtFirstNonNumericChar(string text)
    {
        var firstNonNumericIndex = 
            text.Select((c, index) => new { c, index })
                .FirstOrDefault(charAndIndex => !char.IsNumber(charAndIndex.c));

        return firstNonNumericIndex == null ? text : text[..firstNonNumericIndex.index];
    }

    private class Row
    {
        public string? concept_id { get; init; }

        public string? Code { get; init; }
    }
}