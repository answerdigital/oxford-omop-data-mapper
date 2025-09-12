using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordLab.Measurements.OxfordLabMeasurement;

[DataOrigin("OxfordLab")]
[Description("Oxford Lab Measurement")]
[SourceQuery("OxfordLabMeasurement.xml")]
internal class OxfordLabMeasurementRecord
{
    public string? nhs_number { get; set; }
    public string? @event { get; set; }
    public string? event_start_dt_tm { get; set; }
    public string? result_value { get; set; }
    public string? result_units { get; set; }
    public string? normal_low { get; set; }
    public string? normal_high { get; set; }
}