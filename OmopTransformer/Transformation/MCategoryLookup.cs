using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup  concepts.")]
internal class MCategoryLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "0", new ValueWithNote("1635624", "AJCC/UICC M0 Category") },
            { "1", new ValueWithNote("1635142", "AJCC/UICC M1 Category") },
            { "1a", new ValueWithNote("1635100", "AJCC/UICC M1a Category") },
            { "1b", new ValueWithNote("1634463", "AJCC/UICC M1b Category") },
            { "1c", new ValueWithNote("1635519", "AJCC/UICC M1c Category") },
            { "1d", new ValueWithNote("1634064", "AJCC/UICC M1d Category") },
            { "X  ", new ValueWithNote("1633547", "AJCC/UICC MX Category") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)"
    ];
}