using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Breast.Observation.CosdV8BreastAdultPerformanceStatus;

[DataOrigin("COSD")]
[Description("COSD V8 Breast Adult Performance Status")]
[SourceQuery("CosdV8BreastAdultPerformanceStatus.xml")]
internal class CosdV8BreastAdultPerformanceStatusRecord
{
    public string? NhsNumber { get; set; }
    public DateOnly? Date { get; set; }
    public string? AdultPerformanceStatus { get; set; }
}
