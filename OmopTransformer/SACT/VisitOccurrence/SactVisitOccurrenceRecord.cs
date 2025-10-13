using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.VisitOccurrence;

[DataOrigin("SACT")]
[Description("Sact VisitOccurrence")]
[SourceQuery("SactVisitOccurrence.xml")]
internal class SactVisitOccurrenceRecord
{
    public string? NHS_Number { get; set; }
    public string? Administration_date { get; set; }
}