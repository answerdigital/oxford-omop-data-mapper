using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class Icd10Resolver
{
    private readonly Configuration _configuration;
    private readonly ILogger<Icd10Resolver> _logger;

    private Dictionary<string, int>? _mappings;
    private readonly object _loadingLock = new ();

    public Icd10Resolver(IOptions<Configuration> configuration, ILogger<Icd10Resolver> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    private Dictionary<string, int> GetIcd10Codes()
    {
        _logger.LogInformation("Loading ICD10 codes.");

        var connection = new SqlConnection(_configuration.ConnectionString);
            
        connection.Open();

        return
            connection
                .Query<Row>(sql: "select concept_id, replace(concept_code, '.', '') as Code from cdm.concept where vocabulary_id = 'ICD10'")
                .ToDictionary(
                    row => row.Code!, 
                    row => row.concept_id);
    }

    public int? GetConceptCode(string? icd10Code)
    {
        lock (_loadingLock)
        {
            _mappings ??= GetIcd10Codes();
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
            text
                .Select((c, index) => new { c, index })
                .FirstOrDefault(charAndIndex => char.IsNumber(charAndIndex.c) == false);

        if (firstNonNumericIndex == null)
            return text;

        return text[..firstNonNumericIndex.index];
    }

    private class Row
    {
        public int concept_id { get; init; }

        public string? Code { get; init; }
    }
}