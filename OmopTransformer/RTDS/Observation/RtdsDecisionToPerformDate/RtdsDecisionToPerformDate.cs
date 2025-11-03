using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS.Observation;

internal class RtdsDecisionToPerformDate : OmopObservation<RtdsDecisionToPerformDateRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4134859, "Decision to perform date")]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateOnlyConverter), nameof(Source.DateStamp))]
    public override DateOnly? observation_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.DateStamp), nameof(Source.DateStamp))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32818, "EHR administration record")]
    public override int? observation_type_concept_id { get; set; }

     [CopyValue(nameof(Source.DateStamp))]
    public override string? value_as_string { get; set; }
    
}