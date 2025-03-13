using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.CCMDS.Observation.HighCostDrugs;

[DataOrigin("SUS")]
[Description("Sus CCMDS High Cost Drugs")]
[SourceQuery("SusCCMDSHighCostDrugs.xml")]
internal class SusCCMDSHighCostDrugsRecord
{
    public string? NHSNumber { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? ObservationDate { get; set; }
    public string? ObservationDateTime { get; set; }
    public string? ObservationSourceValue { get; set; }
}