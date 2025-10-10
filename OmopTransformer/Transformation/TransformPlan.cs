using OmopTransformer.Omop;

namespace OmopTransformer.Transformation;

internal class TransformPlan
{
    private TransformPlan(IReadOnlyCollection<Property> properties)
    {
        Properties = properties;
    }

    public IReadOnlyCollection<Property> Properties { get; init; }

    public static TransformPlan Create<T>(IOmopRecord<T> record)
    {
        return 
            new TransformPlan(
                record
                    .GetType()
                    .GetProperties()
                    .Select(
                        property =>
                            new Property(
                                info: property,
                                attributes: 
                                property
                                    .GetCustomAttributes(inherit: false)
                                    .Select(Attribute.Create)
                                    .ToArray()
                            ))
                    .ToList());
    }
}