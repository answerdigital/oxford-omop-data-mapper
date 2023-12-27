using System;
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
                else if (attribute is TransformAttribute transformAttribute)
                {
                    Transform(record, transformAttribute, property, sourceType);
                }
                else if (attribute is ConstantValueAttribute constantValueAttribute)
                {
                    TransformConstantValue(record, property, constantValueAttribute);
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
        else if (typeof(ILookup).IsAssignableFrom(transformAttribute.Type))
        {
            TransformLookup(record, transformAttribute, property, sourceType);
        }
        else
        {
            throw new NotSupportedException($"Unknown transform action {transformAttribute.Value}.");
        }
    }
    
    private void TransformLookup<T>(IOmopRecord<T> record, TransformAttribute transformAttribute, PropertyInfo property, Type sourceType)
    {
        _logger.LogTrace("Lookup transform found on property {0}", property.Name);
        var lookup = (ILookup)Activator.CreateInstance(transformAttribute.Type)!;

        var arguments =
            transformAttribute
                .Value
                .Select(argumentName => sourceType.GetProperty(argumentName)!.GetValue(record.Source))
                .ToArray();
        
        if (arguments.Length != 1)
        {
            throw new InvalidOperationException("Lookup transform must have one argument specified.");
        }

        string? argument = (string?)arguments[0];

        if (argument == null)
            return;
        
        if (lookup.Mappings.TryGetValue(argument, out ValueWithNote? value))
        {
            if (property.PropertyType.IsGenericType && property.PropertyType.GetGenericTypeDefinition() == typeof(Nullable<>))
            {
                var type = property.PropertyType.GetGenericArguments()[0];

                if (type == typeof(int))
                {
                    if (int.TryParse(value.Value, out int number))
                    {
                        property.SetValue(record, number);
                    }
                }
                else
                {
                    throw new NotSupportedException("Unknown nullable mapping type");
                }
            }
            else
            {
                if (property.PropertyType == typeof(string))
                {
                    property.SetValue(record, value.Value);
                }
                else if (property.PropertyType == typeof(int))
                {
                    property.SetValue(record, int.Parse(value.Value));
                }
                else
                {
                    throw new NotSupportedException("Unknown nullable mapping type");
                }
            }
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

    private void TransformCopyValue<T>(IOmopRecord<T> record, PropertyInfo property, Type sourceType, CopyValueAttribute copyValueAttribute)
    {
        _logger.LogTrace("{0} found on property {1}", nameof(CopyValueAttribute), property.Name);

        object value = sourceType.GetProperty(copyValueAttribute.Value)!.GetValue(record.Source)!;

        property.SetValue(record, value);
    }

    private void TransformConstantValue<T>(IOmopRecord<T> record, PropertyInfo property, ConstantValueAttribute constantValueAttribute)
    {
        _logger.LogTrace("Setting constant value. {0} found on property {1}", nameof(ConstantValueAttribute), property.Name);

        property.SetValue(record, constantValueAttribute.Value);
    }
}