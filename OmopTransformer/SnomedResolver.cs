using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class SnomedResolver : ConceptLookup
{
    public SnomedResolver(IOptions<Configuration> configuration, ILogger<ConceptLookup> logger) : base(configuration, logger)
    {
    }

    public override bool TryParentCode => false;

    public override string Query => "select concept_id, concept_code as Code from cdm.concept where vocabulary_id = 'SNOMED'";
    public override string LoadingLoggerMessage => "Loading Snomed codes.";
}
