using System.Reflection;
using Microsoft.Extensions.Logging;
using OmopTransformer.Annotations;
using OmopTransformer.Omop;

namespace OmopTransformer.Transformation;

internal class RecordTransformer : IRecordTransformer
{
    private readonly ILogger<RecordTransformer> _logger;
    private readonly Icd10Resolver _cd10Resolver;
    private readonly Opcs4Resolver _opcs4Resolver;
    private readonly ConceptResolver _resolver;
    private readonly Icdo3Resolver _icdo3Resolver;
    private readonly MeasurementMapsToValueResolver _relationshipResolver;

    public RecordTransformer(
        ILogger<RecordTransformer> logger, 
        Icd10Resolver cd10Resolver, 
        ConceptResolver resolver, 
        Opcs4Resolver opcs4Resolver, 
        Icdo3Resolver icdo3Resolver,
        MeasurementMapsToValueResolver relationshipResolver)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _cd10Resolver = cd10Resolver;
        _resolver = resolver;
        _opcs4Resolver = opcs4Resolver;
        _icdo3Resolver = icdo3Resolver;
        _relationshipResolver = relationshipResolver;
    }

    public void Transform<T>(IOmopRecord<T> record)
    {
        if (record == null) throw new ArgumentNullException(nameof(record));

        Type sourceType = record.Source!.GetType();

        var properties = record.GetType().GetProperties();

        _logger.LogTrace("Transforming {0}.", record.GetType());

        TransformProperties(record, properties, sourceType, sourceTypeAsOrigin: false); // First run the transformations that refer to the source data from the database.
        TransformProperties(record, properties, sourceType, sourceTypeAsOrigin: true); // Then run transforms that use the results of the previous transformations, by referring to the content of the partially transformed record rather than the incoming database record.
    }

    private void TransformProperties<T>(IOmopRecord<T> record, PropertyInfo[] properties, Type sourceType, bool sourceTypeAsOrigin)
    {
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
                    Transform(record, transformAttribute, property, sourceType, sourceTypeAsOrigin);
                }
                else if (attribute is ConstantValueAttribute constantValueAttribute)
                {
                    TransformConstantValue(record, property, constantValueAttribute);
                }
            }
        }
    }

    private void Transform<T>(IOmopRecord<T> record, TransformAttribute transformAttribute, PropertyInfo property, Type sourceType, bool sourceTypeAsOrigin)
    {
        if (transformAttribute.UseOmopTypeAsSource != sourceTypeAsOrigin)
            return;

        if (typeof(ISelector).IsAssignableFrom(transformAttribute.Type))
        {
            TransformSelector(record, transformAttribute, property, sourceType, sourceTypeAsOrigin);
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
    
    private static string? GetLookupKey(object?[] arguments)
    {
        var firstArgument = arguments[0];

        if (firstArgument == null)
            return null;

        if (firstArgument is string argument)
            return argument;

        if (firstArgument is int nullableInt)
            return nullableInt.ToString();

        throw new NotSupportedException("Argument type not supported.");
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

        string? argument = GetLookupKey(arguments);

        if (argument == null)
            return;
        
        if (lookup.Mappings.TryGetValue(argument, out var value))
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
    
    private void TransformSelector<T>(IOmopRecord<T> record, TransformAttribute transformAttribute, PropertyInfo property, Type sourceType, bool sourceTypeAsOrigin)
    {
        _logger.LogTrace("Selector transform found on property {0}", property.Name);

        var firstConstructorTypes = 
            transformAttribute
                .Type
                .GetConstructors()
                .First()
                .GetParameters()
                .Select(parameters => parameters.ParameterType)
                .ToList();

        Type originType = sourceTypeAsOrigin ? record.GetType() : sourceType;
        object originData = sourceTypeAsOrigin ? record : record.Source!;

        var arguments =
            transformAttribute
                .Value
                .Select(argumentName => originType.GetProperty(argumentName)!.GetValue(originData))
                .Concat(firstConstructorTypes.Any(type => type == typeof(Icd10Resolver)) ? new[] { _cd10Resolver } : new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(Opcs4Resolver)) ? new[] { _opcs4Resolver } : new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(Icdo3Resolver)) ? new[] { _icdo3Resolver } : new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(ConceptResolver)) ? new[] { _resolver } : new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(MeasurementMapsToValueResolver)) ? new[] { _relationshipResolver } : new List<object>())
                .ToArray();

        var selector = (ISelector)Activator.CreateInstance(transformAttribute.Type, arguments)!;

        object? value = selector.GetValue();

        if (value != null)
        {
            if (property.PropertyType == value.GetType() || Nullable.GetUnderlyingType(property.PropertyType) == value.GetType())
            {
                property.SetValue(record, value);
            }
            else
            {
                if (property.PropertyType.IsArray)
                {
                    if (property.PropertyType.GetElementType() == typeof(int))
                    {
                        property.SetValue(record, new int[] { (int)value });
                    }
                }
                else
                {
                    throw new NotSupportedException($"Cannot set value of type {value.GetType()} to property of type {property.PropertyType}");
                }
            }
        }
    }

    private void TransformCopyValue<T>(IOmopRecord<T> record, PropertyInfo property, Type sourceType, CopyValueAttribute copyValueAttribute)
    {
        _logger.LogTrace("{0} found on property {1}", nameof(CopyValueAttribute), property.Name);

        object? value = sourceType.GetProperty(copyValueAttribute.Value)!.GetValue(record.Source);

        if (value == null)
            return;

        if (property.PropertyType == typeof(string))
        {
            if (value is string)
            {
                property.SetValue(record, value);
                return;
            }

            if (value is int)
            {
                property.SetValue(record, value.ToString());
                return;
            }
        }

        if (property.PropertyType == typeof(int) || property.PropertyType == typeof(int?))
        {
            if (value is int)
            {
                property.SetValue(record, value);
                return;
            }
        }

        if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
        {
            if (value is DateTime)
            {
                property.SetValue(record, value);
                return;
            }
        }

        throw new NotSupportedException($"Cannot set value of type {value.GetType()} to property of type {property.PropertyType}");
    }

    private void TransformConstantValue<T>(IOmopRecord<T> record, PropertyInfo property, ConstantValueAttribute constantValueAttribute)
    {
        _logger.LogTrace("Setting constant value. {0} found on property {1}", nameof(ConstantValueAttribute), property.Name);

        property.SetValue(record, constantValueAttribute.Value);
    }
}