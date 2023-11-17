using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

[XmlRoot("Query")]
public class AggregateQuery
{
    public string? Sql { get; set; }

    [XmlElement("Explanation")]
    public AggregateQueryExplanation? Explanation { get; set; }
}