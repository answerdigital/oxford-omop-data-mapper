namespace OmopTransformer.SUS.Staging.OP;

internal interface ISusOPInserter
{
    Task Insert(IEnumerable<OPRecord> rows, CancellationToken cancellationToken);
}