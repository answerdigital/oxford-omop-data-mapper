using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.AnaestheticGivenPostLabourDelivery;

[DataOrigin("CDS")]
[Description("Cds Anaesthetic Given Post Labour Delivery Observation")]
[SourceQuery("CdsAnaestheticGivenPostLabourDelivery.xml")]
internal class CdsAnaestheticGivenPostLabourDeliveryRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? AnaestheticGivenPostLabourDelivery { get; set; }
}   