using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Observation;

[DataOrigin("RTDS")]
[Description("RTDS Date of Referral")]
[SourceQuery("RtdsReferralDate.xml")]
internal class RtdsReferralDateRecord
{
    public string? NhsNumber { get; set; }
    public string? DateStamp { get; set; }
}