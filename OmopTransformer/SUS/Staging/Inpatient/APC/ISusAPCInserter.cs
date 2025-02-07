namespace OmopTransformer.SUS.Staging.Inpatient.APC;

internal interface ISusAPCInserter
{
    Task Insert(IEnumerable<APCRecord> rows, CancellationToken cancellationToken);
}