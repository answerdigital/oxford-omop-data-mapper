using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.CCMDS.Measurements.PersonWeight;

[DataOrigin("SUS")]
[Description("Sus CCMDS Measurement - Person Weight")]
[SourceQuery("SusCCMDSMeasurementPersonWeight.xml")]
internal class SusCCMDSMeasurementPersonWeightRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public string? MeasurementDate { get; set; }
    public string? MeasurementDateTime { get; set; }
    public string? ValueAsNumber { get; set; }
}