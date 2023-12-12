namespace OmopTransformer;

internal interface IRecordProvider
{
    Task<IReadOnlyCollection<T>> GetRecords<T>(CancellationToken cancellationToken);
}