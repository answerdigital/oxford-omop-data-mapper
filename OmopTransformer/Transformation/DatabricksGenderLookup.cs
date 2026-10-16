using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup Databricks gender concept.")]
internal class DatabricksGenderLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "Male", new ValueWithNote("8507", "Male") },
            { "Female", new ValueWithNote("8532", "Female") },
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)"
    ];
}
