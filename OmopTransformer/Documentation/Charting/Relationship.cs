namespace OmopTransformer.Documentation.Charting;

public class Relationship (string source, string target, string label)
{
    public string Source { get; } = source;
    public string Target { get; } = target;
    public string Label { get; } = label;
}