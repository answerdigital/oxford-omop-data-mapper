using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.VisitOccurrence;

[DataOrigin("RTDS")]
[Description("Rtds VisitOccurrence")]
[SourceQuery("RtdsVisitOccurrence.xml")]
internal class RtdsVisitOccurrenceRecord
{
    public string? NhsNumber { get; set; }
    public string? event_start_date { get; set; }
    public string? event_end_date { get; set; }
}