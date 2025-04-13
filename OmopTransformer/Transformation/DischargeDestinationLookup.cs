using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup discharge destination concept.")]
internal class DischargeDestinationLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "19", new ValueWithNote("32759", "Home Isolation") },
            { "29", new ValueWithNote("8602",   "Temporary Lodging") },
            { "30", new ValueWithNote("38004284",   "Psychiatric Hospital") },
            { "37", new ValueWithNote("38003619", "Prison / Correctional Facility") },
            { "38", new ValueWithNote("38003619", "Prison / Correctional Facility") },
            { "48", new ValueWithNote("38004284",   "Psychiatric Hospital") },
            { "49", new ValueWithNote("38004284",   "Psychiatric Hospital") },
            { "50", new ValueWithNote("8971",   "Inpatient Psychiatric Facility") },
            { "51", new ValueWithNote("8717",   "Inpatient Hospital") },
            { "52", new ValueWithNote("8650",   "Birthing Center") },
            { "53", new ValueWithNote("8976",   "Psychiatric Residential Treatment Center") },
            { "54", new ValueWithNote("8676",   "Nursing Facility") },
            { "65", new ValueWithNote("8676",   "Nursing Facility") },
            { "66", new ValueWithNote("38004205",   "Foster Care Agency") },
            { "79", new ValueWithNote("8650",   "Birthing Center") },
            { "84", new ValueWithNote("8971",   "Inpatient Psychiatric Facility") },
            { "85", new ValueWithNote("8676",   "Nursing Facility") },
            { "87", new ValueWithNote("8717",   "Inpatient Hospital") },
            { "88", new ValueWithNote("8546",   "Hospice") },
            { "98", new ValueWithNote("",   "No mapping possible") },
            { "99", new ValueWithNote("",   "No mapping possible") },
        };

    public string[] ColumnNotes =>
    [
        "[Discharge Destination](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)",
        "[Discharge Destination](https://archive.datadictionary.nhs.uk/DD%20Release%20July%202024/attributes/discharge_destination.html)"
    ];
}