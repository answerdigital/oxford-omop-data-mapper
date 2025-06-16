using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordPrescribing.DrugExposure;

[DataOrigin("Oxford Prescribing")]
[Description("Oxford Prescribing Drug Exposure")]
[SourceQuery("OxfordPrescribingDrugExposure.xml")]
internal class OxfordPrescribingDrugExposureRecord
{
    public string? patient_identifier_Value { get; set; }
    public string? beg_dt_tm { get; set; }
    public string? end_dt_tm { get; set; }
    public string? order_mnemonic { get; set; }
    public string? order_detail_display_line { get; set; }
    public string? rxroute { get; set; }
    public string? strengthdoseunit { get; set; }
    public string? strengthdose { get; set; }
}