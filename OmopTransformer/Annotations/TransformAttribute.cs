namespace OmopTransformer.Annotations;

[AttributeUsage(AttributeTargets.Property)]
internal class TransformAttribute : Attribute
{
    public TransformAttribute(Type type, params string[] value)
    {
        Type = type;
        Value = value;
    }

    public Type Type { get; }

    public string[] Value { get; }
}