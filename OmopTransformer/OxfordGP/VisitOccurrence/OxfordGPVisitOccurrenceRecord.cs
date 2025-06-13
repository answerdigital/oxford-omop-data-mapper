using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.VisitOccurrence;

[DataOrigin("Oxford-GP")]
[Description("Oxford Visit Occurrence")]
[SourceQuery("OxfordGPVisitOccurrence.xml")]
internal class OxfordGPVisitOccurrenceRecord
{
    public string? GPEventsPrimaryKey { get; set; }
    public string? NHSNumber { get; set; }
    public string? EventDate { get; set; }
}