using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.DeviceExposure.ProcedureDevice;

[DataOrigin("SUS")]
[Description("SUS AE Procedure Device Exposure")]
[SourceQuery("SusAEProcedureDevice.xml")]
internal class SusAEProcedureDeviceRecord
{
    public string? AEAttendanceNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? PrimaryProcedureDate { get; set; }
    public string? PrimaryProcedure { get; set; }
}