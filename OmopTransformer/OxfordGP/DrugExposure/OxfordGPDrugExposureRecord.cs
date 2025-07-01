using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.DrugExposure;

[DataOrigin("Oxford GP")]
[Description("Oxford GP Drug Exposure")]
[SourceQuery("OxfordGPDrugExposure.xml")]
internal class OxfordGPDrugExposureRecord
{
    public string? NHSNumber { get; set; }
    public string? SuppliedCode { get; set; }
    public string? LastIssueDate { get; set; }
    public string? Quantity { get; set; }
    public string? Units { get; set; }
}