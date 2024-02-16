using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Resolve OPCS4 codes to OMOP concepts. If code cannot be mapped, map using the parent code.")]
internal class Opcs4Selector(string? code, Opcs4Resolver opcs4Resolver) : ISelector
{
    public object? GetValue() => opcs4Resolver.GetConceptCode(code);
}