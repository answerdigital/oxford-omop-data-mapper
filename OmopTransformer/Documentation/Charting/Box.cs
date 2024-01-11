namespace OmopTransformer.Documentation.Charting;

public class Box(string name, string? hyperlink)
{
    public string Name { get; } = name;

    public string? Hyperlink { get; } = hyperlink;
}