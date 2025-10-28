using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Observation;

[DataOrigin("SACT")]
[Description("SACT Treatment Intent")]
[SourceQuery("SactTreatmentIntent.xml")]
internal class SactTreatmentIntentRecord
{
    public string? NHSNumber { get; set; }
    public string? Intent_Of_Treatment { get; set; }
    public string? Source_value { get; set; }
    public string? Administration_Date { get; set; }
}