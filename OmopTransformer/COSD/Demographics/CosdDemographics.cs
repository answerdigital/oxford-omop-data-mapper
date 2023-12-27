using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Demographics;

[Description("COSD Demographics")]
[SourceQuery("OmopDemographics.xml")]
internal class CosdDemographics
{
    public string? StreetAddressLine1 { get; set; }
    public string? StreetAddressLine2 { get; set; }
    public string? StreetAddressLine3 { get; set; }
    public string? StreetAddressLine4 { get; set; }
    public string? Postcode { get; set; }
    public string? NhsNumber { get; set; }
    public string? PersonBirthDate { get; set; }
    public string? DateOfBirth { get; set; }
    public string? EthnicCategory { get; set; }
}