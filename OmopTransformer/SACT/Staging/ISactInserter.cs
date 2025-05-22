namespace OmopTransformer.SACT.Staging;

internal interface ISactInserter
{
    Task Insert(IReadOnlyCollection<SactCsvRow> sactRows, CancellationToken cancellationToken);
}