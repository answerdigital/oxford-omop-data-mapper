using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.ConditionOccurrence;

[DataOrigin("SUS")]
[Description("SUS Outpatient Condition Occurrence")]
[SourceQuery("SusOPConditionOccurrence.xml")]
internal class SusOPConditionOccurrenceRecord
{
    public string? DiagnosisICD { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
}