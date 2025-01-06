using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.ProcedureOccurrence;

[DataOrigin("SUS")]
[Description("SUS Outpatient Procedure Occurrence")]
[SourceQuery("SusOPProcedureOccurrence.xml")]
internal class SusOPProcedureOccurrenceRecord
{
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? AppointmentDate { get; set; }
    public string? PrimaryProcedure { get; set; }
}