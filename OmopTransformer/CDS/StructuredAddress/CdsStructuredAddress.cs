using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.StructuredAddress;

[Description("CDS Structured Address")]
[SourceQuery("CdsStructuredAddress.xml")]
internal class CdsStructuredAddress
{
    public string? PatientAddressStructured1 { get; set; }
	public string? PatientAddressStructured2 { get; set; }
	public string? PatientAddressStructured3 { get; set; }
	public string? PatientAddressStructured4 { get; set; }
	public string? PatientAddressStructured5 { get; set; }
	public string? Postcode { get; set; }
}