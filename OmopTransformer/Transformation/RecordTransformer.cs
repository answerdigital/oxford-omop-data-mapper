using System.Reflection;
using Microsoft.Extensions.Logging;
using OmopTransformer.Annotations;
using OmopTransformer.Omop;

namespace OmopTransformer.Transformation;

internal class RecordTransformer : IRecordTransformer
{
    private readonly ILogger<RecordTransformer> _logger;

    public RecordTransformer(ILogger<RecordTransformer> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public void Transform<T>(IOmopRecord<T> record)
    {
        if (record == null) throw new ArgumentNullException(nameof(record));

        Type sourceType = record.Source!.GetType();

        var properties = record.GetType().GetProperties();

        _logger.LogTrace("Transforming {0}.", record.GetType());

        foreach (var property in properties)
        {
            var attributes = property.GetCustomAttributes(inherit: false);

            foreach (var attribute in attributes)
            {
                if (attribute is CopyValueAttribute copyValueAttribute)
                {
                    TransformCopyValue(record, property, sourceType, copyValueAttribute);
                }

                if (attribute is TransformAttribute transformAttribute)
                {
                    Transform(record, transformAttribute, property, sourceType);
                }
            }
        }
    }

    private void Transform<T>(IOmopRecord<T> record, TransformAttribute transformAttribute, PropertyInfo property, Type sourceType)
    {
        if (typeof(ISelector).IsAssignableFrom(transformAttribute.Type))
        {
            TransformSelector(record, transformAttribute, property, sourceType);
        }
        else
        {
            throw new NotSupportedException($"Unknown transform action {transformAttribute.Value}.");
        }
    }

    private void TransformSelector<T>(IOmopRecord<T> record, TransformAttribute transformAttribute, PropertyInfo property, Type sourceType)
    {
        _logger.LogTrace("Selector transform found on property {0}", property.Name);

        var arguments =
            transformAttribute
                .Value
                .Select(argumentName => sourceType.GetProperty(argumentName)!.GetValue(record.Source))
                .ToArray();

        var selector = (ISelector)Activator.CreateInstance(transformAttribute.Type, arguments)!;

        property.SetValue(record, selector.GetValue());
    }

    private void TransformCopyValue<T>(IOmopRecord<T> record, PropertyInfo property, Type sourceType,
        CopyValueAttribute copyValueAttribute)
    {
        _logger.LogTrace("{0} found on property {1}", nameof(CopyValueAttribute), property.Name);

        object value = sourceType.GetProperty(copyValueAttribute.Value)!.GetValue(record.Source)!;

        property.SetValue(record, value);
    }
}