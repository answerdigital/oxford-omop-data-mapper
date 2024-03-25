using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV8AdultComorbidityEvaluation;

[DataOrigin("COSD")]
[Description("CosdV8AdultComorbidityEvaluation")]
[SourceQuery("CosdV8AdultComorbidityEvaluation.xml")]
internal class CosdV8AdultComorbidityEvaluationRecord
{
    public string? NhsNumber { get; set; }
    public string? Date { get; set; }
    public string? AdultComorbidityEvaluation { get; set; }
}
