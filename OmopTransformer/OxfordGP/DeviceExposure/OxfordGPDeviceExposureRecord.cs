using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.DeviceExposure;

[DataOrigin("Oxford-GP")]
[Description("Oxford Device Exposure")]
[SourceQuery("OxfordGPDeviceExposure.xml")]
internal class OxfordGPDeviceExposureRecord
{
    public string? SuppliedCode { get; set; }
    public string? NHSNumber { get; set; }
    public string? EventDate { get; set; }
}