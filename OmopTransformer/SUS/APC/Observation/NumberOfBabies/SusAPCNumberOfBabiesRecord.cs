using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.NumberOfBabies;

[DataOrigin("SUS")]
[Description("SUS Inpatient NumberofBabies Observation")]
[SourceQuery("SusAPCNumberOfBabies.xml")]
internal class SusAPCNumberOfBabiesRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? NumberofBabies { get; set; }
}   