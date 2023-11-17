using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

public class AggregateQueryExplanation
{
    [XmlElement("OmopColumnExplanation")]
    public AggregateQueryColumnExplanation[]? Explanations { get; set; }
}