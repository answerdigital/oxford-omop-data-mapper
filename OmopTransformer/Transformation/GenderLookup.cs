namespace OmopTransformer.Transformation;

internal class GenderLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            {
                "Male", new ValueWithNote("8507", "")
            },
            {
                "1", new ValueWithNote("8507", "")
            },
            {
                "Female", new ValueWithNote("8532", "")
            },
            {
                "2", new ValueWithNote("8532", "")
            },
            {
                "9", new ValueWithNote("8551", "")
            },
            {
                "X", new ValueWithNote("8551", "")
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
        "[NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)",		
        "[OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)"
    ];
}