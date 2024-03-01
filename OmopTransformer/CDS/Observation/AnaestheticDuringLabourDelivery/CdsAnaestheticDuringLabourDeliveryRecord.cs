using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.AnaestheticDuringLabourDelivery;

[DataOrigin("CDS")]
[Description("Cds Anaesthetic During Labour Delivery Observation")]
[SourceQuery("CdsAnaestheticDuringLabourDelivery.xml")]
internal class CdsAnaestheticDuringLabourDeliveryRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? AnaestheticDuringLabourDelivery { get; set; }
}   