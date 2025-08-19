namespace OmopTransformer;

internal interface IRecordProvider
{
    Task<IReadOnlyCollection<T>> GetRecordsBatched<T>(int batchNumber, CancellationToken cancellationToken);
}