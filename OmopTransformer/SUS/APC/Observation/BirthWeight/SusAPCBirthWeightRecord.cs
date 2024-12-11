using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.BirthWeight;

[DataOrigin("SUS")]
[Description("Sus APC Birth Weight Observation")]
[SourceQuery("SusAPCBirthWeight.xml")]
internal class SusAPCBirthWeightRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? BirthWeight { get; set; }
}