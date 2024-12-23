namespace OmopTransformer.Omop.Provider;

internal interface IProviderRecorder
{
    Task InsertUpdateProvider<T>(IReadOnlyCollection<OmopProvider<T>> records, string dataSource, CancellationToken cancellationToken);
}
