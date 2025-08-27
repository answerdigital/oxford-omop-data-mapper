using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup discharge destination concept for A&E.")]
internal class AccidentAndEmergencyDischargeDestinationLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "01", new ValueWithNote("8717", "In Patient Hospital") },
            { "02", new ValueWithNote("38004453", "Family Practice") },
            { "03", new ValueWithNote("32759", "Home Isolation") },
            { "04", new ValueWithNote("8870", "Emergency Room - Hospital") },
            { "05", new ValueWithNote("8870", "Emergency Room - Hospital") },
            { "06", new ValueWithNote("8756", "Out Patient Hospital") },
            { "07", new ValueWithNote("",     "No mapping possible") },
            { "10", new ValueWithNote("",     "No mapping possible") },
            { "11", new ValueWithNote("",     "No mapping possible") },
            { "12", new ValueWithNote("",     "No mapping possible") },
            { "13", new ValueWithNote("",     "No mapping possible") },
            { "14", new ValueWithNote("",     "No mapping possible") }
        };

    public string[] ColumnNotes =>
    [
        "[Discharge Destination](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)",
        "[Discharge Destination A&E](https://archive.datadictionary.nhs.uk/DD%20Release%20September%202020/data_elements/accident_and_emergency_attendance_disposal_code.html)"
    ];
}