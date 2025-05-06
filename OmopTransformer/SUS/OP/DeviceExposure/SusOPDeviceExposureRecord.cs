using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.DeviceExposure;

[DataOrigin("SUS")]
[Description("SUS OP Device Exposure")]
[SourceQuery("SusOPDeviceExposure.xml")]
internal class SusOPDeviceExposureRecord
{
    public string? HospitalSpellProviderNumber { get; set; }
    public string? NHSNumber { get; set; }
    public string? AppointmentDate { get; set; }
    public string? AppointmentTime { get; set; }
    public string? PrimaryProcedure { get; set; }
}