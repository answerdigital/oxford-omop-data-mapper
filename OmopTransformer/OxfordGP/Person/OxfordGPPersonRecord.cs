using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.Person;

[DataOrigin("Oxford-GP")]
[Description("Oxford GP Person")]
[SourceQuery("OxfordGPPerson.xml")]
internal class OxfordGPPersonRecord
{
    public string? NHSNumber { get; set; }
    public string? DOB { get; set; }
    public string? Postcode { get; set; }
}