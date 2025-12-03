using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Lung.Observation.CosdV9LungRelapseMethodOfDetection;

[Notes("Notes", DocumentationNotes.ApproximatedDatesWarning)]
internal class CosdV9LungRelapseMethodOfDetection : OmopObservation<CosdV9LungRelapseMethodOfDetectionRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4049924, "Method of detection")]
    public override int[]? observation_concept_id { get; set; }

    [CopyValue(nameof(Source.Date))]
    public override DateOnly? observation_date { get; set; }

    [CopyValue(nameof(Source.Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? observation_type_concept_id { get; set; }

    [Transform(typeof(RelapseMethodOfDetectionLungLookup), nameof(Source.RelapseMethodOfDetection))]
    public override int? value_as_concept_id { get; set; }

    [CopyValue(nameof(Source.RelapseMethodOfDetection))]
    public override string? value_source_value { get; set; }
}
