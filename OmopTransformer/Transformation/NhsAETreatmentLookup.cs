using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Accident and Emergency Treatment to SNOMED")]
internal class NhsAETreatmentLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "01", new ValueWithNote("4305581", "Dressing") },
            { "02", new ValueWithNote("4080807", "Bandage") },
            { "03", new ValueWithNote("4088727", "Sutures") },
            { "04", new ValueWithNote("42538257", "Wound closure") },
            { "041", new ValueWithNote("4074344", "Wound closure - steristrips") },
            { "042", new ValueWithNote("4141971", "Wound closure - wound glue") },
            { "043", new ValueWithNote("42538257", "Wound closure - other") },
            { "05", new ValueWithNote("4232206", "Plaster of Paris") },
            { "06", new ValueWithNote("4038879", "Splint") },
            { "07", new ValueWithNote("4052492", "Prescription") },
            { "08", new ValueWithNote("4032408", "Removal foreign body") },
            { "09", new ValueWithNote("4145658", "Physiotherapy") },
            { "09", new ValueWithNote("4080504", "Physiotherapy - manipulation") },
            { "09", new ValueWithNote("4145658", "Physiotherapy - other ") },
            { "10", new ValueWithNote("4045714", "Reduction") },
            { "11", new ValueWithNote("4211374", "Incision & Drainage") },
            { "12", new ValueWithNote("4311035", "Intravenous cannula") },
            { "13", new ValueWithNote("4041656", "Central line") },
            { "14", new ValueWithNote("4046291", "Lavage/Emesis") },
            { "15", new ValueWithNote("4202832", "Intubation") },
            { "16", new ValueWithNote("44782942", "Chest drain") },
            { "17", new ValueWithNote("4074328", "Urinary catheter") },
            { "18", new ValueWithNote("4180456", "Defibrillation/pacing") },
            { "19", new ValueWithNote("4205502", "Resuscitation") },
            { "20", new ValueWithNote("46273093", "Minor surgery") },
            { "21", new ValueWithNote("4304206", "Observation") },
            // { "22", new ValueWithNote("", "Guidance") },
            // { "221", new ValueWithNote("", "Guidance - written") },
            // { "222", new ValueWithNote("", "Guidance - verbal") },
            { "23", new ValueWithNote("4160439", "Anaesthesia") },
            { "231", new ValueWithNote("4174669", "General anaesthetic") },
            { "232", new ValueWithNote("4303995", "Local anaesthetic") },
            { "233", new ValueWithNote("4117443", "Regional block") },
            { "234", new ValueWithNote("4140470", "Entonox") },
            { "235", new ValueWithNote("4219502", "Sedation") },
            { "236", new ValueWithNote("4160439", "Anaesthesia - other") },
            { "24", new ValueWithNote("4293740", "Tetanus") },
            { "241", new ValueWithNote("4293740", "Tetanus - immune") },
            { "242", new ValueWithNote("4293740", "Tetanus toxoid course") },
            { "243", new ValueWithNote("4293740", "Tetanus toxoid booster") },
            { "244", new ValueWithNote("4037789", "Human immunoglobulin") },
            // { "245", new ValueWithNote("", "Combined tetanus/diphtheria course") },
            // { "246", new ValueWithNote("", "Combined tetanus/diphtheria booster") },
            { "25", new ValueWithNote("44790388", "Nebuliser") },
            // { "27", new ValueWithNote("", "Other") },
            { "28", new ValueWithNote("4085113", "Parenteral thrombolysis") },
            // { "29", new ValueWithNote("", "Other Parenteral drugs") },
            // { "99", new ValueWithNote("", "None") },
        };


    public string[] ColumnNotes =>
    [
        "[ACCIDENT and EMERGENCY CLINICAL CODES](https://v2.datadictionary.nhs.uk/web_site_content/pages/codes/administrative_codes/a_amp_e_treatment_tables.asp@shownav=1.html)",
        "[OMOP Procedures](https://athena.ohdsi.org/search-terms/terms?domain=Procedure&standardConcept=Standard&vocabulary=SNOMED&invalidReason=Valid&page=1&pageSize=15&query=)"
    ];
}
