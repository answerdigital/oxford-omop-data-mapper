using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.ConditionOccurrence;

[DataOrigin("SUS")]
[Description("SUS Inpatient Condition Occurrence")]
[SourceQuery("SusAPCConditionOccurrence.xml")]
internal class SusAPCConditionOccurrenceRecord
{
    public string? DiagnosisICD { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
}