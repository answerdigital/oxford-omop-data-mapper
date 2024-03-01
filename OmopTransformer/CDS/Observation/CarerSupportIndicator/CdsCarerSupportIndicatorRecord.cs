using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.CarerSupportIndicator;

[DataOrigin("CDS")]
[Description("Cds Carer Support Indicator Observation")]
[SourceQuery("CdsCarerSupportIndicator.xml")]
internal class CdsCarerSupportIndicatorRecord
{
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? CarerSupportIndicator { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
}   