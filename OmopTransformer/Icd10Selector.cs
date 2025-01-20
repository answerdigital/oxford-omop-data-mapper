using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Resolve ICD10 codes to standard OMOP concepts. If code cannot be mapped, map using the parent code.")]
internal class Icd10StandardSelector(string? code, Icd10StandardResolver resolver) : ISelector
{
    public object? GetValue() => resolver.GetConceptCode(code);
}