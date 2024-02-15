using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup admission source concept.")]
internal class AdmittedSourceLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "19", new ValueWithNote("0",  "Home") },
            { "29", new ValueWithNote("8602",   "Temporary Lodging") },
            { "37", new ValueWithNote("4050489",    "County court bailiff") },
            { "40", new ValueWithNote("38003619",   "Prison / Correctional Facility") },
            { "42", new ValueWithNote("4107305",    "Police station") },
            { "49", new ValueWithNote("38004284",   "Psychiatric Hospital") },
            { "51", new ValueWithNote("8717",   "Inpatient Hospital") },
            { "52", new ValueWithNote("8650",   "Birthing Center") },
            { "53", new ValueWithNote("8976",   "Psychiatric Residential Treatment Center") },
            { "55", new ValueWithNote("8863",   "Skilled Nursing Facility") },
            { "56", new ValueWithNote("38004306",   "Custodial Care Facility") },
            { "66", new ValueWithNote("38004205",   "Foster Care Agency") },
            { "79", new ValueWithNote("40482051",   "Born before arrival to hospital") },
            { "87", new ValueWithNote("4113007",    "Inpatient Hospital") },
            { "88", new ValueWithNote("8546",   "Hospice") },
            { "98", new ValueWithNote("",   "") },
            { "99", new ValueWithNote("",   "") }
        };

    public string[] ColumnNotes =>
    [
        "[Admission Source](https://www.datadictionary.nhs.uk/data_elements/admission_source__hospital_provider_spell_.html)"
    ];
}