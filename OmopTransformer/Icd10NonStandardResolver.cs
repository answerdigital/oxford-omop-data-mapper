using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class Icd10NonStandardResolver : Icd10Resolver
{
    public Icd10NonStandardResolver(IOptions<Configuration> configuration, ILogger<Icd10Resolver> logger) : base(configuration, logger)
    {
    }

    public override string Query => "select concept_id, replace(concept_code, '.', '') as Code from cdm.concept where vocabulary_id = 'ICD10'";
}