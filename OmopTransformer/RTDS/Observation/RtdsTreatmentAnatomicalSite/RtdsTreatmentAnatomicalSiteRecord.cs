using OmopTransformer.Annotations;

namespace OmopTransformer.RTDS.Observation;

[DataOrigin("RTDS")]
[Description("RTDS Treatment Anatomical Site")]
[SourceQuery("RtdsTreatmentAnatomicalSite.xml")]
internal class RtdsTreatmentAnatomicalSiteRecord
{
    public string? NHSNumber { get; set; }
    public string? AttributeValue { get; set; }
    public string? AnatomicalSiteConceptId { get; set; }
    public string? DueDateTime { get; set; }
}