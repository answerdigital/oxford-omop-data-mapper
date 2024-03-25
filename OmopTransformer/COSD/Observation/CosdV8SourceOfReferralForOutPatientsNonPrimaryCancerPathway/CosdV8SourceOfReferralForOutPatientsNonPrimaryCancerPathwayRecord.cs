using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Observation.CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway;

[DataOrigin("COSD")]
[Description("CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway")]
[SourceQuery("CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway.xml")]
internal class CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathwayRecord
{
    public string? NhsNumber { get; set; }
    public string? Date { get; set; }
    public string? SourceOfReferralForOutPatientsNonPrimaryCancerPathway { get; set; }
}
