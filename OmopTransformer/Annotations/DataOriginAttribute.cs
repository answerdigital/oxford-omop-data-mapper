namespace OmopTransformer.Annotations;

internal class DataOriginAttribute : Attribute
{
    public DataOriginAttribute(string value)
    {
        Value = value;
    }

    public string Value { get; }
}