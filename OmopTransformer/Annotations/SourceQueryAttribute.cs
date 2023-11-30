namespace OmopTransformer.Annotations;

internal class SourceQueryAttribute : Attribute
{
    public SourceQueryAttribute(string queryFileName)
    {
        QueryFileName = queryFileName;
    }

    public string QueryFileName { get; }
}