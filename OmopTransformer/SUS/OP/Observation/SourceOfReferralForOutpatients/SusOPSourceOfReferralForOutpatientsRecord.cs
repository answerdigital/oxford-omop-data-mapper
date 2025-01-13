using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Observation.SourceOfReferralForOutpatients;

[DataOrigin("SUS")]
[Description("SUS OP Source Of Referral For Outpatients")]
[SourceQuery("SusOPSourceOfReferralForOutpatients.xml")]
internal class SusOPSourceOfReferralForOutpatientsRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? AppointmentDate { get; set; }
    public string? AppointmentTime { get; set; }
    public string? ReferrerCode { get; set; }
}