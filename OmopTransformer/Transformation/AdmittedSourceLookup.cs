using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup admission source concept.")]
internal class AdmittedSourceLookup : ILookup
{
    public Dictionary<KeyWithName, ValueWithNote> Mappings { get; } =
        new()
        {
            { new KeyWithName("19", ""), new ValueWithNote("0",  "Home - Used 0 as `Home` as per the OHDSI documentation") },
            { new KeyWithName("29", ""), new ValueWithNote("8602",   "Temporary Lodging") },
            { new KeyWithName("37", ""), new ValueWithNote("4050489",    "County court bailiff - Had to use the Social Context Domain and SNOMED Vocab") },
            { new KeyWithName("40", ""), new ValueWithNote("38003619",   "Prison / Correctional Facility") },
            { new KeyWithName("42", ""), new ValueWithNote("4107305",    "Police station - Had to use the Observation Domain and SNOMED Vocab") },
            { new KeyWithName("49", ""), new ValueWithNote("38004284",   "Psychiatric Hospital") },
            { new KeyWithName("51", ""), new ValueWithNote("8717",   "Inpatient Hospital") },
            { new KeyWithName("52", ""), new ValueWithNote("8650",   "Birthing Center") },
            { new KeyWithName("53", ""), new ValueWithNote("8976",   "Psychiatric Residential Treatment Center") },
            { new KeyWithName("55", ""), new ValueWithNote("8863",   "Skilled Nursing Facility") },
            { new KeyWithName("56", ""), new ValueWithNote("38004306",   "Custodial Care Facility") },
            { new KeyWithName("66", ""), new ValueWithNote("38004205",   "Foster Care Agency") },
            { new KeyWithName("79", ""), new ValueWithNote("40482051",   "Born before arrival to hospital") },
            { new KeyWithName("87", ""), new ValueWithNote("4113007",    "Inpatient Hospital") },
            { new KeyWithName("88", ""), new ValueWithNote("8546",   "Hospice") },
            { new KeyWithName("98", ""), new ValueWithNote("",   "No mapping possible") },
            { new KeyWithName("99", ""), new ValueWithNote("",   "No mapping possible") }
        };

    public string[] ColumnNotes =>
    [
        "[Admission Source](https://www.datadictionary.nhs.uk/data_elements/admission_source__hospital_provider_spell_.html)"
    ];
}