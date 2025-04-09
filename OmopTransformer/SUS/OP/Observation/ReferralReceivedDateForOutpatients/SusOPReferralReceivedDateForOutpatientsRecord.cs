using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Observation.ReferralReceivedDateForOutpatients;

[DataOrigin("SUS")]
[Description("SUS OP Referral Received Date For Outpatients")]
[SourceQuery("SusOPReferralReceivedDateForOutpatients.xml")]
internal class SusOPReferralReceivedDateForOutpatientsRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? AppointmentDate { get; set; }
    public string? AppointmentTime { get; set; }
    public string? ReferralRequestReceivedDate { get; set; }
}