using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("The ADMINISTRATION ROUTE of the DRUG used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle.")]
internal class SactDrugAdministrationRouteLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "1", new ValueWithNote("40492287", "Intravascular") },
            { "2", new ValueWithNote("4186839", "Oromucosal") },
            { "3", new ValueWithNote("4302788", "Intraspinal") },
            { "4", new ValueWithNote("4302612", "Intramuscular") },
            { "5", new ValueWithNote("4142048", "Subcutaneous") },
            { "6", new ValueWithNote("40492287", "Intravascular") },
            { "7", new ValueWithNote("4304882", "Intraabdominal") },
            { "8", new ValueWithNote("4157757", "Intracavernous") },
            { "9", new ValueWithNote("40492302", "Intracorporus cavernosum of penis route") },
            { "11" , new ValueWithNote("4263689", "Topical") },
            { "12" , new ValueWithNote("4156706", "Intradermal") },
            { "13" , new ValueWithNote("40491322", "Intratumor") },
            { "14" , new ValueWithNote("4157758", "Intralesional") },
            { "98" , new ValueWithNote("0", "") },
        };

     public string[] ColumnNotes =>
    [
        "[SACT Drug Route of Administration](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/data_elements/systemic_anti-cancer_therapy_drug_route_of_administration.html)",
        "[OMOP](https://athena.ohdsi.org/search-terms/terms/4106215)"
    ];
}