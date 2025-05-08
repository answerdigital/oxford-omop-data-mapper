namespace OmopTransformer;

internal interface IRecordProvider
{
    IAsyncEnumerable<IReadOnlyCollection<T>> GetRecordsBatched<T>(CancellationToken cancellationToken);
}