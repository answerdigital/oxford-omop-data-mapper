using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Demographics;

[SourceQuery("OmopDemographics.xml")]
internal class CosdDemographics
{
    public string? StreetAddressLine1 { get; set; }
    public string? StreetAddressLine2 { get; set; }
    public string? StreetAddressLine3 { get; set; }
    public string? StreetAddressLine4 { get; set; }
    public string? PostcodeOfUsualAddressAtDiagnosis { get; set; }
    public string? NhsNumber { get; set; }
    public string? PersonBirthDate { get; set; }
}