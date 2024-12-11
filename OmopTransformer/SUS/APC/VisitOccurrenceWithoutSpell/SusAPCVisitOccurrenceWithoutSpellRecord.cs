using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.VisitOccurrenceWithoutSpell;

[DataOrigin("SUS")]
[Description("SUS APC VisitOccurrenceWithoutSpell")]
[SourceQuery("SusAPCVisitOccurrenceWithoutSpell.xml")]
internal class SusAPCVisitOccurrenceWithoutSpellRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? EpisodeStartDate { get; set; }
    public string? EpisodeStartTime { get; set; }
    public string? EpisodeEndDate { get; set; }
    public string? EpisodeEndTime { get; set; }
    public int? SourceofAdmissionCode { get; set; }
    public int? DischargeDestinationCode { get; set; }
}