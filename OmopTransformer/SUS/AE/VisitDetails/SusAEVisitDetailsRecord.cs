using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.VisitDetails;

[DataOrigin("SUS")]
[Description("Sus Inptatient VisitDetails")]
[SourceQuery("SusAEVisitDetails.xml")]
internal class SusAEVisitDetailsRecord
{
    public string? NHSNumber { get; set; }
    public string? AEAttendanceNumber { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
    public int? SourceofAdmissionCode { get; set; }
    public int? DischargeDestinationCode { get; set; }
}