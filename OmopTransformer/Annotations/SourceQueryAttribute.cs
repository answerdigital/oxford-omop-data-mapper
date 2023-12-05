namespace OmopTransformer.Annotations;

[AttributeUsage(AttributeTargets.Class)]
internal class SourceQueryAttribute : Attribute
{
    public SourceQueryAttribute(string queryFileName)
    {
        QueryFileName = queryFileName;
    }

    public string QueryFileName { get; }
}