using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Measurements.SusAPCMeasurement;

[DataOrigin("SUS")]
[Description("Sus APC  Measurement")]
[SourceQuery("SusAPCMeasurement.xml")]
internal class SusAPCMeasurementRecord
{
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? DiagnosisICD { get; set; }
}