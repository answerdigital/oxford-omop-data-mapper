using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.Observation;

internal class SactClinicalTrial : OmopObservation<SactClinicalTrialRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4002165, "Clinical trial")]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateOnlyConverter), nameof(Source.Administration_Date))]
    public override DateOnly? observation_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.Administration_Date), nameof(Source.Administration_Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32818, "EHR administration record")]
    public override int? observation_type_concept_id { get; set; }

    [CopyValue(nameof(Source.Source_value))]
    public override string? observation_source_value { get; set; }
}