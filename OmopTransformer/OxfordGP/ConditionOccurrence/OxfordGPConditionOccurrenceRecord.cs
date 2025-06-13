using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.ConditionOccurrence;

[DataOrigin("Oxford-GP")]
[Description("Oxford Condition Occurrence")]
[SourceQuery("OxfordGPConditionOccurrence.xml")]
internal class OxfordGPConditionOccurrenceRecord
{
    public string? SuppliedCode { get; set; }
    public string? NHSNumber { get; set; }
    public string? EventDate { get; set; }
}