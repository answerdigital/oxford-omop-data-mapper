using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.ConditionOccurrence;

[DataOrigin("SACT")]
[Description("SACT Condition Occurrence")]
[SourceQuery("SactConditionOccurrence.xml")]
internal class SactConditionOccurrenceRecord
{
    public string? Primary_Diagnosis { get; set; }
    public string? Administration_Date { get; set; }
    public string? NHS_Number { get; set; }
}