using OmopTransformer.Annotations;
using OmopTransformer.Omop;
using OmopTransformer.Transformation;
using System.Reflection;
using System.Text;

namespace OmopTransformer.Documentation;

public class DocumentationRenderer
{
    private readonly IReadOnlyCollection<Type> _types;
    private readonly Dictionary<string, Query> _aggregateQueries;

    public DocumentationRenderer(IReadOnlyCollection<Type> types, Dictionary<string, Query> aggregateQueries)
    {
        _types = types;
        _aggregateQueries = aggregateQueries;
    }

    public string Render()
    {
        var typesImplementingIOmopRecord =
            _types
            .Where(type => GetAllInterfaces(type).Any(i => i == typeof(IOmopTarget)) && type is { IsInterface: false, IsAbstract: false })
            .ToList();

        var mapperByOmopTarget =
            typesImplementingIOmopRecord
                .Select(
                    mapperType =>
                    new
                    {
                        MapperType = mapperType,
                        OmopTarget = (IOmopTarget)Activator.CreateInstance(mapperType)!
                    })
                .GroupBy(target => target.OmopTarget.OmopTargetTypeDescription)
                .ToList();

        var stringBuilder = new StringBuilder();

        stringBuilder.AppendLine("`Automatically generated documentation`");
        stringBuilder.AppendLine();

        foreach (var omopTarget in mapperByOmopTarget)
        {
            stringBuilder.AppendLine($"# {omopTarget.Key}");

            foreach (var omopMappers in omopTarget)
            {
                var aggregateTransform = omopMappers.MapperType.GetCustomAttributes(typeof(AggregateTransformAttribute), inherit: false).FirstOrDefault();

                if (aggregateTransform == null)
                {
                    var sourceTypeInterface = GetAllInterfaces(omopMappers.MapperType).Single(i => i.Name == typeof(IOmopRecord<>).Name);

                    var sourceType = sourceTypeInterface.GetGenericArguments().Single();

                    foreach (var sourceDescription in sourceType.GetCustomAttributes(typeof(DescriptionAttribute), inherit: false))
                    {
                        stringBuilder.AppendLine($"## {((DescriptionAttribute)sourceDescription).Value}");
                    }

                    foreach (var property in omopMappers.MapperType.GetProperties())
                    {
                        RenderProperty(property, stringBuilder);
                    }
                }
                else
                {
                    string queryFileName = ((AggregateTransformAttribute)aggregateTransform).QueryFileName;

                    RenderAggregateTransform(queryFileName, stringBuilder);
                }
            }
        }

        return stringBuilder.ToString();
    }

    private void RenderAggregateTransform(string queryFileName, StringBuilder stringBuilder)
    {
        var query = _aggregateQueries[queryFileName];

        if (query.Explanation?.Explanations == null)
        {
            throw new InvalidOperationException("query.Explanation must be defined.");
        }

        foreach (var explanation in query.Explanation.Explanations)
        {
            stringBuilder.AppendLine($"### {explanation.ColumnName} column");

            stringBuilder.AppendLine($"* {explanation.Text}");
            stringBuilder.AppendLine();
            stringBuilder.AppendLine("```");

            var whitespace = new[] { ' ', '\r', '\n' };
            stringBuilder.AppendLine(query.Sql?.TrimStart(whitespace).TrimEnd(whitespace));
            stringBuilder.AppendLine("```");
            stringBuilder.AppendLine();
        }
    }

    private static void RenderProperty(PropertyInfo property, StringBuilder stringBuilder)
    {
        if (property.Name == "OmopTargetTypeDescription")
            return;

        var attributes = property.GetCustomAttributes(inherit: false);

        if (attributes.Any())
        {
            stringBuilder.AppendLine($"### {property.Name} column");
        }

        foreach (var attribute in attributes)
        {
            if (attribute is CopyValueAttribute copyValueAttribute)
            {
                stringBuilder.AppendLine($"Value copied from `{copyValueAttribute.Value}`");
            }

            if (attribute is DescriptionAttribute description)
            {
                stringBuilder.AppendLine(description.Value);
            }

            if (attribute is TransformAttribute transformAttribute)
            {
                RenderTransform(stringBuilder, transformAttribute);
            }
        }
    }

    private static void RenderTransform(StringBuilder stringBuilder, TransformAttribute transformAttribute)
    {
        foreach (var transformDescription in transformAttribute.Type.GetCustomAttributes(typeof(DescriptionAttribute)))
        {
            stringBuilder.AppendLine(FormatColumns(transformAttribute.Value));
            stringBuilder.AppendLine(((DescriptionAttribute)transformDescription).Value);
        }

        if (typeof(ILookup).IsAssignableFrom(transformAttribute.Type))
        {
            RenderLookupTransform(stringBuilder, transformAttribute);
        }
    }

    private static void RenderLookupTransform(StringBuilder stringBuilder, TransformAttribute transformAttribute)
    {
        stringBuilder.AppendLine();
        stringBuilder.AppendLine();
        stringBuilder.AppendLine("|before|after|notes|");
        stringBuilder.AppendLine("|------|-----|-----|");

        var lookup = (ILookup)Activator.CreateInstance(transformAttribute.Type)!;

        foreach (var mapping in lookup.Mappings)
        {
            stringBuilder.AppendLine($"|{mapping.Key}|{mapping.Value.Value}|{mapping.Value.Notes}|");
        }

        stringBuilder.AppendLine();

        if (lookup.ColumnNotes.Length > 0)
        {
            stringBuilder.AppendLine("Notes");

            foreach (string note in lookup.ColumnNotes)
            {
                stringBuilder.AppendLine($"* {note}");
            }
        }
    }

    private static string FormatColumns(IReadOnlyCollection<string> columns)
    {
        string plural = columns.Count == 1 ? "Source column " : "Source columns ";

        string joinedColumns = string.Join(", ", columns.Select(c => $"`{c}`"));

        return $"{plural} {joinedColumns}.";
    }

    private static IEnumerable<Type> GetAllInterfaces(Type type)
    {
        HashSet<Type> interfaces = new HashSet<Type>(type.GetInterfaces());

        // Get interfaces of the base type
        Type? baseType = type.BaseType;
        while (baseType != null)
        {
            interfaces.UnionWith(baseType.GetInterfaces());
            baseType = baseType.BaseType;
        }

        return interfaces;
    }
}