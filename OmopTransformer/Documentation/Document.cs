namespace OmopTransformer.Documentation;

internal class Document
{
    public Document(string fileName, string contents)
    {
        FileName = fileName ?? throw new ArgumentNullException(nameof(fileName));
        Contents = contents ?? throw new ArgumentNullException(nameof(contents));
    }

    public string FileName { get; }
    public string Contents { get; }
}