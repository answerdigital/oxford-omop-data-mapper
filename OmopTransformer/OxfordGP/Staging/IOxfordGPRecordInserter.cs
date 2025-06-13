namespace OmopTransformer.OxfordGP.Staging;

internal interface IOxfordGPRecordInserter
{
    Task Insert(GPRecord records, CancellationToken cancellationToken);
}