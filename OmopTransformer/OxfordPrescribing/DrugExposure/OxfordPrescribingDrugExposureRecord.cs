using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordPrescribing.DrugExposure;

[DataOrigin("Oxford Prescribing")]
[Description("Oxford Prescribing Drug Exposure")]
[SourceQuery("OxfordPrescribingDrugExposure.xml")]
internal class OxfordPrescribingDrugExposureRecord
{
    public string? NHS_Number { get; set; }
    public string? Order_Mnemonic { get; set; }
    public string? Begin_Date { get; set; }
    public string? End_Date { get; set; }
    public string? Order_Detail_Display_Line { get; set; }
    public string? Rxroute { get; set; }
    public string? Quantity { get; set; }
    public string? Strengthdoseunit { get; set; }
}