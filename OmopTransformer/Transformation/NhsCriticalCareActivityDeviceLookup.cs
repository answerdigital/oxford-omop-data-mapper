using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("CCMDS Critical Care Activity Code Device Concept IDs")]
internal class NhsCriticalCareActivityDeviceLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =      
        new()
        {
            { "1", new ValueWithNote("4107141", "Respiratory support via a tracheal tube (Respiratory support via a tracheal tube provided)") },
            { "2", new ValueWithNote("45761109", "Nasal Continuous Positive Airway Pressure (nCPAP) (PATIENT receiving nCPAP for any part of the day)") },
            { "5", new ValueWithNote("45757846", "Peritoneal Dialysis (PATIENT received Peritoneal Dialysis)") },
            { "7", new ValueWithNote("4209766", "Parenteral Nutrition (PATIENT receiving Parenteral Nutrition (amino acids +/- lipids))") },
            { "9", new ValueWithNote("45759341", "Oxygen Therapy") },
            { "11", new ValueWithNote("4121351", "Care of an intra-arterial catheter or chest drain (PATIENT receiving care of an intra-arterial catheter or chest drain)") },
            { "13", new ValueWithNote("4229159", "Tracheostomy cared for by nursing staff (PATIENT receiving care of tracheostomy cared for by nursing staff not by an external Carer (e.g. parent))") },
            { "14", new ValueWithNote("4229159", "Tracheostomy cared for by external Carer (PATIENT receiving care of tracheostomy cared for by an external Carer (e.g. parent) not by a NURSE)") },
            { "16", new ValueWithNote("45758443", "Haemofiltration (PATIENT received Haemofiltration)") },
            { "26", new ValueWithNote("36715434", "Phototherapy (PATIENT receiving phototherapy)") },
            { "51", new ValueWithNote("4097216", "Invasive ventilation via endotracheal tube") },
            { "52", new ValueWithNote("4044008", "Invasive ventilation via tracheostomy tube") },
            { "53", new ValueWithNote("45768197", "Non-invasive ventilatory support") },
            { "55", new ValueWithNote("4266238", "Nasopharyngeal airway") },
            { "56", new ValueWithNote("45768197", "Advanced ventilatory support (Jet or Oscillatory ventilation)") },
            { "59", new ValueWithNote("4219814", "Acute severe asthma requiring intravenous bronchodilator therapy or continuous nebuliser") },
            { "60", new ValueWithNote("4126195", "Arterial line monitoring") },
            { "61", new ValueWithNote("4030875", "Cardiac pacing via an external box (pacing wires or external pads or oesophageal pacing)") },
            { "62", new ValueWithNote("4179206", "Central venous pressure monitoring") },
            { "63", new ValueWithNote("4042177", "Bolus intravenous fluids (> 80 ml/kg/day) in addition to maintenance intravenous fluids") },
            { "73", new ValueWithNote("40491434", "Continuous pulse oximetry") },
            { "80", new ValueWithNote("4139525", "Heated Humidified High Flow Therapy (HHHFT)") },
            { "81", new ValueWithNote("4124293", "Presence of an umbilical venous line") },
        };


    public string[] ColumnNotes =>
    [
        "[CRITICAL CARE ACTIVITY CODES](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/attributes/critical_care_activity_code.html)",
        "[OMOP Devices](https://athena.ohdsi.org/search-terms/terms?domain=Device&invalidReason=Valid&standardConcept=Standard&page=1&pageSize=500&query=)"
    ];
}
