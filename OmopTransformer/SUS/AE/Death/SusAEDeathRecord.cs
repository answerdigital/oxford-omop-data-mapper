using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.Death;

[DataOrigin("SUS")]
[Description("SUS A&E Death")]
[SourceQuery("SusAEDeath.xml")]
internal class SusAEDeathRecord
{
    public string? nhs_number { get; set; }
    public string? death_date { get; set; }
}
