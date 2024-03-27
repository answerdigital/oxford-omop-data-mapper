using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup SynchronousTumour concepts.")]
internal class SynchronousTumourLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "01",  new ValueWithNote("36768217",    "Cecum") },
            { "02",  new ValueWithNote("36770601",    "Appendix") },
            { "03",  new ValueWithNote("36768852",    "Ascending Colon") },
            { "04",  new ValueWithNote("36768109",    "Hepatic Flexure") },
            { "05",  new ValueWithNote("36770627",    "Transverse Colon") },
            { "06",  new ValueWithNote("36769645",    "Splenic Flexure") },
            { "07",  new ValueWithNote("36769819",    "Descending Colon") },
            { "08",  new ValueWithNote("36770395",    "Sigmoid Colon") },
            { "09",  new ValueWithNote("36768690",    "Rectosigmoid") },
            { "10",  new ValueWithNote("36769244",    "Rectum") },
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Cancer Modifier Measurements](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&standardConcept=Standard&page=1&pageSize=500&query=&boosts)",
        "[NHS - Synchronous Tumour Colon location (at Diagnosis)](https://www.datadictionary.nhs.uk/data_elements/synchronous_tumour_colon_location__at_diagnosis_.html?hl=synchronous%2Ctumour%2Ccolon%2Clocation%2Cdiagnosis)"
    ];
}