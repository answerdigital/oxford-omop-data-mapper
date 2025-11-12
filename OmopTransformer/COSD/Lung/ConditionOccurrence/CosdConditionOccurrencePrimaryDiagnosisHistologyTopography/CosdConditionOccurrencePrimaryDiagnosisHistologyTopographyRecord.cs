using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Lung.ConditionOccurrence.CosdConditionOccurrencePrimaryDiagnosisHistologyTopography;

[DataOrigin("COSD")]
[Description("COSD Lung Condition Occurrence Primary Diagnosis Histology Topography")]
[SourceQuery("CosdConditionOccurrencePrimaryDiagnosisHistologyTopography.xml")]
internal class CosdConditionOccurrencePrimaryDiagnosisHistologyTopographyRecord
{
    public string? NhsNumber { get; set; }
    public string? DiagnosisDate { get; set; }
    public string? CancerHistology { get; set; }
    public string? CancerTopography { get; set; }
    public string? CancerDiagnosis { get; set; }
}