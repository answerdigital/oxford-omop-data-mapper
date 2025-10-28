using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Observation;

[DataOrigin("SACT")]
[Description("SACT Clinical Trial")]
[SourceQuery("SactClinicalTrial.xml")]
internal class SactClinicalTrialRecord
{
    public string? NHSNumber { get; set; }
    public string? Clinical_Trial { get; set; }
    public string? Source_value { get; set; }
    public string? Administration_Date { get; set; }
}