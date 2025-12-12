using OmopTransformer.Annotations;
using OmopTransformer.ConceptResolution;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Maps concepts to standard valid concepts in the `drug` domain.")]
internal class StandardDrugConceptSelector(int? conceptId, StandardConceptResolver resolver) : ISelector
{
    public object? GetValue()
    {
        if (conceptId.HasValue == false)
            return null;

        return resolver.GetConcepts(conceptId.Value, "Drug");
    }
}