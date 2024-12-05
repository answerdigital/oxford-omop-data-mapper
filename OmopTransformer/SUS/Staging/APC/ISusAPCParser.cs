namespace OmopTransformer.SUS.Staging.APC;

internal interface ISusAPCParser
{
    IEnumerable<APCRecord> ReadFile(string path, CancellationToken cancellationToken);
}