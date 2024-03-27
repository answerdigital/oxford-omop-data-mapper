using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup MetastasisSite concepts.")]
internal class MetastasisSiteLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "02",   new ValueWithNote("36768862",     "Metastasis to brain") },
            { "03",   new ValueWithNote("36770544",     "Metastasis to liver") },
            { "04",   new ValueWithNote("36770283",     "Metastasis to lung") },
            { "07",   new ValueWithNote("35226309",     "Metastasis to the Unknown Site") },
            { "08",   new ValueWithNote("35225673",     "Metastasis to skin") },
            { "09",   new ValueWithNote("36769243",     "Distant spread to lymph node") },
            { "10",   new ValueWithNote("36769301",     "Metastasis to bone") },
            { "11",   new ValueWithNote("35226074",     "Metastasis to bone marrow") },
            { "12",   new ValueWithNote("36769269",     "Regional spread to lymph node") },
            { "98",   new ValueWithNote("36769180",     "Metastasis") },
            { "99",   new ValueWithNote("36769180",     "Metastasis") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Metastasis](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=metastasis&boosts)",
        "[NHS - Metastasis](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html?hl=metastatic%2Csite%2Cdiagnosis)"
    ];
}