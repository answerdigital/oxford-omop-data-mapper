using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Demographics;

[Description("Rtds Demographics")]
[SourceQuery("RtdsDemographics.xml")]
internal class RtdsDemographics
{
    public string? PatientId { get; set; }
    public string? DateOfBirth { get; set; }
    public string? Sex { get; set; }
}