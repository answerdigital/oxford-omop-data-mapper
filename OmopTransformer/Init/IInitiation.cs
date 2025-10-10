namespace OmopTransformer.Init;

internal interface IInitiation
{
    Task Initiate(CancellationToken cancellationToken);
}