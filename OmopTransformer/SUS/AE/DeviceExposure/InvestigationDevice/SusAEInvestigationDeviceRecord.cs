using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.DeviceExposure.InvestigationDevice;

[DataOrigin("SUS")]
[Description("SUS AE Investigation Device Exposure")]
[SourceQuery("SusAEInvestigationDevice.xml")]
internal class SusAEInvestigationDeviceRecord
{
    public string? AEAttendanceNumber { get; set; }
    public string? NHSNumber { get; set; }
    public string? StartDate { get; set; }
    public string? StartTime { get; set; }
    public string? EndDate { get; set; }
    public string? EndTime { get; set; }
    public string? AccidentAndEmergencyInvestigation { get; set; }
}