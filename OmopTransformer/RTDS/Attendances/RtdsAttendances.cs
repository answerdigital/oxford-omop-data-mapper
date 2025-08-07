using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Attendances;

[DataOrigin("RTDS")]
[Description("Rtds Attendances")]
[SourceQuery("RtdsAttendances.xml")]
internal class RtdsAttendances
{
    public string? PatientId { get; set; }
    public string? ProcedureCode { get; set; }
    public string? ActualStartDateTime_s { get; set; }
    public string? ActualEndDateTime_s { get; set; }
}