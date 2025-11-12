using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Core.DemographicsV8;

[DataOrigin("COSD")]
[Description("COSD Demographics v8")]
[SourceQuery("OmopDemographicsV8.xml")]
internal class CosdDemographicsV8
{
    public string? StreetAddressLine1 { get; set; }
    public string? StreetAddressLine2 { get; set; }
    public string? StreetAddressLine3 { get; set; }
    public string? StreetAddressLine4 { get; set; }
    public string? Postcode { get; set; }
    public string? NhsNumber { get; set; }
    public string? PersonBirthDate { get; set; }
    public string? DateOfBirth { get; set; }
}