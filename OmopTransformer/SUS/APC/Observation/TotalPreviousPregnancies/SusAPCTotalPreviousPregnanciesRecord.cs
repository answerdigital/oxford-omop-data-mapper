using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.TotalPreviousPregnancies;

[DataOrigin("SUS")]
[Description("SUS Inpatient Total Previous Pregnancies Observation")]
[SourceQuery("SusAPCTotalPreviousPregnancies.xml")]
internal class SusAPCTotalPreviousPregnanciesRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? HospitalProviderSpellNumber { get; set; }
    public string? observation_date { get; set; }
    public string? TotalPreviousPregnancies { get; set; }
}   