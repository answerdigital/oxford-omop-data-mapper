using OmopTransformer.Annotations;
using OmopTransformer.Omop.Observation;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.Observation.CosdV8AdultComorbidityEvaluation;

[Notes("Notes", DocumentationNotes.ApproximatedDatesWarning)]
internal class CosdV8AdultComorbidityEvaluation : OmopObservation<CosdV8AdultComorbidityEvaluationRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [ConstantValue(40487424, "Adult comorbidity evaluation-27 score")]
    public override int? observation_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Date))]
    public override DateTime? observation_datetime { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? observation_type_concept_id { get; set; }

    [Transform(typeof(NumberParser), nameof(Source.AdultComorbidityEvaluation))]
    public override int? value_as_number { get; set; }

}
