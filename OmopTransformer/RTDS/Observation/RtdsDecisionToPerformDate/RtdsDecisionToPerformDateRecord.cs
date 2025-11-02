using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Observation;

[DataOrigin("RTDS")]
[Description("RTDS Decision To Perform Date")]
[SourceQuery("RtdsDecisionToPerformDate.xml")]
internal class RtdsDecisionToPerformDateRecord
{
    public string? NhsNumber { get; set; }
    public string? DateStamp { get; set; }
}