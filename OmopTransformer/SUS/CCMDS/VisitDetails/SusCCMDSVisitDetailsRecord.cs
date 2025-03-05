using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.CCMDS.VisitDetails;

[DataOrigin("SUS")]
[Description("Sus Critical Care VisitDetails")]
[SourceQuery("SusCCMDSVisitDetails.xml")]
internal class SusCCMDSVisitDetailsRecord
{
    public string? NHSNumber { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
}