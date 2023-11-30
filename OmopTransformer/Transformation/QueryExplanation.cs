using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

public class QueryExplanation
{
    [XmlElement("OmopColumnExplanation")]
    public QueryColumnExplanation[]? Explanations { get; set; }
}