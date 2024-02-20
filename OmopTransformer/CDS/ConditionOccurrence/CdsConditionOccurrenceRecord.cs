using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.ConditionOccurrence;

[DataOrigin("CDS")]
[Description("CDS Condition Occurrence")]
[SourceQuery("CdsConditionOccurrence.xml")]
internal class CdsConditionOccurrenceRecord
{
    public string? DiagnosisCode { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
}