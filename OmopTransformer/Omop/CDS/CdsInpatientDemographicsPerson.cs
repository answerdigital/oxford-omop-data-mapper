using OmopTransformer.Annotations;
using OmopTransformer.CDS.InpatientDemographics;
using OmopTransformer.Transformation;

namespace OmopTransformer.Omop.CDS;

internal class CdsInpatientDemographicsPerson : OmopPerson<CdsInpatientDemographics>
{
    [Transform(typeof(GenderLookup), "person_current_gender")]
    public override int gender_concept_id { get; set; }

    [CopyValue("nhs_number")]
    public override string? person_source_value { get; set; }

    [Transform(typeof(MonthOfYearSelector), "person_birth_date")]
    public override int month_of_birth { get; set; }
}