using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup Databricks ethnic group as an OMOP race concept.")]
internal class DatabricksEthnicityLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "Asian - Any Other Asian Background", new ValueWithNote("8515", "Asian or Asian British - Any other Asian background") },
            { "Asian or Asian British - Bangladeshi", new ValueWithNote("38003575", "Asian or Asian British - Bangladeshi") },
            { "Asian or Asian British - Indian", new ValueWithNote("38003574", "Asian or Asian British - Indian") },
            { "Asian or Asian British - Pakistani", new ValueWithNote("38003589", "Asian or Asian British - Pakistani") },
            { "Black - Any Other Black Background", new ValueWithNote("38003598", "Black or Black British - Any other Black background") },
            { "Black or Black British - African", new ValueWithNote("38003600", "Black or Black British - African") },
            { "Black or Black British - Caribbean", new ValueWithNote("38003598", "Black or Black British - Caribbean") },
            { "Mixed - Any Other Mixed Background", new ValueWithNote("8527", "Mixed - Any other mixed background [Athena mapping](https://athena.ohdsi.org/search-terms/terms/700391)") },
            { "Mixed - White and Asian", new ValueWithNote("8527", "Mixed - White and Asian [Athena mapping](https://athena.ohdsi.org/search-terms/terms/700390)") },
            { "Mixed - White and Black African", new ValueWithNote("8527", "Mixed - White and Black African [Athena mapping](https://athena.ohdsi.org/search-terms/terms/700389)") },
            { "Mixed - White and Black Caribbean", new ValueWithNote("8527", "Mixed - White and Black Caribbean [Athena mapping](https://athena.ohdsi.org/search-terms/terms/700388)") },
            { "Other - Any Other Ethnic Group", new ValueWithNote("0", "Other Ethnic Groups - Any other ethnic group") },
            { "Other - Chinese", new ValueWithNote("38003579", "Other Ethnic Groups - Chinese") },
            { "Other - Not Known", new ValueWithNote("0", "Not known") },
            { "Other - Not Stated", new ValueWithNote("0", "Not stated") },
            { "White - Any Other White Background", new ValueWithNote("8527", "White - Any other White background") },
            { "White - British", new ValueWithNote("8527", "White - British") },
            { "White - Irish", new ValueWithNote("8527", "White - Irish") },
            { "", new ValueWithNote("0", "No data") }
        };

    public string[] ColumnNotes =>
    [
        "[NHS Race (i.e.Ethnicity)](https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html)",
        "[OMOP Race](https://athena.ohdsi.org/search-terms/terms?conceptClass=Race&invalidReason=Valid&vocabulary=Race&page=1&pageSize=50&query=)",
        "[Mixed race mapping](https://forums.ohdsi.org/t/mapping-nhs-ethnic-category-to-omop-race/20883/2)"
    ];
}
