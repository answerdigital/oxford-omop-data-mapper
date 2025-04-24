using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace OmopTransformer;
internal class MeasurementMapsToValueResolver : Icd10ConceptLookup
{
    public MeasurementMapsToValueResolver(IOptions<Configuration> configuration, ILogger<ConceptLookup> logger) : base(configuration, logger)
    {
    }

    public override string Query =>
        @"select
                  replace(c.concept_code, '.', '') as Code,
                  cr.concept_id_2 as concept_id
          from cdm.concept c
                  inner join cdm.concept_relationship cr
                  on c.concept_id = cr.concept_id_1
          where cr.relationship_id = 'Maps to value'
          and c.domain_id = 'Measurement'";
}