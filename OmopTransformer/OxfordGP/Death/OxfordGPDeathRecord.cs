using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.Death;

[DataOrigin("Oxford-GP")]
[Description("Oxford GP Death")]
[SourceQuery("OxfordGPDeath.xml")]
internal class OxfordGPDeathRecord
{
    public string? NHSNumber { get; set; }
    public string? DateofDeath { get; set; }
}
