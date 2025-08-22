using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.ProcedureOccurrence;

[DataOrigin("RTDS")]
[Description("Rtds Procedure Occurrence")]
[SourceQuery("RtdsProcedureOccurrence.xml")]
internal class RtdsProcedureOccurrenceRecord
{
    public string? PatientId { get; set; }
    public string? ProcedureCode { get; set; }
    public string? event_start_date { get; set; }
    public string? event_end_date { get; set; }
}