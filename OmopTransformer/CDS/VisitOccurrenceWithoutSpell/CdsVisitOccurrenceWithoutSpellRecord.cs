using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.VisitOccurrenceWithoutSpell;

[DataOrigin("CDS")]
[Description("CDS VisitOccurrenceWithoutSpell")]
[SourceQuery("CdsVisitOccurrenceWithoutSpell.xml")]
internal class CdsVisitOccurrenceWithoutSpellRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? EpisodeStartDate { get; set; }
    public string? EpisodeStartTime { get; set; }
    public string? EpisodeEndDate { get; set; }
    public string? EpisodeEndTime { get; set; }
    public int? VisitOccurenceConceptId { get; set; }
    public int? VisitTypeConceptId { get; set; }
    public int? SourceofAdmissionCode { get; set; }
    public int? DischargeDestinationCode { get; set; }
}