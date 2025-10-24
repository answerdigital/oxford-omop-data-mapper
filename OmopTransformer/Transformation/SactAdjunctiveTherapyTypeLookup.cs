using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("The Adjunctive Therapy Type of the DRUG used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle.")]
internal class SactAdjunctiveTherapyTypeLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "1", new ValueWithNote("4191637", "Adjuvant - intent") },
            { "2", new ValueWithNote("4161587", "Neoadjuvant intent") },
            { "3", new ValueWithNote("", "Not Applicable (Primary Treatment)") },
            { "9" , new ValueWithNote("", "Not Known (Not Recorded)") },
        };

     public string[] ColumnNotes =>
    [
        "[SACT ADJUNCTIVE THERAPY TYPE](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/data_elements/adjunctive_therapy_type.html)",
        "[OMOP](https://athena.ohdsi.org/search-terms/terms/4194400)"
    ];
}