using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.CCMDS.ProcedureOccurrence;

[DataOrigin("SUS")]
[Description("SUS CCMDS Procedure Occurrence")]
[SourceQuery("SusCCMDSProcedureOccurrence.xml")]
internal class SusCCMDSProcedureOccurrenceRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? ProcedureOccurrenceStartDate { get; set; }
    public string? ProcedureOccurrenceStartTime { get; set; }
    public string? ProcedureOccurrenceEndDate { get; set; }
    public string? ProcedureOccurrenceEndTime { get; set; }
    public string? ProcedureSourceValue { get; set; }
}