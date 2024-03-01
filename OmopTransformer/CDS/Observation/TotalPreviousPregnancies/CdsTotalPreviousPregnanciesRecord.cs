using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.Observation.TotalPreviousPregnancies;

[DataOrigin("CDS")]
[Description("Cds Total Previous Pregnancies Observation")]
[SourceQuery("CdsTotalPreviousPregnancies.xml")]
internal class CdsTotalPreviousPregnanciesRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? TotalPreviousPregnancies { get; set; }
}   