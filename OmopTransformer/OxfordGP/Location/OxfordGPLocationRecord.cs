using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.Location;

[DataOrigin("Oxford-GP")]
[Description("Oxford GP Location")]
[SourceQuery("OxfordGPLocation.xml")]
internal class OxfordGPLocationRecord
{
    public string? Postcode { get; set; }
    public string? NHSNumber { get; set; }

}