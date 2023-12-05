namespace OmopTransformer.SACT;

internal interface ISactProvider
{
    Task<IReadOnlyCollection<Sact>> GetRecords(CancellationToken cancellationToken);
}