using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Observation.SourceOfReferralForOutpatients;

[DataOrigin("SUS")]
[Description("SUS OP Source Of Referral For Outpatients")]
[SourceQuery("SusAPCSourceOfReferralForOutpatients.xml")]
internal class SusAPCSourceOfReferralForOutpatientsRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? StartDateHospitalProviderSpell { get; set; }
    public string? StartTimeHospitalProviderSpell { get; set; }
    public string? ReferrerCode { get; set; }
}