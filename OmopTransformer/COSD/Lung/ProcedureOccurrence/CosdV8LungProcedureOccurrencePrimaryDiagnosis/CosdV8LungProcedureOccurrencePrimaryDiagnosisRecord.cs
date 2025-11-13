using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Lung.ProcedureOccurrence.CosdV8LungProcedureOccurrencePrimaryDiagnosis;

[DataOrigin("COSD")]
[Description("COSD V8 Lung Procedure Occurrence Primary Diagnosis")]
[SourceQuery("CosdV8LungProcedureOccurrencePrimaryDiagnosis.xml")]
internal class CosdV8LungProcedureOccurrencePrimaryDiagnosisRecord
{
    public string? ProcedureDate { get; set; }
    public string? NhsNumber { get; set; }
    public string? PrimaryProcedureOpcs { get; set; }
}