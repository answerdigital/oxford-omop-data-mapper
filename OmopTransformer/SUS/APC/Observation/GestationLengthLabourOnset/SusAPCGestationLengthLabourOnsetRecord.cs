using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.GestationLengthLabourOnset;

[DataOrigin("SUS")]
[Description("SUS Inpatient Gestation Length Labour Onset Observation")]
[SourceQuery("SusAPCGestationLengthLabourOnset.xml")]
internal class SusAPCGestationLengthLabourOnsetRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? GestationLengthLabourOnset { get; set; }
}   