using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV9AsaScore;

[DataOrigin("COSD")]
[Description("CosdV9AsaScore")]
[SourceQuery("CosdV9AsaScore.xml")]
internal class CosdV9AsaScoreRecord
{
    public string? NhsNumber { get; set; }
    public string? Date { get; set; }
    public string? AsaScore { get; set; }
}
