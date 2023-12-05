namespace OmopTransformer.SACT.Staging;

internal interface ISactInserter
{
    Task Insert(IReadOnlyCollection<Sact> sactRows, CancellationToken cancellationToken);
}