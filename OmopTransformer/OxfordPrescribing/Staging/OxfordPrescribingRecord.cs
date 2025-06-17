namespace OmopTransformer.OxfordPrescribing.Staging;

internal class OxfordPrescribingRecord
{
    public string? patient_identifier_value { get; init; }
    public string? WAREHOUSE_IDENTIFIER { get; init; }
    public string? ORDER_ID { get; init; }
    public string? BEG_DT_TM { get; init; }
    public string? END_DT_TM { get; init; }
    public string? SCHEDULED_DT_TM { get; init; }
    public string? VERIFICATION_DT_TM { get; init; }
    public string? UPDT_DT_TM { get; init; }
    public string? CURRENT_START_DT_TM { get; init; }
    public string? PROJECTED_STOP_DT_TM { get; init; }
    public string? MED_ADMIN_EVENT_ID { get; init; }
    public string? EVENT_TYPE_DISPLAY { get; init; }
    public string? REFERENCESTARTDTTM { get; init; }
    public string? STRENGTHDOSE { get; init; }
    public string? DIFFINMIN { get; init; }
    public string? CONSTANTIND { get; init; }
    public string? RXPRIORITY { get; init; }
    public string? PHARMORDERTYPE { get; init; }
    public string? ADHOCFREQINSTANCE { get; init; }
    public string? FREQSCHEDID { get; init; }
    public string? WEIGHT { get; init; }
    public string? DRUGFORM { get; init; }
    public string? REQSTARTDTTM { get; init; }
    public string? STRENGTHDOSEUNIT { get; init; }
    public string? RXROUTE { get; init; }
    public string? CATALOG_CD { get; init; }
    public string? CATALOG { get; init; }
    public string? ORDER_MNEMONIC { get; init; }
    public string? ORDER_DETAIL_DISPLAY_LINE { get; init; }
    public string? DEPT_MISC_LINE { get; init; }
    public string? concept_identifier { get; init; }
    public string? concept_name { get; init; }
    public string? CONCEPT_CKI { get; init; }
    public string? cki { get; init; }
}