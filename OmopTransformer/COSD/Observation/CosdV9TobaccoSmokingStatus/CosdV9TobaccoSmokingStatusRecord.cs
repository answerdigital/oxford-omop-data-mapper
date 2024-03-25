using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV9TobaccoSmokingStatus;

[DataOrigin("COSD")]
[Description("CosdV9TobaccoSmokingStatus")]
[SourceQuery("CosdV9TobaccoSmokingStatus.xml")]
internal class CosdV9TobaccoSmokingStatusRecord
{
    public string? NhsNumber { get; set; }
    public string? Date { get; set; }
    public string? TobaccoSmokingStatus { get; set; }
}
