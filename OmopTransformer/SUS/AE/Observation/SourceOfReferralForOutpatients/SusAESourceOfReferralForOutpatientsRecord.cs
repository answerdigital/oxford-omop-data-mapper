using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.Observation.SourceOfReferralForOutpatients;

[DataOrigin("SUS")]
[Description("SUS AE Source Of Referral For Outpatients")]
[SourceQuery("SusAESourceOfReferralForOutpatients.xml")]
internal class SusAESourceOfReferralForOutpatientsRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? ArrivalDate { get; set; }
    public string? ArrivalTime { get; set; }
    public string? SourceofReferralForAE { get; set; }
}