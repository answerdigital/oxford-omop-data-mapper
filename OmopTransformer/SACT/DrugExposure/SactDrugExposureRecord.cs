using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.DrugExposure;

[DataOrigin("SACT")]
[Description("SACT Drug Exposure")]
[SourceQuery("SactDrugExposure.xml")]
internal class SactDrugExposureRecord
{
    public string? NHS_Number { get; set; }
    public string? Drug_Name { get; set; }
    public string? Administration_Date { get; set; }
    public string? Actual_Dose_Per_Administration { get; set; }
    public string? Administration_Measurement_Per_Actual_Dose { get; set; }
    public string? Regimen { get; set; }
}