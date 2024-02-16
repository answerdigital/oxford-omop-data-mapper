using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup discharge destination concept.")]
internal class DischargeDestinationLookup : ILookup
{
    public Dictionary<KeyWithName, ValueWithNote> Mappings { get; } =
        new()
        {
            { new KeyWithName("19", ""), new ValueWithNote("0",  "Home - Used 0 as `Home` as per the OHDSI documentation") },
            { new KeyWithName("29", ""), new ValueWithNote("8602",   "Temporary Lodging") },
            { new KeyWithName("30", ""), new ValueWithNote("38004284",   "Psychiatric Hospital") },
            { new KeyWithName("37", ""), new ValueWithNote("4050489",    "County court bailiff - Had to use the Social Context Domain and SNOMED Vocab") },
            { new KeyWithName("38", ""), new ValueWithNote("38003619",   "Prison / Correctional Facility - Went with `Prison / Correctional Facility` over Police Station (4107305)") },
            { new KeyWithName("48", ""), new ValueWithNote("38004284",   "Psychiatric Hospital") },
            { new KeyWithName("49", ""), new ValueWithNote("38004284",   "Psychiatric Hospital") },
            { new KeyWithName("50", ""), new ValueWithNote("8971",   "Inpatient Psychiatric Facility") },
            { new KeyWithName("51", ""), new ValueWithNote("8717",   "Inpatient Hospital") },
            { new KeyWithName("52", ""), new ValueWithNote("8650",   "Birthing Center") },
            { new KeyWithName("53", ""), new ValueWithNote("8976",   "Psychiatric Residential Treatment Center") },
            { new KeyWithName("54", ""), new ValueWithNote("8676",   "Nursing Facility") },
            { new KeyWithName("65", ""), new ValueWithNote("8676",   "Nursing Facility") },
            { new KeyWithName("66", ""), new ValueWithNote("38004205",   "Foster Care Agency") },
            { new KeyWithName("79", ""), new ValueWithNote("",   "No mapping possible") },
            { new KeyWithName("84", ""), new ValueWithNote("8971",   "Inpatient Psychiatric Facility") },
            { new KeyWithName("85", ""), new ValueWithNote("8676",   "Nursing Facility") },
            { new KeyWithName("87", ""), new ValueWithNote("8717",   "Inpatient Hospital") },
            { new KeyWithName("88", ""), new ValueWithNote("8546",   "Hospice") },
            { new KeyWithName("98", ""), new ValueWithNote("",   "No mapping possible") },
            { new KeyWithName("99", ""), new ValueWithNote("",   "No mapping possible") },
        };

    public string[] ColumnNotes =>
    [
        "[Discharge Destination](https://www.datadictionary.nhs.uk/data_elements/discharge_destination_code__hospital_provider_spell_.html)"
    ];
}