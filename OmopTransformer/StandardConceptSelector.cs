using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Converts concepts to standard concepts.")]
internal class StandardConceptSelector(int? conceptId, ConceptResolver resolver) : ISelector
{
    public object? GetValue()
    {
        if (conceptId.HasValue == false)
            return null;

        return resolver.GetConcepts(conceptId.Value, null);
    } 
}