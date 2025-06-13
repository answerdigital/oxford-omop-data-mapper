using Microsoft.Extensions.Logging;
using OmopTransformer.Annotations;
using OmopTransformer.Omop;
using System.Linq;
using System.Reflection;

namespace OmopTransformer.Transformation;

internal class RecordTransformer : IRecordTransformer
{
    private readonly ILogger<RecordTransformer> _logger;
    private readonly Opcs4Resolver _opcs4Resolver;
    private readonly ConceptResolver _resolver;
    private readonly Icdo3Resolver _icdo3Resolver;
    private readonly MeasurementMapsToValueResolver _relationshipResolver;
    private readonly Icd10NonStandardResolver _icd10NonStandardResolver;
    private readonly Icd10StandardResolver _icd10StandardResolver;
    private readonly RecordTransformLookupLogger _recordTransformLookupLogger = new();

    public RecordTransformer(
        ILogger<RecordTransformer> logger, 
        ConceptResolver resolver, 
        Opcs4Resolver opcs4Resolver, 
        Icdo3Resolver icdo3Resolver,
        MeasurementMapsToValueResolver relationshipResolver, 
        Icd10NonStandardResolver icd10NonStandardResolver,
        Icd10StandardResolver icd10StandardResolver)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _resolver = resolver;
        _opcs4Resolver = opcs4Resolver;
        _icdo3Resolver = icdo3Resolver;
        _relationshipResolver = relationshipResolver;
        _icd10NonStandardResolver = icd10NonStandardResolver;
        _icd10StandardResolver = icd10StandardResolver;
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

    public void PrintLogsAndResetLogger(ILoggerFactory loggerFactory)
    {
        _recordTransformLookupLogger.PrintLog(loggerFactory);
        _recordTransformLookupLogger.Reset();
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

        string argument = GetLookupKey(arguments) ?? "";
        
        if (lookup.Mappings.TryGetValue(argument, out var value))
        {
            if (value.Value != "")
                SetValue(record, property, value.Value);

            _recordTransformLookupLogger.Hit(lookup);
        }
        else
        {
            _recordTransformLookupLogger.Miss(lookup, argument);
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
                .Concat(firstConstructorTypes.Any(type => type == typeof(Opcs4Resolver)) ? new[] { _opcs4Resolver } : new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(Icdo3Resolver)) ? new[] { _icdo3Resolver } : new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(ConceptResolver)) ? new[] { _resolver } : new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(Icd10NonStandardResolver)) ? new [] { _icd10NonStandardResolver } :  new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(Icd10StandardResolver)) ? new[] { _icd10StandardResolver } :  new List<object>())
                .Concat(firstConstructorTypes.Any(type => type == typeof(MeasurementMapsToValueResolver)) ? new[] { _relationshipResolver } : new List<object>())
                .ToArray();

        ISelector? selector;
        try
        {
            selector = (ISelector)Activator.CreateInstance(transformAttribute.Type, arguments)!;
        }
        catch (MissingMethodException missingMethod)
        {
            throw new InvalidOperationException("Please ensure the type for the concept ID matches the constructor", missingMethod);
        }

        object? value = selector.GetValue();

        SetValue(record, property, value);
    }

    private void TransformCopyValue<T>(IOmopRecord<T> record, PropertyInfo property, Type sourceType, CopyValueAttribute copyValueAttribute)
    {
        _logger.LogTrace("{0} found on property {1}", nameof(CopyValueAttribute), property.Name);

        object? value = sourceType.GetProperty(copyValueAttribute.Value)!.GetValue(record.Source);

        SetValue(record, property, value);
    }

    private void TransformConstantValue<T>(IOmopRecord<T> record, PropertyInfo property, ConstantValueAttribute constantValueAttribute)
    {
        _logger.LogTrace("Setting constant value. {0} found on property {1}", nameof(ConstantValueAttribute), property.Name);

        SetValue(record, property, constantValueAttribute.Value);
    }

    private static void SetValue<T>(IOmopRecord<T> record, PropertyInfo property, object? value)
    {
        if (value == null)
            return;

        // If the types match, just copy the value.
        if (property.PropertyType == value.GetType() || Nullable.GetUnderlyingType(property.PropertyType) == value.GetType())
        {
            property.SetValue(record, value);
            return;
        }

        // If the target type is a collection, create an array of one item.
        if (property.PropertyType.IsArray)
        {
            if (property.PropertyType.GetElementType() == typeof(int))
            {
                property.SetValue(record, new int[] { (int)value });
                return;
            }
        }
        else
        {
            if (property.PropertyType == typeof(string))
            {
                // Convert our int to a string and set the property.
                if (value is int)
                {
                    property.SetValue(record, value.ToString());
                    return;
                }
            }

            if (property.PropertyType == typeof(int) || property.PropertyType == typeof(int?))
            {
                // Convert our string to a int and set the property.
                if (value is string s)
                {
                    property.SetValue(record, int.Parse(s));
                    return;
                }
            }
        }

        throw new NotSupportedException($"Cannot set value of type {value.GetType()} to property of type {property.PropertyType}");
    }
}