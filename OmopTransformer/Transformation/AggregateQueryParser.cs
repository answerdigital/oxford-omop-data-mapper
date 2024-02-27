﻿using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

internal class AggregateQueryParser
{
    public static Query ParseAggregateQuery(string xml, string fileName)
    {
        XmlSerializer serializer = new(typeof(Query));

        using TextReader reader = new StringReader(xml);

        var query = (Query)serializer.Deserialize(reader)!;

        if (query.Explanation == null)
            throw new InvalidDataException($"{fileName} {nameof(query.Explanation)} is null");

        foreach (var explanation in query.Explanation.Explanations!)
        {
            if (explanation.ColumnName == null)
                throw new InvalidDataException($"{fileName} {nameof(explanation.ColumnName)} is null");

            if (explanation.Description == null)
                throw new InvalidDataException($"{fileName} {nameof(explanation.ColumnName)} is null");
        }

        return query;
    }
}