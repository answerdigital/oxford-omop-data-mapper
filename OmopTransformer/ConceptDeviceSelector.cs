using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Finds related devices for a concept.")]
internal class ConceptDeviceSelector(int? conceptId, StandardConceptResolver resolver) : ISelector
{
    public object? GetValue()
    {
        if (conceptId.HasValue == false)
            return null;

        return resolver.GetConceptDevices(conceptId.Value);
    } 
}