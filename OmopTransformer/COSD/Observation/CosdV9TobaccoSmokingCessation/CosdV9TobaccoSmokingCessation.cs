using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Observation.CosdV9TobaccoSmokingCessation;

[Notes("Notes", DocumentationNotes.ApproximatedDatesWarning)]
internal class CosdV9TobaccoSmokingCessation : OmopObservation<CosdV9TobaccoSmokingCessationRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(4206526, "Smoking cessation behavior")]
    public override int? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? observation_type_concept_id { get; set; }

    [Transform(typeof(DoubleParser), nameof(Source.TobaccoSmokingCessation))]
    public override double? value_as_number { get; set; }

}
