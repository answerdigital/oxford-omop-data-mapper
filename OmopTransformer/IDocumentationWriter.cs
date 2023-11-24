namespace OmopTransformer;

internal interface IDocumentationWriter
{
    Task WriteToPath(CancellationToken cancellationToken);
}