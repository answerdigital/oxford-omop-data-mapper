using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup gender concept.")]
internal class RtdsGenderLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            {
                "Male", new ValueWithNote("8507", "Male")
            },
            {
                "Female", new ValueWithNote("8532", "Female")
            },
            {
                "Unknown", new ValueWithNote("0", "Indeterminate (unable to be classified as either male or female)")
            },
            {
                "Not Stated", new ValueWithNote("0", "Unknown")
            }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)"
    ];
}