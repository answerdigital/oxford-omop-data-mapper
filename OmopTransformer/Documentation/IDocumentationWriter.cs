namespace OmopTransformer.Documentation;

internal interface IDocumentationWriter
{
    Task WriteToPath(CancellationToken cancellationToken);
}