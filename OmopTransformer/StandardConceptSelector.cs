using OmopTransformer.Annotations;
using OmopTransformer.ConceptResolution;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Converts concepts to standard concepts.")]
internal class StandardConceptSelector(int? conceptId, StandardConceptResolver resolver) : ISelector
{
    public object? GetValue()
    {
        if (conceptId.HasValue == false)
            return null;

        return resolver.GetConcepts(conceptId.Value, null);
    } 
}