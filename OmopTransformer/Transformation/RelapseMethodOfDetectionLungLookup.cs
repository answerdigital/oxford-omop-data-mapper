using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup RelapseMethodOfDetection concepts for lung cancer recurrence.")]
internal class RelapseMethodOfDetectionLungLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "1",   new ValueWithNote("4303062", "Morphology") },
            { "2",   new ValueWithNote("4276031", "Flow") },
            { "3",   new ValueWithNote("4233623", "Molecular") },
            { "4",   new ValueWithNote("4240345", "Clinical Examination") },
            { "9",   new ValueWithNote("0", "Other (not listed)") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Morphology](https://athena.ohdsi.org/search-terms/terms/4303062)",
        "[OMOP Flow](https://athena.ohdsi.org/search-terms/terms/4276031)",
        "[OMOP Molecular](https://athena.ohdsi.org/search-terms/terms/4233623)",
        "[OMOP Clinical Examination](https://athena.ohdsi.org/search-terms/terms/4240345)",
        "[RELAPSE - METHOD OF DETECTION](https://www.datadictionary.nhs.uk/data_elements/relapse_-_method_of_detection.html)"
    ];
}
