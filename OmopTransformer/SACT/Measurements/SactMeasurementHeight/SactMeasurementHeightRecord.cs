using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Measurements.SactMeasurementHeight;

[DataOrigin("SACT")]
[Description("SACT  Measurement Height")]
[SourceQuery("SactMeasurementHeight.xml")]
internal class SactMeasurementHeightRecord
{
    public string? NHS_Number { get; set; }
    public string? Height_At_Start_Of_Regimen { get; set; }
    public string? Start_Date_Of_Regimen { get; set; }
}