namespace OmopTransformer.Annotations;

internal class CopyValueAttribute : Attribute
{
    public CopyValueAttribute(string value)
    {
        Value = value;
    }

    public string Value { get; }
}