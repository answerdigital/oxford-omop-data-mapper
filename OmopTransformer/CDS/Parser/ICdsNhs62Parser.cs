namespace OmopTransformer.CDS.Parser;

internal interface ICdsNhs62Parser
{
    IReadOnlyCollection<Message> ReadFile(string path, CancellationToken cancellationToken);
}