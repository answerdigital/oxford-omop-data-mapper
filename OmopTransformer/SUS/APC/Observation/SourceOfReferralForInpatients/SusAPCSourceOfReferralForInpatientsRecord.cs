using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.SourceOfReferralForInpatients;

[DataOrigin("SUS")]
[Description("SUS APC Source Of Referral For Inpatients")]
[SourceQuery("SusAPCSourceOfReferralForInpatients.xml")]
internal class SusAPCSourceOfReferralForInpatientsRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? StartDateHospitalProviderSpell { get; set; }
    public string? StartTimeHospitalProviderSpell { get; set; }
    public string? ReferrerCode { get; set; }
}