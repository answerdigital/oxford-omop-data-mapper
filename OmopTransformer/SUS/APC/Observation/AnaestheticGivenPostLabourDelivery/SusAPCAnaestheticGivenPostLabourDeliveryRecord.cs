using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.AnaestheticGivenPostLabourDelivery;

[DataOrigin("SUS")]
[Description("SUS APC Anaesthetic Given Post Labour Delivery Observation")]
[SourceQuery("SusAPCAnaestheticGivenPostLabourDelivery.xml")]
internal class SusAPCAnaestheticGivenPostLabourDeliveryRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? AnaestheticGivenPostLabourDelivery { get; set; }
}   