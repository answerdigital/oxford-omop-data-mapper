using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.CarerSupportIndicator;

[DataOrigin("SUS")]
[Description("SUS Inpatient Carer Support Indicator Observation")]
[SourceQuery("SusAPCCarerSupportIndicator.xml")]
internal class SusAPCCarerSupportIndicatorRecord
{
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? CarerSupportIndicator { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
}