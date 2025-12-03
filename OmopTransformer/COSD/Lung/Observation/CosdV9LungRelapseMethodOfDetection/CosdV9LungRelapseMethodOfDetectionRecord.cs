using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Lung.Observation.CosdV9LungRelapseMethodOfDetection;

[DataOrigin("COSD")]
[Description("CosdV9LungRelapseMethodOfDetection")]
[SourceQuery("CosdV9LungRelapseMethodOfDetection.xml")]
internal class CosdV9LungRelapseMethodOfDetectionRecord
{
    public string? NhsNumber { get; set; }
    public DateOnly? Date { get; set; }
    public string? RelapseMethodOfDetection { get; set; }
}
