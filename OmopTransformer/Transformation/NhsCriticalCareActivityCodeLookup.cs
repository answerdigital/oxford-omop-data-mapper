using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("CCMDS Critical Care Activity Code Concept IDs")]
internal class NhsCriticalCareActivityCodeLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =      
        new()
        {
            { "1", new ValueWithNote("4161831", "Respiratory support via a tracheal tube (Respiratory support via a tracheal tube provided)") },
            { "2", new ValueWithNote("4165535", "Nasal Continuous Positive Airway Pressure (nCPAP) (PATIENT receiving nCPAP for any part of the day)") },
            { "3", new ValueWithNote("35918980", "Surgery (PATIENT received surgery)") },
            { "4", new ValueWithNote("4193981", "Exchange Transfusion (PATIENT received exchange transfusion)") },
            { "5", new ValueWithNote("4324124", "Peritoneal Dialysis (PATIENT received Peritoneal Dialysis)") },
            { "6", new ValueWithNote("44806352", "Continuous infusion of inotrope, pulmonary vasodilator or prostaglandin (PATIENT received a continuous infusion of an inotrope, vasodilator (includes pulmonary vasodilators) or prostaglandin") },
            { "7", new ValueWithNote("4021169", "Parenteral Nutrition (PATIENT receiving Parenteral Nutrition (amino acids +/- lipids))") },
            { "8", new ValueWithNote("4273223", "Convulsions (PATIENT having convulsions requiring treatment)") },
            { "9", new ValueWithNote("4239130", "Oxygen Therapy") },
            { "10", new ValueWithNote("46271806", "Neonatal abstinence syndrome (PATIENT receiving drug treatment for neonatal abstinence (withdrawal) syndrome)") },
            { "11", new ValueWithNote("37395956", "Care of an intra-arterial catheter or chest drain (PATIENT receiving care of an intra-arterial catheter or chest drain)") },
            { "12", new ValueWithNote("4050429", "Dilution Exchange Transfusion (PATIENT received Dilution Exchange Transfusion)") },
            { "13", new ValueWithNote("4262010", "Tracheostomy cared for by nursing staff (PATIENT receiving care of tracheostomy cared for by nursing staff not by an external Carer (e.g. parent))") },
            { "14", new ValueWithNote("4262010", "Tracheostomy cared for by external Carer (PATIENT receiving care of tracheostomy cared for by an external Carer (e.g. parent) not by a NURSE)") },
            { "15", new ValueWithNote("4122478", "Recurrent apnoea (PATIENT has recurrent apnoea needing frequent intervention, i.e. over 5 stimulations in 8 hours, or resuscitation with IPPV two or more times in 24 hours)") },
            { "16", new ValueWithNote("4050864", "Haemofiltration (PATIENT received Haemofiltration)") },
            { "21", new ValueWithNote("4237490", "Resident - Caring for Baby") },
            { "22", new ValueWithNote("4141651", "Continuous monitoring") },
            { "23", new ValueWithNote("4165358", "Intravenous glucose and electrolyte solutions (PATIENT being given intravenous glucose and electrolyte solutions)") },
            { "24", new ValueWithNote("4263536", "Tube-fed (PATIENT being tube-fed)") },
            { "25", new ValueWithNote("618552", "Barrier nursed (PATIENT being barrier nursed)") },
            { "26", new ValueWithNote("4151902", "Phototherapy (PATIENT receiving phototherapy)") },
            { "27", new ValueWithNote("4061929", "Special monitoring") },
            { "28", new ValueWithNote("4033847", "Observations at regular intervals") },
            { "29", new ValueWithNote("4303434", "Intravenous medication") },
            { "50", new ValueWithNote("4141651", "Continuous electrocardiogram monitoring") },
            { "51", new ValueWithNote("37157166", "Invasive ventilation via endotracheal tube") },
            { "52", new ValueWithNote("4337047", "Invasive ventilation via tracheostomy tube") },
            { "53", new ValueWithNote("44791135", "Non-invasive ventilatory support") },
            { "55", new ValueWithNote("182692007", "Nasopharyngeal airway") },
            { "56", new ValueWithNote("4074666", "Advanced ventilatory support (Jet or Oscillatory ventilation)") },
            { "57", new ValueWithNote("4061066", "Upper airway obstruction requiring nebulised Epinephrine/ Adrenaline") },
            { "58", new ValueWithNote("4122478", "Apnoea requiring intervention") },
            { "59", new ValueWithNote("46272934", "Acute severe asthma requiring intravenous bronchodilator therapy or continuous nebuliser") },
            { "60", new ValueWithNote("4213288", "Arterial line monitoring") },
            { "61", new ValueWithNote("4049990", "Cardiac pacing via an external box (pacing wires or external pads or oesophageal pacing)") },
            { "62", new ValueWithNote("4313586", "Central venous pressure monitoring") },
            { "63", new ValueWithNote("4161519", "Bolus intravenous fluids (> 80 ml/kg/day) in addition to maintenance intravenous fluids") },
            { "64", new ValueWithNote("4232320", "Cardio-pulmonary resuscitation (CPR)") },
            { "65", new ValueWithNote("4336747", "Extracorporeal membrane oxygenation (ECMO) or Ventricular Assist Device (VAD) or aortic balloon pump") },
            { "66", new ValueWithNote("4120120", "Haemodialysis") },
            { "67", new ValueWithNote("4052539", "Plasma filtration or Plasma exchange") },
            { "68", new ValueWithNote("2000097", "ICP-intracranial pressure monitoring") },
            { "69", new ValueWithNote("40756782", "Intraventricular catheter or external ventricular drain") },
            { "70", new ValueWithNote("4080110", "Diabetic ketoacidosis (DKA) requiring continuous infusion of insulin") },
            { "71", new ValueWithNote("4144062", "Intravenous infusion of thrombolytic agent (limited to tissue plasminogen activator [tPA] and streptokinase)") },
            { "72", new ValueWithNote("44805305", "Extracorporeal liver support using Molecular Absorbent Liver Recirculating System (MARS)") },
            { "73", new ValueWithNote("4098046", "Continuous pulse oximetry") },
            { "74", new ValueWithNote("4222885", "Patient nursed in single occupancy cubicle") },
            { "80", new ValueWithNote("37158406", "Heated Humidified High Flow Therapy (HHHFT)") },
            { "81", new ValueWithNote("4051310", "Presence of an umbilical venous line") },
            { "82", new ValueWithNote("4080110", "Continuous infusion of insulin (PATIENT  receiving a continuous infusion of insulin)") },
            { "83", new ValueWithNote("4203429", "Therapeutic hypothermia") },
            { "87", new ValueWithNote("4022139", "Administration of intravenous (IV) blood products") },
            { "96", new ValueWithNote("4086422", "intravenous infusion of sedative agent") },
        };


    public string[] ColumnNotes =>
    [
        "[CRITICAL CARE ACTIVITY CODES](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/attributes/critical_care_activity_code.html)",
        "[OMOP Procedures](https://athena.ohdsi.org/search-terms/terms?domain=Procedure&invalidReason=Valid&standardConcept=Standard&vocabulary=SNOMED&page=1&pageSize=15&query=)"
    ];
}
