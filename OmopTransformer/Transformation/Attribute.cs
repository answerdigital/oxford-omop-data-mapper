using OmopTransformer.Annotations;

namespace OmopTransformer.Transformation;

internal class Attribute
{
    private Attribute(object value, ILookup? lookup)
    {
        Value = value;
        Lookup = lookup;
    }

    public static Attribute Create(object value)
    {
        ILookup lookup = null;

        if (value is TransformAttribute transformAttribute && typeof(ILookup).IsAssignableFrom(transformAttribute.Type))
        {
            lookup = (ILookup)Activator.CreateInstance(transformAttribute.Type)!;
        }

        return new Attribute(value, lookup);
    }

    public object Value { get; }

    public ILookup? Lookup { get; }
}