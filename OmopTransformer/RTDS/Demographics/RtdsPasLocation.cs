using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Demographics;

[Description("Rtds PAS Location")]
[SourceQuery("RtdsLocation.xml")]
internal class RtdsPasLocation
{
    public string? NhsNumber { get; set; }
    public string? Postcode { get; set; }
}