using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.ProcedureOccurrence;

[DataOrigin("SUS")]
[Description("SUS AE Procedure Occurrence")]
[SourceQuery("SusAEProcedureOccurrence.xml")]
internal class SusAEProcedureOccurrenceRecord
{
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? PrimaryProcedureDate { get; set; }
    public string? PrimaryProcedure { get; set; }
}