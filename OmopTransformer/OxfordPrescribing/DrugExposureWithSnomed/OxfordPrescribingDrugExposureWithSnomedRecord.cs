using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordPrescribing.DrugExposureWithSnomed;

[DataOrigin("Oxford Prescribing")]
[Description("Oxford Prescribing Drug Exposure (with Snomed)")]
[SourceQuery("OxfordPrescribingDrugExposureWithSnomed.xml")]
internal class OxfordPrescribingDrugExposureWithSnomedRecord
{
    public string? patient_identifier_Value { get; set; }
    public string? beg_dt_tm { get; set; }
    public string? end_dt_tm { get; set; }
    public string? order_detail_display_line { get; set; }
    public string? order_mnemonic { get; set; }
    public string? rxroute { get; set; }
    public string? strengthdoseunit { get; set; }
    public string? strengthdose { get; set; }
    public string? concept_identifier { get; set; }
    public string? EVENT_ID { get; set; }
}