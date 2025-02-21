using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.CareSite;

[DataOrigin("SUS")]
[Description("SUS Inpatient Care Site")]
[SourceQuery("SusAECareSite.xml")]
internal class SusAECareSiteRecord
{
    public string? SiteCodeOfTreatment { get; set; }
}