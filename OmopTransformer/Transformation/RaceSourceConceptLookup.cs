using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup race source concept.")]
internal class RaceSourceConceptLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "A", new ValueWithNote("700385", "White - British") },
            { "B", new ValueWithNote("700386", "White - Irish") },
            { "C", new ValueWithNote("700387", "White - Any other White background") },
            { "D", new ValueWithNote("700388", "Mixed - White and Black Caribbean") },
            { "E", new ValueWithNote("700389", "Mixed - White and Black African") },
            { "F", new ValueWithNote("700390", "Mixed - White and Asian") },
            { "G", new ValueWithNote("700391", "Mixed - Any other mixed background") },
            { "H", new ValueWithNote("700362", "Asian or Asian British - Indian") },
            { "J", new ValueWithNote("700363", "Asian or Asian British - Pakistani") },
            { "K", new ValueWithNote("700364", "Asian or Asian British - Bangladeshi") },
            { "L", new ValueWithNote("700365", "Asian or Asian British - Any other Asian background") },
            { "M", new ValueWithNote("700366", "Black or Black British - Caribbean") },
            { "N", new ValueWithNote("700367", "Black or Black British - African") },
            { "P", new ValueWithNote("700368", "Black or Black British - Any other Black background") },
            { "R", new ValueWithNote("700369", "Other Ethnic Groups - Chinese") },
            { "S", new ValueWithNote("", "Other Ethnic Groups - Any other ethnic group") },
            { "Z", new ValueWithNote("", "Not stated") },
            { "99", new ValueWithNote("", "Not known") },
        };

    public string[] ColumnNotes =>
    [
        "[NHS Race (i.e.Ethnicity)](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)",
        "[OMOP Race](https://athena.ohdsi.org/search-terms/terms?conceptClass=Race&invalidReason=Valid&vocabulary=Race&page=1&pageSize=50&query=)"
    ];
}