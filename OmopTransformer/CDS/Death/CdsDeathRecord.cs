using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Death;

[DataOrigin("CDS")]
[Description("CDS Death")]
[SourceQuery("CdsDeath.xml")]
internal class CdsDeathRecord
{
    public string nhs_number { get; set; }
    public string death_date { get; set; }
}