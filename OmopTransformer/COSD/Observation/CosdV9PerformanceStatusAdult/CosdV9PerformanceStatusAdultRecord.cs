using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV9PerformanceStatusAdult;

[DataOrigin("COSD")]
[Description("CosdV9PerformanceStatusAdult")]
[SourceQuery("CosdV9PerformanceStatusAdult.xml")]
internal class CosdV9PerformanceStatusAdultRecord
{
    public string? NhsNumber { get; set; }
    public string? Date { get; set; }
    public string? PerformanceStatusAdult { get; set; }
}
