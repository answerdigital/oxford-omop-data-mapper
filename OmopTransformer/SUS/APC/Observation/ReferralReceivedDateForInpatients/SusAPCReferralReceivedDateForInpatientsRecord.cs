using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.ReferralReceivedDateForInpatients;

[DataOrigin("SUS")]
[Description("SUS APC Referral Received Date For Outpatients")]
[SourceQuery("SusAPCReferralReceivedDateForInpatients.xml")]
internal class SusAPCReferralReceivedDateForInpatientsRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? StartDateHospitalProviderSpell { get; set; }
    public string? StartTimeHospitalProviderSpell { get; set; }
    public string? ReferralToTreatmentPeriodStartDate { get; set; }
}