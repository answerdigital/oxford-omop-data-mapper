using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("The Regimen Treatment Intent of the DRUG used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle.")]
internal class SactTreatmentIntentLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "1", new ValueWithNote("4162591", "Curative") },
            { "2", new ValueWithNote("4179711", "Palliative") },
            { "3", new ValueWithNote("4179711", "Palliative") },
            { "4", new ValueWithNote("4179711", "Palliative") },
            { "5", new ValueWithNote("4179711", "Palliative") },
            { "98" , new ValueWithNote("", "Other (not listed)") },
        };

     public string[] ColumnNotes =>
    [
        "[SACT Drug Regimen Treatment Intent](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/attributes/systemic_anti-cancer_therapy_drug_regimen_treatment_intent.html)",
        "[OMOP](https://athena.ohdsi.org/search-terms/terms/4194400)"
    ];
}