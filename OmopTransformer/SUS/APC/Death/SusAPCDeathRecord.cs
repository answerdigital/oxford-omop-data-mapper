using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Death;

[DataOrigin("SUS")]
[Description("SUS Inpatient Death")]
[SourceQuery("SusAPCDeath.xml")]
internal class SusAPCDeathRecord
{
    public string? nhs_number { get; set; }
    public string? death_date { get; set; }
    public string? death_time { get; set; }
    public string? DiagnosisICD { get; set; }
}
