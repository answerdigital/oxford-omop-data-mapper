using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

public class QueryExplanation
{
    [XmlElement("Explanation")]
    public QueryColumnExplanation[]? Explanations { get; set; }
}