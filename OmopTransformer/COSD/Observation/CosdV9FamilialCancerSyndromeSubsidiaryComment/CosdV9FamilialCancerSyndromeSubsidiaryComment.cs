using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Observation.CosdV9FamilialCancerSyndromeSubsidiaryComment;

internal class CosdV9FamilialCancerSyndromeSubsidiaryComment : OmopObservation<CosdV9FamilialCancerSyndromeSubsidiaryCommentRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4229852, "Knowledge level: procedure")]
    public override int? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? observation_type_concept_id { get; set; }

    [CopyValue(nameof(Source.FamilialCancerSyndromeSubsidiaryComment))]
    public override string? value_as_string { get; set; }

    [ConstantValue(2000500006, "Familial Cancer (Comment)")]
    public override int? observation_source_concept_id { get; set; }
}