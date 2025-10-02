using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Measurements.SactMeasurementWeightAtStartOfRegimen;

[DataOrigin("SACT")]
[Description("SACT Measurement Weight at Start of Regimen")]
[SourceQuery("SactMeasurementWeightAtStartOfRegimen.xml")]
internal class SactMeasurementWeightAtStartOfRegimenRecord
{
    public string? NHS_Number { get; set; }
    public string? Weight_At_Start_Of_Regimen { get; set; }
    public string? Start_Date_Of_Regimen { get; set; }
}