using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class Opcs4Resolver
{
    private readonly Configuration _configuration;
    private readonly ILogger<Opcs4Resolver> _logger;

    private Dictionary<string, int>? _mappings;
    private readonly object _loadingLock = new ();

    public Opcs4Resolver(IOptions<Configuration> configuration, ILogger<Opcs4Resolver> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    private Dictionary<string, int> GetOpcs4Codes()
    {
        _logger.LogInformation("Loading OPCS4 codes.");

        var connection = new SqlConnection(_configuration.ConnectionString);
            
        connection.Open();

        return
            connection
                .Query<Row>(sql: "select replace (concept_code, '.', '') as Code, concept_id from cdm.concept where vocabulary_id = 'OPCS4'")
                .ToDictionary(
                    row => row.Code!, 
                    row => row.concept_id);
    }

    public int? GetConceptCode(string? opcs4Code)
    {
        lock (_loadingLock)
        {
            _mappings ??= GetOpcs4Codes();
        }

        if (opcs4Code == null)
        {
            return null;
        }

        if (_mappings.TryGetValue(opcs4Code, out var value))
        {
            return value;
        }

        var parentCode = opcs4Code[..^1];

        if (_mappings.TryGetValue(parentCode, out var parentValue))
        {
            return parentValue;
        }

        return null;
    }

    private class Row
    {
        public int concept_id { get; init; }

        public string? Code { get; init; }
    }
}