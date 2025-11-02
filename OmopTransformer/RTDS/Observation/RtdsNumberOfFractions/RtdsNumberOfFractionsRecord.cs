using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Observation;

[DataOrigin("RTDS")]
[Description("RTDS Number Of Fractions")]
[SourceQuery("RtdsNumberOfFractions.xml")]
internal class RtdsNumberOfFractionsRecord
{
    public string? NhsNumber { get; set; }
    public string? StartDateTime { get; set; }
    public string? NoFracs { get; set; }
}