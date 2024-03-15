using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

[Description("Lookup NHS Data Dictionary Basis Of Diagnosis Cancer")]
internal class DataDictionaryBasisOfDiagnosisCancerLookup : ILookup
{
    public Dictionary<string, ValueWithNote> Mappings { get; } =
        new()
        {
            { "0", new ValueWithNote("32895",   "Death diagnosis") },
            { "1", new ValueWithNote("32899",   "Preliminary diagnosis") },
            { "2", new ValueWithNote("32899",   "Preliminary diagnosis") },
            { "4", new ValueWithNote("32893",   "Confirmed diagnosis") },
            { "5", new ValueWithNote("32893",   "Confirmed diagnosis") },
            { "6", new ValueWithNote("32908",   "Secondary diagnosis") },
            { "7", new ValueWithNote("32902",   "Primary diagnosis") },
            { "9", new ValueWithNote("","") }
        };

    public string[] ColumnNotes =>
    [
        "[OMOP Condition Status](https://athena.ohdsi.org/search-terms/terms?domain=Condition+Status&standardConcept=Standard&page=1&pageSize=50&query=)",
        "[NHS Basis of Diagnosis of Cancer](https://www.datadictionary.nhs.uk/attributes/basis_of_diagnosis_for_cancer.html?hl=basis%2Cdiagnosis%2Ccancer)"
    ];
}