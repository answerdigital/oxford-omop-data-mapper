using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Maps concepts to standard valid concepts in the `device` domain.")]
internal class StandardDeviceConceptSelector(int? conceptId, StandardConceptResolver resolver) : ISelector
{
    public object? GetValue()
    {
        if (conceptId.HasValue == false)
            return null;

        return resolver.GetConcepts(conceptId.Value, "Device");
    }
}