using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.ICDDiagnosis;

[DataOrigin("SUS")]
[Description("Sus APC Diagnosis Table")]
[SourceQuery("SusAPCICDDiagnosis.xml")]
internal class SusAPCSusDiagnosisRecord
{
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? DiagnosisICD { get; set; }
}