using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.VisitDetails;

[DataOrigin("SUS")]
[Description("Sus Outpatient VisitDetails")]
[SourceQuery("SusOPVisitDetails.xml")]
internal class SusOPVisitDetailsRecord
{
    public string? NHSNumber { get; set; }
    public string? SUSgeneratedspellID { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
    public int? SourceofAdmissionCode { get; set; }
}