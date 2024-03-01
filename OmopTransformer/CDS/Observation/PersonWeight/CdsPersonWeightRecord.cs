using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.PersonWeight;

[DataOrigin("CDS")]
[Description("Cds Person Weight Observation")]
[SourceQuery("CdsPersonWeight.xml")]
internal class CdsPersonWeightRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? PersonWeight { get; set; }
}   