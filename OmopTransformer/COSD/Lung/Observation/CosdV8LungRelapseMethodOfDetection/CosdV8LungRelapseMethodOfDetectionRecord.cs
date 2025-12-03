using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Lung.Observation.CosdV8LungRelapseMethodOfDetection;

[DataOrigin("COSD")]
[Description("CosdV8LungRelapseMethodOfDetection")]
[SourceQuery("CosdV8LungRelapseMethodOfDetection.xml")]
internal class CosdV8LungRelapseMethodOfDetectionRecord
{
    public string? NhsNumber { get; set; }
    public DateOnly? Date { get; set; }
    public string? RelapseMethodDetectionType { get; set; }
}
