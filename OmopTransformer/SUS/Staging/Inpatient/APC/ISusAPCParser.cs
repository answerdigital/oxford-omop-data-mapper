namespace OmopTransformer.SUS.Staging.Inpatient.APC;

internal interface ISusAPCParser
{
    IEnumerable<APCRecord> ReadFile(string path, CancellationToken cancellationToken);
}