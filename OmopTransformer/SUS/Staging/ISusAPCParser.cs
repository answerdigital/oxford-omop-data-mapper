namespace OmopTransformer.SUS.Staging;

internal interface ISusAPCParser
{
    IEnumerable<APCRecord> ReadFile(string path, CancellationToken cancellationToken);
}