using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.Observation;

internal class SactTreatmentIntent : OmopObservation<SactTreatmentIntentRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4194400, "Treatment intent")]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateOnlyConverter), nameof(Source.Administration_Date))]
    public override DateOnly? observation_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.Administration_Date), nameof(Source.Administration_Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32818, "EHR administration record")]
    public override int? observation_type_concept_id { get; set; }

    [CopyValue(nameof(Source.Source_value))]
    public override string? value_source_value { get; set; }
    
    [Transform(typeof(SactTreatmentIntentLookup), nameof(Source.Intent_Of_Treatment))]
    public override int? value_as_concept_id { get; set; }
}