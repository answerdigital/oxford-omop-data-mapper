using System.Reflection;

namespace OmopTransformer.Transformation;

internal class Property
{
    public Property(PropertyInfo info, Attribute[] attributes)
    {
        Info = info;
        Attributes = attributes;
    }

    public PropertyInfo Info { get; }
    public Attribute[] Attributes { get; }
}