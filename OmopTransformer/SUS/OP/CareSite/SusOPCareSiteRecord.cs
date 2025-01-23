using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.CareSite;

[DataOrigin("SUS")]
[Description("SUS Outpatient Care Site")]
[SourceQuery("SusOPCareSite.xml")]
internal class SusOPCareSiteRecord
{
    public string? SiteCodeofTreatment { get; set; }
    public string? MainSpecialtyCode { get; set; }
}