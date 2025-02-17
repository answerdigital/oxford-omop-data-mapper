using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.DeviceExposure;

[DataOrigin("SUS")]
[Description("SUS AE Device Exposure")]
[SourceQuery("SusAEDeviceExposure.xml")]
internal class SusAEDeviceExposureRecord
{
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? StartDate { get; set; }
    public string? StartTime { get; set; }
    public string? EndDate { get; set; }
    public string? EndTime { get; set; }
    public string? AccidentAndEmergencyInvestigation { get; set; }
    public string? device_source_value { get; set; }
}