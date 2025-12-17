namespace OmopTransformer.ConceptResolution;

public interface IStandardConceptResolverDataProvider
{
    Dictionary<int, IGrouping<int, ConceptCodeMapRow>> GetMappings();
    Dictionary<int, IReadOnlyCollection<int>> GetDevices();
}