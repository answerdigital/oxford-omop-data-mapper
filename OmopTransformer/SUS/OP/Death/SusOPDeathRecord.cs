using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Death;

[DataOrigin("SUS")]
[Description("SUS Outpatient Death")]
[SourceQuery("SusOPDeath.xml")]
internal class SusOPDeathRecord
{
    public string? nhs_number { get; set; }
    public string? death_date { get; set; }
}
