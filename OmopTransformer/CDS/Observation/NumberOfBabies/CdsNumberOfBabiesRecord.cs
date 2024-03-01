using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.NumberOfBabies;

[DataOrigin("CDS")]
[Description("Cds NumberofBabies Observation")]
[SourceQuery("CdsNumberOfBabies.xml")]
internal class CdsNumberOfBabiesRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? NumberofBabies { get; set; }
}   