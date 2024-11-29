namespace OmopTransformer.SUS.Staging.APC;

internal interface ISusAPCInserter
{
    Task Insert(IEnumerable<APCRecord> rows, CancellationToken cancellationToken);
}