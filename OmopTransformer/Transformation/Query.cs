using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

[XmlRoot("Query")]
public class Query
{
    [XmlElement("Sql")]
    public SqlElement? Sql { get; set; }

    [XmlElement("Explanations")]
    public QueryExplanation? Explanation { get; set; }
}