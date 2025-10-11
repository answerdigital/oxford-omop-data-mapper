using OmopTransformer.Annotations;
using OmopTransformer.Omop;

namespace OmopTransformer.Transformation;

internal class TransformPlan
{
    private TransformPlan(IReadOnlyCollection<Property> properties, bool twoStepTransformRequired)
    {
        Properties = properties;
        TwoStepTransformRequired = twoStepTransformRequired;
    }

    public IReadOnlyCollection<Property> Properties { get; init; }

    public bool TwoStepTransformRequired { get; init; }

    public static TransformPlan Create<T>(IOmopRecord<T> record)
    {
        var properties =
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
                .ToList();

        bool useOmopTypeAsSource =
            properties
                .SelectMany(p => p.Attributes)
                .Select(a => a.Value)
                .OfType<TransformAttribute>()
                .Any(attribute => attribute.UseOmopTypeAsSource);

        return 
            new TransformPlan(
                properties,
                useOmopTypeAsSource);
    }
}