using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Resolve ICD10 codes to OMOP concept relationship values")]
internal class RelationshipSelector(string? code, RelationshipResolver relationshipResolver) : ISelector
{
    public object? GetValue() => relationshipResolver.GetRelatedConceptValue(code);
}