using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS.Observation;

[Notes(
    "Assumptions",
    "* Multiple records around the same time is indicative of one nominal beam energy with multiple control points being recorded")]
internal class RtdsExternalBeamEnergy : OmopObservation<RtdsExternalBeamEnergyRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4045098, "External beam radiation therapy beam energy")]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateOnlyConverter), nameof(Source.Treatmentdatetime))]
    public override DateOnly? observation_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.Treatmentdatetime), nameof(Source.Treatmentdatetime))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32818, "EHR administration record")]
    public override int? observation_type_concept_id { get; set; }

     [Transform(typeof(DoubleParser), nameof(Source.CalculatedNominalEnergy))]
    public override double? value_as_number { get; set; }

    [CopyValue(nameof(Source.NominalEnergy))]
    public override string? value_source_value { get; set; }
    
}