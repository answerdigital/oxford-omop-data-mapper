using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

internal class AggregateQueryParser
{
    public static Query ParseAggregateQuery(string xml)
    {
        XmlSerializer serializer = new(typeof(Query));

        using TextReader reader = new StringReader(xml);

        return (Query)serializer.Deserialize(reader)!;
    }
}