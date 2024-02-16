namespace OmopTransformer.Annotations;

[AttributeUsage(AttributeTargets.Property)]
internal class TransformAttribute : Attribute
{
    public TransformAttribute(Type type, params string[] value) : this(type, useOmopTypeAsSource: false, value)
    {
    }

    public TransformAttribute(Type type, bool useOmopTypeAsSource, params string[] value)
    {
        Type = type;
        Value = value;
        UseOmopTypeAsSource = useOmopTypeAsSource;
    }


    public Type Type { get; }

    public bool UseOmopTypeAsSource { get; }

    public string[] Value { get; }
}