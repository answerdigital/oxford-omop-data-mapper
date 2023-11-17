using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

public class AggregateQueryColumnExplanation
{
    [XmlAttribute("columName")]
    public string? ColumnName { get; set; }

    [XmlText]
    public string? Text { get; set; }
}
