using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.SourceOfReferralForOutpatients;

[DataOrigin("CDS")]
[Description("Cds Source Of Referral For Outpatients Observation")]
[SourceQuery("CdsSourceOfReferralForOutpatients.xml")]
internal class CdsSourceOfReferralForOutpatientsRecord
{
    public string? NHSNumber { get; set; }
    public string? observation_date { get; set; }
    public string? SourceOfReferralForOutpatients { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
}   