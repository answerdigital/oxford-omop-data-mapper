using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Core.DemographicsV9;

[DataOrigin("COSD")]
[Description("COSD Demographics")]
[SourceQuery("OmopDemographicsV9.xml")]
internal class CosdDemographicsV9
{
    public string? StreetAddressLine1 { get; set; }
    public string? StreetAddressLine2 { get; set; }
    public string? StreetAddressLine3 { get; set; }
    public string? StreetAddressLine4 { get; set; }
    public string? Postcode { get; set; }
    public string? NhsNumber { get; set; }
    public string? DateOfBirth { get; set; }
    public string? EthnicCategory { get; set; }
}