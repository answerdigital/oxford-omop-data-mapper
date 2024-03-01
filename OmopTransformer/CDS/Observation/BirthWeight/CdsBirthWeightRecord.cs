using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.BirthWeight;

[DataOrigin("CDS")]
[Description("Cds Birth Weight Observation")]
[SourceQuery("CdsBirthWeight.xml")]
internal class CdsBirthWeightRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? BirthWeight { get; set; }
}   