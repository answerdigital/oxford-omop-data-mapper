using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class Icdo3Resolver
{
    private readonly Configuration _configuration;
    private readonly ILogger<Icdo3Resolver> _logger;

    private Dictionary<string, int>? _mappings;
    private readonly object _loadingLock = new ();

    public Icdo3Resolver(IOptions<Configuration> configuration, ILogger<Icdo3Resolver> logger)
    {
        _logger = logger;
        _configuration = configuration.Value;
    }

    private Dictionary<string, int> GetIcdo3Codes()
    {
        _logger.LogInformation("Loading IDC-O-3 codes.");

        var connection = new SqlConnection(_configuration.ConnectionString);
            
        connection.Open();

        return
            connection
                .Query<Row>(sql: "select concept_id, replace(concept_code, '.', '') as Code from cdm.concept where vocabulary_id = 'ICDO3'")
                .ToDictionary(
                    row => row.Code!, 
                    row => row.concept_id);
    }

    public int? GetConceptCode(string? histology, string? topography)
    {
        lock (_loadingLock)
        {
            _mappings ??= GetIcdo3Codes();
        }

        var code = CovertHistologyTopographyToICDO3(histology, topography);

        if (code == null)
        {
            return null;
        }
        
        return null;
    }

    public static string? CovertHistologyTopographyToICDO3(string? histology, string? topography)
    {
        if (histology == null || topography == null)
            return null;

        return $"{TrimHistology(histology)}-{topography}";
    }

    public static string TrimHistology(string histology)
    {
        histology = histology.Insert(5, "/");
        histology = histology[1..];

        return histology;
    }

    private class Row
    {
        public int concept_id { get; init; }

        public string? Code { get; init; }
    }
}