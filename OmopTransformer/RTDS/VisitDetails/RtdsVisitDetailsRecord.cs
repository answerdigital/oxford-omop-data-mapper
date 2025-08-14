using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.VisitDetails;

[DataOrigin("RTDS")]
[Description("Rtds VisitDetails")]
[SourceQuery("RtdsVisitDetails.xml")]
internal class RtdsVisitDetailsRecord
{
    public string? PatientId { get; set; }
    public string? event_start_date { get; set; }
    public string? event_end_date { get; set; }
}