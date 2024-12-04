using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC;

[DataOrigin("SUS")]
[Description("SUS Inpatient Location")]
[SourceQuery("SusAPCLocation.xml")]
internal class SusAPCLocationRecord
{
    public string? Postcode { get; set; }
    public string? NHSNumber { get; set; }

}