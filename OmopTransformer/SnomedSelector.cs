using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Resolve Snomed codes to OMOP concepts.")]
internal class SnomedSelector(string? code, SnomedResolver resolver) : ISelector
{
    public object? GetValue() => resolver.GetConceptCode(code);
}