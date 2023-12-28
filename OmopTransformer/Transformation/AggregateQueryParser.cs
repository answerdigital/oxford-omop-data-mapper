using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

internal class AggregateQueryParser
{
    public static Query ParseAggregateQuery(string xml)
    {
        XmlSerializer serializer = new(typeof(Query));

        using TextReader reader = new StringReader(xml);

        var query = (Query)serializer.Deserialize(reader)!;

        if (query.Explanation == null)
            throw new InvalidDataException($"{nameof(query.Explanation)} is null");

        foreach (var explanation in query.Explanation.Explanations!)
        {
            if (explanation.ColumnName == null)
                throw new InvalidDataException($"{nameof(explanation.ColumnName)} is null");

            if (explanation.Text == null)
                throw new InvalidDataException($"{nameof(explanation.ColumnName)} is null");
        }

        return query;
    }
}