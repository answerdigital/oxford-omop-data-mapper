using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup gender concept.")]
internal class RtdsGenderLookup : ILookup
{
    public Dictionary<KeyWithName, ValueWithNote> Mappings { get; } =
        new()
        {
            {
                new KeyWithName("Male", ""), new ValueWithNote("8507", "")
            },
            {
                new KeyWithName("Female", ""), new ValueWithNote("8532", "")
            },
            {
                new KeyWithName("Unknown", ""), new ValueWithNote("8551", "")
            },
            {
                new KeyWithName("Not Stated", ""), new ValueWithNote("8551", "")
            }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)"
    ];
}