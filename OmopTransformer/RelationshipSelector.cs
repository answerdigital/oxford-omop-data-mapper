using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Resolve Measurement domain ICD10 codes to `Maps To Value` concepts.")]
internal class RelationshipSelector(string? code, MeasurementMapsToValueResolver relationshipResolver) : ISelector
{
    public object? GetValue() => relationshipResolver.GetConceptCode(code);
}