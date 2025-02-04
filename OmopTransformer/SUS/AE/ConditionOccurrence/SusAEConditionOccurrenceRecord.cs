using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.ConditionOccurrence;

[DataOrigin("SUS")]
[Description("SUS Inpatient Condition Occurrence")]
[SourceQuery("SusAEConditionOccurrence.xml")]
internal class SusAEConditionOccurrenceRecord
{
    public string? DiagnosisICD { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
}