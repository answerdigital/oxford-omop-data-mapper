using System.Xml.Serialization;

namespace OmopTransformer.Transformation;

public class SqlElement
{
    [XmlAttribute("type")]
    public string? Type { get; set; }

    [XmlText]
    public string? Value { get; set; }
}