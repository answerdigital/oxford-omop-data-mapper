using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.")]
internal class Icd10StandardNonStandardSelector(string? code, Icd10NonStandardResolver resolver) : ISelector
{
    public object? GetValue() => resolver.GetConceptCode(code);
}