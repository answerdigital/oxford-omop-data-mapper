using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup TCategory concepts.")]
internal class TCategoryLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "0", new ValueWithNote("1634213", "AJCC/UICC T0 Category") },
            { "1", new ValueWithNote("1635564", "AJCC/UICC T1 Category") },
            { "1a", new ValueWithNote("1633880", "AJCC/UICC T1a Category") },
            { "1b", new ValueWithNote("1633921", "AJCC/UICC T1b Category") },
            { "1c", new ValueWithNote("1633529", "AJCC/UICC T1c Category") },
            { "1d", new ValueWithNote("1634100", "AJCC/UICC T1d Category") },
            { "2", new ValueWithNote("1635562", "AJCC/UICC T2 Category") },
            { "2a", new ValueWithNote("1635327", "AJCC/UICC T2a Category") },
            { "2b", new ValueWithNote("1633593", "AJCC/UICC T2b Category") },
            { "2c", new ValueWithNote("1635270", "AJCC/UICC T2c Category") },
            { "2d", new ValueWithNote("1633678", "AJCC/UICC T2d Category") },
            { "3", new ValueWithNote("1634376", "AJCC/UICC T3 Category") },
            { "3a", new ValueWithNote("1633771", "AJCC/UICC T3a Category") },
            { "3b", new ValueWithNote("1634980", "AJCC/UICC T3b Category") },
            { "3c", new ValueWithNote("1633360", "AJCC/UICC T3c Category") },
            { "3d", new ValueWithNote("1635625", "AJCC/UICC T3d Category") },
            { "3e", new ValueWithNote("1634730", "AJCC/UICC T3e Category") },
            { "4", new ValueWithNote("1634654", "AJCC/UICC T4 Category") },
            { "4a", new ValueWithNote("1635222", "AJCC/UICC T4a Category") },
            { "4b", new ValueWithNote("1634436", "AJCC/UICC T4b Category") },
            { "4c", new ValueWithNote("1635526", "AJCC/UICC T4c Category") },
            { "4d", new ValueWithNote("1633909", "AJCC/UICC T4d Category") },
            { "4e", new ValueWithNote("1634193", "AJCC/UICC T4e Category") },
            { "X", new ValueWithNote("1635682", "AJCC/UICC TX Category") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)"
    ];
}