namespace OmopTransformer.Annotations;

internal class AggregateTransformAttribute : Attribute
{
    public AggregateTransformAttribute(string queryFileName)
    {
        QueryFileName = queryFileName;
    }

    public string QueryFileName { get; }
}