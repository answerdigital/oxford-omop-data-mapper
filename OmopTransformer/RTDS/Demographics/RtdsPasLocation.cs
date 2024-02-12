using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Demographics;

[DataOrigin("RTDS")]
[Description("Rtds PAS Location")]
[SourceQuery("RtdsLocation.xml")]
internal class RtdsPasLocation
{
    public string? FirstOfNHSNUMBER { get; set; }
    public string? FirstOfPOSTCODE { get; set; }
}