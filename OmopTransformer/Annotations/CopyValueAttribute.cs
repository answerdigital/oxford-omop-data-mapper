namespace OmopTransformer.Annotations;

internal class CopyValueAttribute : Attribute
{
    public CopyValueAttribute(string value)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Value { get; }
}