namespace OmopTransformer.Transformation;

internal class RaceConceptLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "A", new ValueWithNote("8527",    "White - British") },
            { "B", new ValueWithNote("8527",    "White - Irish") },
            { "C", new ValueWithNote("8527",    "White - Any other White background") },
            { "D", new ValueWithNote("0",   "Mixed - White and Black Caribbean") },
            { "E", new ValueWithNote("0",   "Mixed - White and Black African") },
            { "F", new ValueWithNote("0",   "Mixed - White and Asian") },
            { "G", new ValueWithNote("0",   "Mixed - Any other mixed background") },
            { "H", new ValueWithNote("38003574",    "Asian or Asian British - Indian") },
            { "J", new ValueWithNote("38003589",    "Asian or Asian British - Pakistani") },
            { "K", new ValueWithNote("38003575",    "Asian or Asian British - Bangladeshi") },
            { "L", new ValueWithNote("8515",    "Asian or Asian British - Any other Asian background") },
            { "M", new ValueWithNote("38003598",    "Black or Black British - Caribbean") },
            { "N", new ValueWithNote("38003600",    "Black or Black British - African") },
            { "P", new ValueWithNote("38003598",    "Black or Black British - Any other Black background") },
            { "R", new ValueWithNote("38003579",    "Other Ethnic Groups - Chinese") },
            { "S", new ValueWithNote("0",   "Other Ethnic Groups - Any other ethnic group") },
            { "Z", new ValueWithNote("0",   "Not stated") },
            { "99", new ValueWithNote("0",  "Not known") }
        };

    public string[] ColumnNotes =>
    [
        "[NHS Race (i.e.Ethnicity)](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)",
        "[OMOP Race](https://athena.ohdsi.org/search-terms/terms?conceptClass=Race&invalidReason=Valid&vocabulary=Race&page=1&pageSize=50&query=)"
    ];
}