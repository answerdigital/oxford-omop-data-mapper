using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup gender concept.")]
internal class NhsGenderLookup : ILookup
{
    public Dictionary<KeyWithName, ValueWithNote> Mappings { get; } =
        new()
        {
            {
                new KeyWithName("1", "test value goes here"), new ValueWithNote("8507", "Male")
            },
            {
                new KeyWithName("2", ""), new ValueWithNote("8532", "Female")
            },
            {
                new KeyWithName("9", ""), new ValueWithNote("8551", "Indeterminate (unable to be classified as either male or female)")
            },
            {
                new KeyWithName("X", ""), new ValueWithNote("8551", "Not known")
            },
        };

    public string[] ColumnNotes =>
    [
        "[NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)",		
        "[OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)"
    ];
}