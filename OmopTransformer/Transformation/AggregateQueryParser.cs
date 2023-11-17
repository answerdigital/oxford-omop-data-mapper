using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

internal class AggregateQueryParser
{
    public static AggregateQuery ParseAggregateQuery(string xml)
    {
        XmlSerializer serializer = new(typeof(AggregateQuery));

        using TextReader reader = new StringReader(xml);

        return (AggregateQuery)serializer.Deserialize(reader);
    }
}