using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS.Observation;

internal class RtdsNumberOfFractions : OmopObservation<RtdsNumberOfFractionsRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4037631, "Number of fractions")]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateOnlyConverter), nameof(Source.StartDateTime))]
    public override DateOnly? observation_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.StartDateTime), nameof(Source.StartDateTime))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32818, "EHR administration record")]
    public override int? observation_type_concept_id { get; set; }

     [Transform(typeof(DoubleParser), nameof(Source.NoFracs))]
    public override double? value_as_number { get; set; }

    [CopyValue(nameof(Source.NoFracs))]
    public override string? value_source_value { get; set; }
    
}