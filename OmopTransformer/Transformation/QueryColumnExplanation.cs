using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

public class QueryColumnExplanation
{
    [XmlAttribute("columnName")]
    public string? ColumnName { get; set; }

    public string? Description { get; set; }

    [XmlElement("Origin")]
    public string[]? Origin { get; set; }
}
