using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;
internal class Opcs4Resolver : ConceptLookup
{
    public Opcs4Resolver(IOptions<Configuration> configuration, ILogger<ConceptLookup> logger) : base(configuration, logger)
    {
    }

    public override string Query => "select replace (concept_code, '.', '') as Code, concept_id from cdm.concept where vocabulary_id = 'OPCS4'";
    public override string LoadingLoggerMessage => "Loading OPCS4 codes.";
}
