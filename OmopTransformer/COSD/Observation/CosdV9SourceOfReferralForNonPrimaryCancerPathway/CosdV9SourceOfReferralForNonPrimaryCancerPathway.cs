using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Observation.CosdV9SourceOfReferralForNonPrimaryCancerPathway;

[Notes("Notes", DocumentationNotes.ApproximatedDatesWarning)]
internal class CosdV9SourceOfReferralForNonPrimaryCancerPathway : OmopObservation<CosdV9SourceOfReferralForNonPrimaryCancerPathwayRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4258129, "Referral by")]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? observation_type_concept_id { get; set; }

    [CopyValue(nameof(Source.SourceOfReferralForNonPrimaryCancerPathway))]
    public override string? value_as_string { get; set; }

}
