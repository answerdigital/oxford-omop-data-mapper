using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.ProcedureOccurrence;

[DataOrigin("SUS")]
[Description("SUS APC Procedure Occurrence")]
[SourceQuery("SusAPCProcedureOccurrence.xml")]
internal class SusAPCProcedureOccurrenceRecord
{
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? PrimaryProcedureDate { get; set; }
    public string? PrimaryProcedure { get; set; }
    public string? start_time { get; set; }
}