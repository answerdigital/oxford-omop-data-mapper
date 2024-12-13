using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.CareSite;

[DataOrigin("SUS")]
[Description("SUS Inpatient Care Site")]
[SourceQuery("SusAPCCareSite.xml")]
internal class SusAPCCareSiteRecord
{
    public string? SiteCodeOfTreatmentAtEpisodeStartDate { get; set; }
    public string? MainSpecialtyCode { get; set; }
}