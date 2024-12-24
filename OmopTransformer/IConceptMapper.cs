namespace OmopTransformer;

internal interface IConceptMapper
{
    Task RenderConceptMap(CancellationToken cancellationToken);
}