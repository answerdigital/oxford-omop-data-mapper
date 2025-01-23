namespace OmopTransformer.SUS.Staging.AE;

internal interface ISusAEParser
{
    IEnumerable<AERecord> ReadFile(string path, CancellationToken cancellationToken);
}