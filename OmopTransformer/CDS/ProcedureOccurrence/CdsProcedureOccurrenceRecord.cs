using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.ProcedureOccurrence;

[DataOrigin("CDS")]
[Description("CDS Procedure Occurrence")]
[SourceQuery("CdsProcedureOccurrence.xml")]
internal class CdsProcedureOccurrenceRecord
{
    public string? RecordConnectionIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? PrimaryProcedureDate { get; set; }
    public string? PrimaryProcedure { get; set; }
}