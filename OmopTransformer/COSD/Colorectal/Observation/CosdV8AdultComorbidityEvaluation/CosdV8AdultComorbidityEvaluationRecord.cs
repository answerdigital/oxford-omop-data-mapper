using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Colorectal.Observation.CosdV8AdultComorbidityEvaluation;

[DataOrigin("COSD")]
[Description("CosdV8AdultComorbidityEvaluation")]
[SourceQuery("CosdV8AdultComorbidityEvaluation.xml")]
internal class CosdV8AdultComorbidityEvaluationRecord
{
    public string? NhsNumber { get; set; }
    public DateOnly? Date { get; set; }
    public string? AdultComorbidityEvaluation { get; set; }
}
