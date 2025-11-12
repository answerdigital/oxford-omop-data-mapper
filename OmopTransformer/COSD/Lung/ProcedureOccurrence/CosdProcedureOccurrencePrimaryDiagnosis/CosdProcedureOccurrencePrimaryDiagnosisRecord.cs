using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Lung.ProcedureOccurrence.CosdProcedureOccurrencePrimaryDiagnosis;

[DataOrigin("COSD")]
[Description("COSD Lung Procedure Occurrence Primary Diagnosis")]
[SourceQuery("CosdProcedureOccurrencePrimaryDiagnosis.xml")]
internal class CosdProcedureOccurrencePrimaryDiagnosisRecord
{
    public string? ProcedureDate { get; set; }
    public string? NhsNumber { get; set; }
    public string? PrimaryProcedureOpcs { get; set; }
}