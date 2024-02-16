using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup race concept.")]
internal class RaceConceptLookup : ILookup
{
    public Dictionary<KeyWithName, ValueWithNote> Mappings { get; } =
        new()
        {
            { new KeyWithName("A", ""), new ValueWithNote("8527",    "White - British") },
            { new KeyWithName("B", ""), new ValueWithNote("8527",    "White - Irish") },
            { new KeyWithName("C", ""), new ValueWithNote("8527",    "White - Any other White background") },
            { new KeyWithName("D", ""), new ValueWithNote("8527",   "Mixed - White and Black Caribbean [Athena mapping](https://athena.ohdsi.org/search-terms/terms/700388)") },
            { new KeyWithName("E", ""), new ValueWithNote("8527",   "Mixed - White and Black African [Athena mapping](https://athena.ohdsi.org/search-terms/terms/700389)") },
            { new KeyWithName("F", ""), new ValueWithNote("8527",   "Mixed - White and Asian [Athena mapping](https://athena.ohdsi.org/search-terms/terms/700390)") },
            { new KeyWithName("G", ""), new ValueWithNote("8527",   "Mixed - Any other mixed background [Athena mapping](https://athena.ohdsi.org/search-terms/terms/700391)") },
            { new KeyWithName("H", ""), new ValueWithNote("38003574",    "Asian or Asian British - Indian") },
            { new KeyWithName("J", ""), new ValueWithNote("38003589",    "Asian or Asian British - Pakistani") },
            { new KeyWithName("K", ""), new ValueWithNote("38003575",    "Asian or Asian British - Bangladeshi") },
            { new KeyWithName("L", ""), new ValueWithNote("8515",    "Asian or Asian British - Any other Asian background") },
            { new KeyWithName("M", ""), new ValueWithNote("38003598",    "Black or Black British - Caribbean") },
            { new KeyWithName("N", ""), new ValueWithNote("38003600",    "Black or Black British - African") },
            { new KeyWithName("P", ""), new ValueWithNote("38003598",    "Black or Black British - Any other Black background") },
            { new KeyWithName("R", ""), new ValueWithNote("38003579",    "Other Ethnic Groups - Chinese") },
            { new KeyWithName("S", ""), new ValueWithNote("0",   "Other Ethnic Groups - Any other ethnic group") },
            { new KeyWithName("Z", ""), new ValueWithNote("0",   "Not stated") },
            { new KeyWithName("99", ""), new ValueWithNote("0",  "Not known") }
        };

    public string[] ColumnNotes =>
    [
        "[NHS Race (i.e.Ethnicity)](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)",
        "[OMOP Race](https://athena.ohdsi.org/search-terms/terms?conceptClass=Race&invalidReason=Valid&vocabulary=Race&page=1&pageSize=50&query=)",
        @"[D, E, F, G Race mapping](https://forums.ohdsi.org/t/mapping-nhs-ethnic-category-to-omop-race/20883/2)"
    ];
}


[Description("Lookup race source concept.")]
internal class RaceSourceConceptLookup : ILookup
{
    public Dictionary<KeyWithName, ValueWithNote> Mappings { get; } =
        new()
        {
            { new KeyWithName("A", ""), new ValueWithNote("700385", "White - British") },
            { new KeyWithName("B", ""), new ValueWithNote("700386", "White - Irish") },
            { new KeyWithName("C", ""), new ValueWithNote("700387", "White - Any other White background") },
            { new KeyWithName("D", ""), new ValueWithNote("700388", "Mixed - White and Black Caribbean") },
            { new KeyWithName("E", ""), new ValueWithNote("700389", "Mixed - White and Black African") },
            { new KeyWithName("F", ""), new ValueWithNote("700390", "Mixed - White and Asian") },
            { new KeyWithName("G", ""), new ValueWithNote("700391", "Mixed - Any other mixed background") },
            { new KeyWithName("H", ""), new ValueWithNote("700362", "Asian or Asian British - Indian") },
            { new KeyWithName("J", ""), new ValueWithNote("700363", "Asian or Asian British - Pakistani") },
            { new KeyWithName("K", ""), new ValueWithNote("700364", "Asian or Asian British - Bangladeshi") },
            { new KeyWithName("L", ""), new ValueWithNote("700365", "Asian or Asian British - Any other Asian background") },
            { new KeyWithName("M", ""), new ValueWithNote("700366", "Black or Black British - Caribbean") },
            { new KeyWithName("N", ""), new ValueWithNote("700367", "Black or Black British - African") },
            { new KeyWithName("P", ""), new ValueWithNote("700368", "Black or Black British - Any other Black background") },
            { new KeyWithName("R", ""), new ValueWithNote("700369", "Other Ethnic Groups - Chinese") },
            { new KeyWithName("S", ""), new ValueWithNote("", "Other Ethnic Groups - Any other ethnic group") },
            { new KeyWithName("Z", ""), new ValueWithNote("", "Not stated") },
            { new KeyWithName("99", ""), new ValueWithNote("", "Not known") },
        };

    public string[] ColumnNotes =>
    [
        "[NHS Race (i.e.Ethnicity)](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)",
        "[OMOP Race](https://athena.ohdsi.org/search-terms/terms?conceptClass=Race&invalidReason=Valid&vocabulary=Race&page=1&pageSize=50&query=)"
    ];
}