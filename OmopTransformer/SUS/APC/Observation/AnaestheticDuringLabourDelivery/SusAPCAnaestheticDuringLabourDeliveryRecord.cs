using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.AnaestheticDuringLabourDelivery;

[DataOrigin("SUS")]
[Description("SUS APC Anaesthetic During Labour Delivery Observation")]
[SourceQuery("SusAPCAnaestheticDuringLabourDelivery.xml")]
internal class SusAPCAnaestheticDuringLabourDeliveryRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? AnaestheticDuringLabourDelivery { get; set; }
}