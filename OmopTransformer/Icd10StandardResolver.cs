using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;

internal class Icd10StandardResolver : Icd10ConceptLookup
{
    public Icd10StandardResolver(IOptions<Configuration> configuration, ILogger<ConceptLookup> logger) : base(configuration, logger)
    {
    }

    public override string Query =>
        "select " +
        "	ccm.target_concept_id as concept_id, " +
        "	replace(ccm.source_concept_code, '.', '') as Code  " +
        "from omop_staging.concept_code_map ccm " +
        "	inner join cdm.concept c " +
        "		on ccm.source_concept_id = c.concept_id " +
        "where c.vocabulary_id = 'ICD10' ";

}