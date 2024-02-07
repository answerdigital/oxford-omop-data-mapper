using OmopTransformer.Annotations;
using OmopTransformer.Omop;
using OmopTransformer.Transformation;
using System.Reflection;
using System.Text;
using OmopTransformer.Documentation.Charting;

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

        foreach (var diagram in RenderDiagrams(typesImplementingIOmopRecord))
            yield return diagram;

        var mapperByOmopTarget =
            typesImplementingIOmopRecord
                .Select(
                    mapperType =>
                    new
                    {
                        MapperType = mapperType,
                        OmopTargetDescription = OmopDescription(mapperType)
                    })
                .GroupBy(target => target.OmopTargetDescription)
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
                    .OrderBy(name => name.Key)
                    .ToList();

            foreach (var propertyGroup in mapperByProperty)
            {
                if (!AnyPropertyHasDocumentationAttributes(propertyGroup.Select(m => m.Property)))
                    continue;

                var name = propertyGroup.First().Property.Name;

                var fileName = $"{omopTarget.Key}_{name}.md";
                
                indexStringBuilder.AppendLine($"* [{name}]({fileName})");

                var stringBuilder = new StringBuilder();

                stringBuilder.AppendLine($"# `{omopTarget.Key}` `{name}`");
                
                foreach (var property in propertyGroup)
                {
                    RenderProperty(property.Mapper.MapperType, property.Property, stringBuilder, omopTarget.Key, name);
                }

                yield return new Document(fileName, stringBuilder.ToString());
            }

            foreach (var target in omopTarget)
            {
                indexStringBuilder.AppendLine($"## {target.MapperType.Name}");
                indexStringBuilder.AppendLine($"![]({target.MapperType.Name}.svg)");
                indexStringBuilder.AppendLine();
                indexStringBuilder.AppendLine($"[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title={target.MapperType.Name}%20mapping)");
            }
        }

        yield return new Document("transformation-documentation.md", indexStringBuilder.ToString());
    }

    private IEnumerable<Document> RenderDiagrams(IEnumerable<Type> omopTargets) =>
        omopTargets
            .Select(RenderDiagram);

    private static string OmopDescription(Type type) => ((IOmopTarget)Activator.CreateInstance(type)!).OmopTargetTypeDescription;

    private Document RenderDiagram(Type type)
    {
        var relationships = GetRelationships(type);

        var svgRenderer = new SvgRenderer(relationships);

        return new Document($"{type.Name}.svg", svgRenderer.Render());
    }

    private static List<Relationship> GetRelationships(Type type) =>
        type
            .GetProperties()
            .Where(PropertyHasDocumentationAttributes)
            .SelectMany(
                sourceMember => 
                    GetDocumentableAttributes(sourceMember)
                    .SelectMany(attribute => GetRelationship(attribute, sourceMember)))
            .ToList();

    private static IEnumerable<Relationship> GetRelationship(object attribute, PropertyInfo sourceMember)
    {
        if (attribute is CopyValueAttribute copyValueAttribute)
        {
            return new[] { new Relationship(source: copyValueAttribute.Value, target: sourceMember.Name, "Copy value.") }.ToList();
        }

        if (attribute is TransformAttribute transformAttribute)
        {
            var relationships = new List<Relationship>();

            var descriptionAttribute = transformAttribute.Type.GetCustomAttributes(typeof(DescriptionAttribute)).FirstOrDefault();

            string description = "";

            if (descriptionAttribute != null)
            {
                description = ((DescriptionAttribute)descriptionAttribute).Value;
            }

            foreach (var source in transformAttribute.Value)
            {
                relationships.Add(new Relationship(source: source, target: sourceMember.Name, description));
            }

            return relationships;
        }

        return new List<Relationship>();
    }

    private static IReadOnlyCollection<object> GetDocumentableAttributes(PropertyInfo property)
    {
        return
            new[]
            {
                typeof(TransformAttribute),
                typeof(DescriptionAttribute),
                typeof(CopyValueAttribute),
                typeof(ConstantValueAttribute)
            }
            .SelectMany(type => property.GetCustomAttributes(type, false))
            .ToList();
    }

    private static bool PropertyHasDocumentationAttributes(PropertyInfo property) => GetDocumentableAttributes(property).Any();

    private static bool AnyPropertyHasDocumentationAttributes(IEnumerable<PropertyInfo> properties) =>
        properties
            .Any(PropertyHasDocumentationAttributes);

    private static bool IgnoreProperty(PropertyInfo property) => property.Name is "OmopTargetTypeDescription" or "Source";

    private void RenderProperty(Type mapperType, PropertyInfo property, StringBuilder stringBuilder, string omopTable, string omopField)
    {
        if (IgnoreProperty(property))
            return;

        var attributes = GetDocumentableAttributes(property);

        string? title = null;

        if (attributes.Any())
        {
            var sourceType = GetOmopSourceType(mapperType);

            var description = sourceType.GetCustomAttributes(typeof(DescriptionAttribute)).FirstOrDefault();

            if (description != null)
            {
                title = ((DescriptionAttribute)description).Value;
                stringBuilder.AppendLine($"### {title}");
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

            if (attribute is ConstantValueAttribute constantValueAttribute)
            {
                stringBuilder.AppendLine($"* Constant value set to `{constantValueAttribute.Value}`. {constantValueAttribute.Description}");
            }

            if (attribute is TransformAttribute transformAttribute)
            {
                RenderTransform(stringBuilder, transformAttribute);
                RenderQueryIfAny(mapperType, stringBuilder, transformAttribute.Value);
            }
        }

        if (attributes.Any())
        {
            stringBuilder.AppendLine();
            stringBuilder.AppendLine($"[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20{omopTable}%20table%20{omopField}%20field%20{(title ?? "").Replace(" ", "%20")}%20mapping)");
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