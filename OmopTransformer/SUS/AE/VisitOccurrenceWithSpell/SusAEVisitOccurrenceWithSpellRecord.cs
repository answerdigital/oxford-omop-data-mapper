using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.VisitOccurrenceWithSpell;

[DataOrigin("SUS")]
[Description("SUS AE VisitOccurrenceWithSpell")]
[SourceQuery("SusOPVisitOccurrenceWithSpell.xml")]
internal class SusAEVisitOccurrenceWithSpellRecord
{
    public string? NHSNumber { get; set; }
    public string? AEAttendanceNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
    public int? VisitOccurrenceConceptId { get; set; }
    public int? VisitTypeConceptId { get; set; }
}