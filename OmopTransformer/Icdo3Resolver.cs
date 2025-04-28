using Microsoft.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class Icdo3Resolver : ConceptLookup
{
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

    public Icdo3Resolver(IOptions<Configuration> configuration, ILogger<ConceptLookup> logger) : base(configuration, logger)
    {
    }

    public override string Query => "select concept_id, concept_code as Code from cdm.concept where vocabulary_id = 'ICDO3'";
    public override string LoadingLoggerMessage => "Loading IDC-O-3 codes.";
}
