using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Lung.Observation.CosdV8LungRelapseMethodOfDetection;

[Notes("Notes", DocumentationNotes.ApproximatedDatesWarning)]
internal class CosdV8LungRelapseMethodOfDetection : OmopObservation<CosdV8LungRelapseMethodOfDetectionRecord>
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

    [Transform(typeof(RelapseMethodOfDetectionLungLookup), nameof(Source.RelapseMethodDetectionType))]
    public override int? value_as_concept_id { get; set; }

    [CopyValue(nameof(Source.RelapseMethodDetectionType))]
    public override string? value_source_value { get; set; }
}
