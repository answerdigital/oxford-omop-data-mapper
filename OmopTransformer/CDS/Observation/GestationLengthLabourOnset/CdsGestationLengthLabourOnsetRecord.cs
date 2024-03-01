using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.GestationLengthLabourOnset;

[DataOrigin("CDS")]
[Description("Cds Gestation Length Labour Onset Observation")]
[SourceQuery("CdsGestationLengthLabourOnset.xml")]
internal class CdsGestationLengthLabourOnsetRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? GestationLengthLabourOnset { get; set; }
}   