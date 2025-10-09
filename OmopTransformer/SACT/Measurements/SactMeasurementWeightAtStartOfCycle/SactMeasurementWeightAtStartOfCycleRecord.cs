using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Measurements.SactMeasurementWeightAtStartOfCycle;

[DataOrigin("SACT")]
[Description("SACT Measurement Weight at Start of Cycle")]
[SourceQuery("SactMeasurementWeightAtStartOfCycle.xml")]
internal class SactMeasurementWeightAtStartOfCycleRecord
{
    public string? NHS_Number { get; set; }
    public string? Weight_At_Start_Of_Cycle { get; set; }
    public string? Start_Date_Of_Cycle { get; set; }
}