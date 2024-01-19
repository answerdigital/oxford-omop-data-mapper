using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Resolve ICD10 codes to OMOP concepts. If code cannot be mapped, map using the parent code.")]
internal class Icd10Selector(string? code, Icd10Resolver icd10Resolver) : ISelector
{
    public object? GetValue() => icd10Resolver.GetConceptCode(code);
}