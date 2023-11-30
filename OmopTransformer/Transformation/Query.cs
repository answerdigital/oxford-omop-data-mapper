using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

[XmlRoot("Query")]
public class Query
{
    public string? Sql { get; set; }

    [XmlElement("Explanation")]
    public QueryExplanation? Explanation { get; set; }
}