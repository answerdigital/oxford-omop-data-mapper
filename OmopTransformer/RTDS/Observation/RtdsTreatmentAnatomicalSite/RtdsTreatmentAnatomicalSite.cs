using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS.Observation;

internal class RtdsTreatmentAnatomicalSite : OmopObservation<RtdsTreatmentAnatomicalSiteRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(37163499, "Radiotherapy course of treatment")]
    public override int[]? observation_concept_id { get; set; }

    [Transform(typeof(DateOnlyConverter), nameof(Source.DueDateTime))]
    public override DateOnly? observation_date { get; set; }

    [Transform(typeof(DateAndTimeCombiner), nameof(Source.DueDateTime), nameof(Source.DueDateTime))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32818, "EHR administration record")]
    public override int? observation_type_concept_id { get; set; }

    [CopyValue(nameof(Source.AnatomicalSiteConceptId))]
    public override int? value_as_concept_id { get; set; }

    [CopyValue(nameof(Source.AttributeValue))]
    public override string? value_source_value { get; set; }
}