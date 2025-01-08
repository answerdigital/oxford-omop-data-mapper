using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Observation.CarerSupportIndicator;

[DataOrigin("SUS")]
[Description("SUS Outpatient Carer Support Indicator Observation")]
[SourceQuery("SusOPCarerSupportIndicator.xml")]
internal class SusOPCarerSupportIndicatorRecord
{
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? CarerSupportIndicator { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
}