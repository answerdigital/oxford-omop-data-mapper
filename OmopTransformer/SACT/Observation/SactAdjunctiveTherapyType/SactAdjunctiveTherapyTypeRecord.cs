using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Observation;

[DataOrigin("SACT")]
[Description("SACT Adjunctive Therapy Type")]
[SourceQuery("SactAdjunctiveTherapyType.xml")]
internal class SactAdjunctiveTherapyTypeRecord
{
    public string? NHSNumber { get; set; }
    public string? Adjunctive_Therapy { get; set; }
    public string? Source_value { get; set; }
    public string? Administration_Date { get; set; }
}