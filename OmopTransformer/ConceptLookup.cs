using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal abstract class ConceptLookup
{
    private readonly Configuration _configuration;
    private readonly ILogger<ConceptLookup> _logger;

    private Dictionary<string, int>? _mappings;
    private readonly object _loadingLock = new();

    protected ConceptLookup(IOptions<Configuration> configuration, ILogger<ConceptLookup> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    private Dictionary<string, int> GetIcd10Codes()
    {
        _logger.LogInformation(LoadingLoggerMessage);

        var connection = new SqlConnection(_configuration.ConnectionString);

        connection.Open();

        return
            connection
                .Query<ConceptMappingRow>(sql: Query)
                .ToDictionary(
                    row => row.Code!,
                    row => row.concept_id);
    }

    public abstract string Query { get; }
    public abstract string LoadingLoggerMessage { get; }

    public virtual string FormatCode(string code) => code;

    public int? GetConceptCode(string? code)
    {
        lock (_loadingLock)
        {
            _mappings ??= GetIcd10Codes();
        }

        if (code == null)
        {
            return null;
        }

        var formatCode = FormatCode(code);

        if (_mappings.TryGetValue(formatCode, out var value))
        {
            return value;
        }

        var parentCode = formatCode[..^1];

        if (_mappings.TryGetValue(parentCode, out var parentValue))
        {
            return parentValue;
        }

        return null;
    }
}

internal class ConceptMappingRow
{
    public int concept_id { get; init; }

    public string? Code { get; init; }
}