using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup NCategory concepts.")]
internal class NCategoryLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "0", new ValueWithNote("1633440", "AJCC/UICC N0 Category") },
            { "0a", new ValueWithNote("1633621", "AJCC/UICC N0a Category") },
            { "0b", new ValueWithNote("1635244", "AJCC/UICC N0b Category") },
            { "1", new ValueWithNote("1634434", "AJCC/UICC N1 Category") },
            { "1a", new ValueWithNote("1633735", "AJCC/UICC N1a Category") },
            { "1b", new ValueWithNote("1635130", "AJCC/UICC N1b Category") },
            { "1c", new ValueWithNote("1634620", "AJCC/UICC N1c Category") },
            { "2", new ValueWithNote("1634119", "AJCC/UICC N2 Category") },
            { "2a", new ValueWithNote("1635644", "AJCC/UICC N2a Category") },
            { "2b", new ValueWithNote("1634134", "AJCC/UICC N2b Category") },
            { "2c", new ValueWithNote("1634080", "AJCC/UICC N2c Category") },
            { "3", new ValueWithNote("1635320", "AJCC/UICC N3 Category") },
            { "3a", new ValueWithNote("1635590", "AJCC/UICC N3a Category") },
            { "3b", new ValueWithNote("1633422", "AJCC/UICC N3b Category") },
            { "3c", new ValueWithNote("1634735", "AJCC/UICC N3c Category") },
            { "4", new ValueWithNote("1635445", "AJCC/UICC N4 Category") },
            { "X", new ValueWithNote("1633885", "AJCC/UICC NX Category") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)"
    ];
}