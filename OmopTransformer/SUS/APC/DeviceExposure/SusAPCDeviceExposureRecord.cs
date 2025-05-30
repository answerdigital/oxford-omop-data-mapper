using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.DeviceExposure;

[DataOrigin("SUS")]
[Description("SUS APC Procedure Occurrence")]
[SourceQuery("SusAPCDeviceExposure.xml")]
internal class SusAPCDeviceExposureRecord
{
    public string? HospitalProviderSpellNumber { get; set; }
    public string? NHSNumber { get; set; }
    public string? PrimaryProcedureDate { get; set; }
    public string? PrimaryProcedure { get; set; }
}