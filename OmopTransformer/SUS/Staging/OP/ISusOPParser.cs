namespace OmopTransformer.SUS.Staging.OP;

internal interface ISusOPParser
{
    IEnumerable<OPRecord> ReadFile(string path, CancellationToken cancellationToken);
}