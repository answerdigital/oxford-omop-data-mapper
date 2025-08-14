using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Location;

[DataOrigin("RTDS")]
[Description("Rtds PAS Location")]
[SourceQuery("RtdsLocation.xml")]
internal class RtdsLocationRecord
{
    public string? FirstOfNHSNUMBER { get; set; }
    public string? FirstOfPOSTCODE { get; set; }
}