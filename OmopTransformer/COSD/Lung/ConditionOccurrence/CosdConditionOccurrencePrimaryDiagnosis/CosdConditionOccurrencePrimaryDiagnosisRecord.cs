using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Lung.ConditionOccurrence.CosdConditionOccurrencePrimaryDiagnosis;

[DataOrigin("COSD")]
[Description("COSD Lung Condition Occurrence Primary Diagnosis")]
[SourceQuery("CosdConditionOccurrencePrimaryDiagnosis.xml")]
internal class CosdConditionOccurrencePrimaryDiagnosisRecord
{
    public string? NhsNumber { get; set; }
    public string? DiagnosisDate { get; set; }
    public string? CancerHistology { get; set; }
    public string? CancerTopography { get; set; }
    public string? CancerDiagnosis { get; set; }
}