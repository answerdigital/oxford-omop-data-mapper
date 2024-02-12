using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup gender concept.")]
internal class RtdsGenderLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            {
                "Male", new ValueWithNote("8507", "")
            },
            {
                "Female", new ValueWithNote("8532", "")
            },
            {
                "Unknown", new ValueWithNote("8551", "")
            },
            {
                "Not Stated", new ValueWithNote("8551", "")
            }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)"
    ];
}