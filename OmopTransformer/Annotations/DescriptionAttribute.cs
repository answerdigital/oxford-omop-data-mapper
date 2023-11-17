namespace OmopTransformer.Annotations;

internal class DescriptionAttribute : Attribute
{
    public DescriptionAttribute(string value)
    {
        Value = value;
    }

    public string Value { get; }
}