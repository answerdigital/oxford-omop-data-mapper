using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Location;

[DataOrigin("SUS")]
[Description("SUS Outpatient Location")]
[SourceQuery("SusOPLocation.xml")]
internal class SusOPLocationRecord
{
    public string? Postcode { get; set; }
    public string? NHSNumber { get; set; }

}