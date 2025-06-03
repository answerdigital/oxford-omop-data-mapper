namespace OmopTransformer.OxfordPrescribing.Staging;

internal interface IOxfordPrescribingRecordParser
{
    IEnumerable<OxfordPrescribingRecord> ReadFile(string path, CancellationToken cancellationToken);
}