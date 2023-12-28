using OmopTransformer.Annotations;
using OmopTransformer.Omop;
using OmopTransformer.Transformation;
using System.Reflection;
using System.Text;

namespace OmopTransformer.Documentation;

internal class DocumentationRenderer
{
    private readonly IReadOnlyCollection<Type> _types;
    private readonly IQueryLocator _queryLocator;

    public DocumentationRenderer(IReadOnlyCollection<Type> types, IQueryLocator queryLocator)
    {
        _types = types;
        _queryLocator = queryLocator;
    }

    public IEnumerable<Document> Render()
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

        var indexStringBuilder = new StringBuilder();

        indexStringBuilder.AppendLine("`Automatically generated documentation`");
        indexStringBuilder.AppendLine();

        foreach (var omopTarget in mapperByOmopTarget)
        {
            indexStringBuilder.AppendLine($"# {omopTarget.Key}");

            var mapperByProperty =
                omopTarget
                    .SelectMany(
                        mapper =>
                            mapper
                                .MapperType
                                .GetProperties()
                                .Select(
                                    property =>
                                        new
                                        {
                                            Property = property,
                                            Mapper = mapper
                                        }))
                    .GroupBy(property => property.Property.Name)
                    .OrderBy(name => name.Key);

            foreach (var propertyGroup in mapperByProperty)
            {
                if (!AnyPropertyHasDocumentationAttributes(propertyGroup.Select(m => m.Property)))
                    continue;

                var name = propertyGroup.First().Property.Name;

                var fileName = $"{omopTarget.Key}_{name}.md";
                
                indexStringBuilder.AppendLine($"* [{name}]({fileName})");

                var stringBuilder = new StringBuilder();
                
                foreach (var property in propertyGroup)
                {
                    RenderProperty(property.Mapper.MapperType, property.Property, stringBuilder);
                }

                yield return new Document(fileName, stringBuilder.ToString());
            }
        }

        yield return new Document("transformation-documentation.md", indexStringBuilder.ToString());
    }

    private static bool AnyPropertyHasDocumentationAttributes(IEnumerable<PropertyInfo> properties)
    {
        var knownDocumentationAttributes =
            new[]
            {
                nameof(TransformAttribute),
                nameof(DescriptionAttribute),
                nameof(CopyValueAttribute)
            };

        return
            properties
                .SelectMany(property => property.GetCustomAttributes(inherit: false))
                .Any(attribute => knownDocumentationAttributes.Contains(attribute.GetType().Name));
    }

    private void RenderProperty(Type mapperType, PropertyInfo property, StringBuilder stringBuilder)
    {
        if (property.Name == "OmopTargetTypeDescription")
            return;
        
        var attributes = property.GetCustomAttributes(inherit: false);

        if (attributes.Any())
        {
            var sourceType = GetOmopSourceType(mapperType);

            var description = sourceType.GetCustomAttributes(typeof(DescriptionAttribute)).FirstOrDefault();

            if (description != null)
            {
                stringBuilder.AppendLine($"### {((DescriptionAttribute)description).Value}");
            }
        }

        foreach (var attribute in attributes)
        {
            if (attribute is CopyValueAttribute copyValueAttribute)
            {
                stringBuilder.AppendLine($"* Value copied from `{copyValueAttribute.Value}`");
                RenderQueryIfAny(mapperType, stringBuilder, copyValueAttribute.Value);
            }

            if (attribute is DescriptionAttribute description)
            {
                stringBuilder.AppendLine(description.Value);
            }

            if (attribute is TransformAttribute transformAttribute)
            {
                RenderTransform(stringBuilder, transformAttribute);
                RenderQueryIfAny(mapperType, stringBuilder, transformAttribute.Value);
            }
        }
    }

    private static Type GetOmopSourceType(Type type)
    {
        var sourceTypeInterface = GetAllInterfaces(type).Single(i => i.Name == typeof(IOmopRecord<>).Name);

        return sourceTypeInterface.GetGenericArguments().Single();
    }

    private void RenderQueryIfAny(Type mapperType, StringBuilder stringBuilder, params string[] sourceColumns)
    {
        var sourceType = GetOmopSourceType(mapperType);

        var queryTransform = sourceType.GetCustomAttributes(typeof(SourceQueryAttribute), inherit: false).FirstOrDefault();

        if (queryTransform != null)
        {
            var query = _queryLocator.GetQuery(((SourceQueryAttribute)queryTransform).QueryFileName);

            bool anyMatches = false;

            foreach (var explanation in query.Explanation!.Explanations!)
            {
                if (!sourceColumns.Contains(explanation.ColumnName))
                    continue;

                anyMatches = true;

                stringBuilder.AppendLine($"* `{explanation.ColumnName}` {explanation.Text}");
            }

            if (anyMatches)
            {
                stringBuilder.AppendLine("<details>");
                stringBuilder.AppendLine("<summary>SQL</summary>");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine("```sql");
                var whitespace = new[] { ' ', '\r', '\n' };
                stringBuilder.AppendLine(query.Sql?.TrimStart(whitespace).TrimEnd(whitespace));
                stringBuilder.AppendLine("```");
                stringBuilder.AppendLine("</details>");
                stringBuilder.AppendLine();
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