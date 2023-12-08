namespace OmopTransformer.CDS.Parser;

internal class Message
{
    public Message(Guid messageId)
    {
        MessageId = messageId;
    }

    public Guid MessageId { get; }
    public Line01? Line01 { get; set; }
    public List<Line02> Line02 { get; set; } = new();
    public List<Line03> Line03 { get; set; } = new();
    public List<Line04> Line04 { get; set; } = new();
    public List<Line05> Line05 { get; set; } = new();
    public List<Line06> Line06 { get; set; } = new();
    public List<Line07> Line07 { get; set; } = new();
    public List<Line08> Line08 { get; set; } = new();
    public List<Line09> Line09 { get; set; } = new();
    public List<Line10> Line10 { get; set; } = new();
    public List<Line11> Line11 { get; set; } = new();
    public List<Line12> Line12 { get; set; } = new();
}