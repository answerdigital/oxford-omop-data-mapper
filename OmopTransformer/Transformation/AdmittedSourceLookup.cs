using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup admission source concept.")]
internal class AdmittedSourceLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "1", new ValueWithNote("38004353", "Ambulance") },
            { "2", new ValueWithNote("",  "No mapping possible") },
            { "19", new ValueWithNote("581476", "Home Visit") },
            { "29", new ValueWithNote("8602",  "Temporary Lodging") },
            { "37", new ValueWithNote("38003619",  "Prison / Correctional Facility") },
            { "40", new ValueWithNote("38003619",  "Prison / Correctional Facility") },
            { "42", new ValueWithNote("38003619",  "Prison / Correctional Facility") },
            { "49", new ValueWithNote("38004284",  "Psychiatric Hospital") },
            { "51", new ValueWithNote("8717",  "Inpatient Hospital") },
            { "52", new ValueWithNote("8650",  "Birthing Center") },
            { "53", new ValueWithNote("8976",  "Psychiatric Residential Treatment Center") },
            { "55", new ValueWithNote("8863",  "Skilled Nursing Facility") },
            { "56", new ValueWithNote("38004306",  "Custodial Care Facility") },
            { "66", new ValueWithNote("38004205",  "Foster Care Agency") },
            { "79", new ValueWithNote("8650",  "Birthing Center") },
            { "87", new ValueWithNote("8717",   "Inpatient Hospital") },
            { "88", new ValueWithNote("8546",  "Hospice") },
            { "98", new ValueWithNote("",  "No mapping possible") },
            { "99", new ValueWithNote("",  "No mapping possible") }
        };

    public string[] ColumnNotes =>
    [
        "[Admission Source](https://www.datadictionary.nhs.uk/data_elements/admission_source__hospital_provider_spell_.html)",
        "[Admission Source A&E](https://archive.datadictionary.nhs.uk/DD%20Release%20September%202020/attributes/accident_and_emergency_arrival_mode.html)"
    ];
}