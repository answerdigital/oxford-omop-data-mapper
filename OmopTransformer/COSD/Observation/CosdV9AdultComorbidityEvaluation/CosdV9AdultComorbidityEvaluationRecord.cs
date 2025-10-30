using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV9AdultComorbidityEvaluation;

[DataOrigin("COSD")]
[Description("CosdV9AdultComorbidityEvaluation")]
[SourceQuery("CosdV9AdultComorbidityEvaluation.xml")]
internal class CosdV9AdultComorbidityEvaluationRecord
{
    public string? NhsNumber { get; set; }
    public DateOnly? Date { get; set; }
    public string? AdultComorbidityEvaluation { get; set; }
}
