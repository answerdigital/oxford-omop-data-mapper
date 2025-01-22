namespace OmopTransformer.SUS.Staging.AE;

internal interface ISusAEInserter
{
    Task Insert(IEnumerable<AERecord> rows, CancellationToken cancellationToken);
}