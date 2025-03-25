using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.CCMDS.Measurements.GestationLengthAtDelivery;

[DataOrigin("SUS")]
[Description("Sus CCMDS Measurement - Gestation Length at Delivery")]
[SourceQuery("SusCCMDSMeasurementGestationLength.xml")]
internal class SusCCMDSMeasurementGestationLengthRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? MeasurementDate { get; set; }
    public string? MeasurementDateTime { get; set; }
    public string? ValueAsNumber { get; set; }
}