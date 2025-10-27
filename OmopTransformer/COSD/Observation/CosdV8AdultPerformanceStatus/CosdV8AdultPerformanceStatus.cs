using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Observation.CosdV8AdultPerformanceStatus;

[Notes("Notes", DocumentationNotes.ApproximatedDatesWarning)]
internal class CosdV8AdultPerformanceStatus : OmopObservation<CosdV8AdultPerformanceStatusRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4309681, "General physical performance status")]
    public override int[]? observation_concept_id { get; set; }

    [CopyValue(nameof(Source.Date))]
    public override DateOnly? observation_date { get; set; }

    [CopyValue(nameof(Source.Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? observation_type_concept_id { get; set; }

    [Transform(typeof(DoubleParser), nameof(Source.AdultPerformanceStatus))]
    public override double? value_as_number { get; set; }

}
