using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Location;

[DataOrigin("SACT")]
[Description("SACT Location")]
[SourceQuery("SactLocation.xml")]
internal class SactLocationRecord
{
    public string? NHS_Number { get; set; }
    public string? Patient_Postcode { get; set; }
}