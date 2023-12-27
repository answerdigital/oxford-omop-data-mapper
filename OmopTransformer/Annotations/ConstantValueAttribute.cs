namespace OmopTransformer.Annotations;

[AttributeUsage(AttributeTargets.Property)]
internal class ConstantValueAttribute : Attribute
{
    public ConstantValueAttribute(object value, string description)
    {
        Value = value ?? throw new ArgumentNullException(nameof(value));
        Description = description;
    }

    public object Value { get; }
    public string Description { get; }
}