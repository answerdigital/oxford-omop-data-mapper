using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.ConditionOccurrence;

[DataOrigin("RTDS")]
[Description("Rtds Condition Occurrence")]
[SourceQuery("RtdsConditionOccurrence.xml")]
internal class RtdsConditionOccurrenceRecord
{
    public string? PatientId { get; set; }
    public string? DiagnosisCode { get; set; }
    public string? event_start_date { get; set; }
    public string? event_end_date { get; set; }
}