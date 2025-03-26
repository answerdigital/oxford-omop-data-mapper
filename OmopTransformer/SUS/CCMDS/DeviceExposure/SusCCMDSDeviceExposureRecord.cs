using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.CCMDS.DeviceExposure;

[DataOrigin("SUS")]
[Description("SUS CCMDS Device Exposure")]
[SourceQuery("SusCCMDSDeviceExposure.xml")]
internal class SusCCMDSDeviceExposureRecord
{
    public string? NHSNumber { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? DeviceExposureStartDate { get; set; }
    public string? DeviceExposureStartTime { get; set; }
    public string? DeviceExposureEndDate { get; set; }
    public string? DeviceExposureEndTime { get; set; }
    public string? CriticalCareActivityCode { get; set; }
}