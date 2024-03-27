using OmopTransformer.Annotations;

namespace OmopTransformer.COSD.Measurements.CosdV9MeasurementTumourLaterality;

[DataOrigin("COSD")]
[Description("COSD V9 Measurement Tumour Laterality")]
[SourceQuery("CosdV9MeasurementTumourLaterality.xml")]
internal class CosdV9MeasurementTumourLateralityRecord
{
    public string? NhsNumber { get; set; }
    public string? DateOfPrimaryDiagnosisClinicallyAgreed { get; set; }
    public string? TumourLaterality { get; set; }
}