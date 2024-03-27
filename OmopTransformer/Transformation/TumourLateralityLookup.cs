using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup TumourLaterality concepts.")]
internal class TumourLateralityLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "L", new ValueWithNote("36770232",    "Left") },
            { "R", new ValueWithNote("36770058",    "Right") },
            { "M", new ValueWithNote("36769853",    "Midline") },
            { "B", new ValueWithNote("36770109",    "Bilateral") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&conceptClass=Topography&page=1&pageSize=500&query=&boosts)",
        "[NHS - Tumour Laterality](https://www.datadictionary.nhs.uk/data_elements/tumour_laterality.html?hl=tumour%2Claterality)"
    ];
}