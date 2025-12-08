using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Observation.ICDDiagnosis;

[DataOrigin("SUS")]
[Description("Sus OP ICDDiagnosis table")]
[SourceQuery("SusOPICDDiagnosis.xml")]
internal class SusOPICDDiagnosisObservationRecord
{
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? DiagnosisICD { get; set; }
}