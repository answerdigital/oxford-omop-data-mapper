using OmopTransformer.Annotations;
using OmopTransformer.Transformation;

namespace OmopTransformer;

[Description("Converts ICD10/OPCS4 concepts to SNOMED concepts.")]
internal class SnomedSelector(int? conceptId, ConceptSnomedResolver resolver) : ISelector
{
    public object? GetValue()
    {
        if (conceptId.HasValue == false)
            return null;

        return resolver.GetSnomedConcepts(conceptId.Value).ToArray();
    } 
}