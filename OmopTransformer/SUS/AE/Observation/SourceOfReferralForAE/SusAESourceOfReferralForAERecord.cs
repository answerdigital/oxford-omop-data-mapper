using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.Observation.SourceOfReferralForAE;

[DataOrigin("SUS")]
[Description("SUS AE Source Of Referral For AE")]
[SourceQuery("SusAESourceOfReferralForAE.xml")]
internal class SusAESourceOfReferralForAERecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? ArrivalDate { get; set; }
    public string? ArrivalTime { get; set; }
    public string? SourceofReferralForAE { get; set; }
}