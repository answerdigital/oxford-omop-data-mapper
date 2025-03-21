using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Observation.CosdV9PerformanceStatusAdult;

[Notes("Notes", DocumentationNotes.ApproximatedDatesWarning)]
internal class CosdV9PerformanceStatusAdult : OmopObservation<CosdV9PerformanceStatusAdultRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4309681, "General physical performance status")]
    public override int? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? observation_type_concept_id { get; set; }

    [Transform(typeof(DoubleParser), nameof(Source.PerformanceStatusAdult))]
    public override double? value_as_number { get; set; }

}
