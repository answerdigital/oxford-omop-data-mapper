using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.VisitDetails;

[DataOrigin("SUS")]
[Description("Sus Inptatient VisitDetails")]
[SourceQuery("SusAPCVisitDetails.xml")]
internal class SusAPCVisitDetailsRecord
{
    public string? NHSNumber { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
    public string? SourceofAdmissionCode { get; set; }
    public string? DischargeDestinationCode { get; set; }
}