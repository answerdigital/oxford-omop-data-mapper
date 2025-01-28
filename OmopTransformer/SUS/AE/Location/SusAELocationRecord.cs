using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.Location;

[DataOrigin("SUS")]
[Description("SUS A&E Location")]
[SourceQuery("SusAELocation.xml")]
internal class SusAELocationRecord
{
    public string? Postcode { get; set; }
    public string? NHSNumber { get; set; }

}