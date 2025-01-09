using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup gender concept.")]
internal class NhsGenderLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            {
                "1", new ValueWithNote("8507", "Male")
            },
            {
                "2", new ValueWithNote("8532", "Female")
            },
            {
                "9", new ValueWithNote("0", "Indeterminate (unable to be classified as either male or female)")
            },
            {
                "X", new ValueWithNote("0", "Not known")
            },
        };

    public string[] ColumnNotes =>
    [
        "[NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)",		
        "[OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)"
    ];
}