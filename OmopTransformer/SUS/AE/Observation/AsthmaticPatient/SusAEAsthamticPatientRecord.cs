using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.AE.Observation.AsthmaticPatient;

[DataOrigin("SUS")]
[Description("SUS AE Diabetic Patient")]
[SourceQuery("SusAEAsthmaticPatient.xml")]
internal class SusAEAsthmaticPatientRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? ArrivalDate { get; set; }
    public string? ArrivalTime { get; set; }
    public string? AccidentAndEmergencyDiagnosis { get; set; }
}