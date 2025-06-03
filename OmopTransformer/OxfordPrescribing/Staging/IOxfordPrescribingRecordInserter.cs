namespace OmopTransformer.OxfordPrescribing.Staging;

internal interface IOxfordPrescribingRecordInserter
{
    Task Insert(IEnumerable<OxfordPrescribingRecord> rows, CancellationToken cancellationToken);
}