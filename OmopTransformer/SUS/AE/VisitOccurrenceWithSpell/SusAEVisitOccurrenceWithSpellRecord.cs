using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.VisitOccurrenceWithSpell;

[DataOrigin("SUS")]
[Description("SUS AE VisitOccurrenceWithSpell")]
[SourceQuery("SusAEVisitOccurrenceWithSpell.xml")]
internal class SusAEVisitOccurrenceWithSpellRecord
{
    public string? NHSNumber { get; set; }
    public string? AEAttendanceNumber { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
    public string? SourceofAdmissionCode { get; set; }
    public string? DischargeDestinationCode { get; set; }
}
