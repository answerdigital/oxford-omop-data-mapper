using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV9SourceOfReferralForOutpatients;

[DataOrigin("COSD")]
[Description("CosdV9SourceOfReferralForOutpatients")]
[SourceQuery("CosdV9SourceOfReferralForOutpatients.xml")]
internal class CosdV9SourceOfReferralForOutpatientsRecord
{
    public string? NhsNumber { get; set; }
    public string? Date { get; set; }
    public string? SourceOfReferralForOutpatients { get; set; }
}
