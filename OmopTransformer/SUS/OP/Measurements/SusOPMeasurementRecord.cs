using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Measurements.SusOPMeasurement;

[DataOrigin("SUS")]
[Description("Sus OP  Measurement")]
[SourceQuery("SusOPMeasurement.xml")]
internal class SusOPMeasurementRecord
{
    public string? NHSNumber { get; set; }
    public string? CDSActivityDate { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? DiagnosisICD { get; set; }
}