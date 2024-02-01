using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.VisitOccurrenceWithSpell;

[Description("CDS VisitOccurrenceWithSpell")]
[SourceQuery("CdsVisitOccurrenceWithSpell.xml")]
internal class CdsVisitOccurrenceWithSpellRecord
{
    public string? NHSNumber { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? EpisodeStartDate { get; set; }
    public string? EpisodeStartTime { get; set; }
    public string? EpisodeEndDate { get; set; }
    public string? EpisodeEndTime { get; set; }
    public int? VisitOccurenceConceptId { get; set; }
    public int? VisitTypeConceptId { get; set; }
}