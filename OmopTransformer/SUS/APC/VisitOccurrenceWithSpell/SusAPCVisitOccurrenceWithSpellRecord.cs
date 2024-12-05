using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.VisitOccurrenceWithSpell;

[DataOrigin("SUS")]
[Description("SUS APC VisitOccurrenceWithSpell")]
[SourceQuery("SusAPCVisitOccurrenceWithSpell.xml")]
internal class SusAPCVisitOccurrenceWithSpellRecord
{
    public string? NHSNumber { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? EpisodeStartDate { get; set; }
    public string? EpisodeStartTime { get; set; }
    public string? EpisodeEndDate { get; set; }
    public string? EpisodeEndTime { get; set; }
    public int? VisitOccurrenceConceptId { get; set; }
    public int? VisitTypeConceptId { get; set; }
    public int? SourceofAdmissionCode { get; set; }
    public int? DischargeDestinationCode { get; set; }
}