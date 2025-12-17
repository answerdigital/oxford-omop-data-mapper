using OmopTransformer.Annotations;
using OmopTransformer.ConceptResolution;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Maps concepts to standard valid concepts in the `procedure` domain.")]
internal class StandardProcedureConceptSelector(int? conceptId, StandardConceptResolver resolver) : ISelector
{
    public object? GetValue()
    {
        if (conceptId.HasValue == false)
            return null;

        return resolver.GetConcepts(conceptId.Value, "Procedure");
    }
}