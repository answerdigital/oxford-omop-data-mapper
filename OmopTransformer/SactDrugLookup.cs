using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("SACT Drug lookup")]
internal class SactDrugLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "ABEMACICLIB", new ValueWithNote("792649", "abemaciclib") },
            { "ABIRATERONE ACETATE", new ValueWithNote("46274231", "abiraterone acetate") },
            { "Abiraterone", new ValueWithNote("40239056", "abiraterone") },
            { "ACALABRUTINIB", new ValueWithNote("792764", "acalabrutinib") },
            { "ACICLOVIR", new ValueWithNote("42907410", "VACICLOVIR") },
        };

    public string[] ColumnNotes =>
    [
        "[Athena Drug Concepts](https://athena.ohdsi.org/search-terms/terms?standardConcept=Standard&domain=Drug&vocabulary=RxNorm&vocabulary=RxNorm+Extension&invalidReason=Valid&page=1&pageSize=15&query=)"
    ];
}