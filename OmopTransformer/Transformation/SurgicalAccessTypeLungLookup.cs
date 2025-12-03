using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup SurgicalAccessType concepts for lung cancer procedures.")]
internal class SurgicalAccessTypeLungLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "1",   new ValueWithNote("4044378",     "Open approach") },
            { "2",   new ValueWithNote("4044378",     "Laparoscopic/Thoracoscopic with planned conversion to open surgery") },
            { "3",   new ValueWithNote("4044378",     "Laparoscopic/Thoracoscopic with unplanned conversion to open surgery") },
            { "4",   new ValueWithNote("44808608",    "Laparoscopic/Thoracoscopic completed") },
            { "5",   new ValueWithNote("44790026",    "Robotic surgery") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Open approach](https://athena.ohdsi.org/search-terms/terms/4044378)",
        "[OMOP Laparoscopic/Thoracoscopic](https://athena.ohdsi.org/search-terms/terms/44808608)",
        "[OMOP Robotic surgery](https://athena.ohdsi.org/search-terms/terms/44790026)"
    ];
}
