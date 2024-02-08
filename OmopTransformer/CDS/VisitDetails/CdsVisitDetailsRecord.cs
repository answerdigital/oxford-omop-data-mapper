using OmopTransformer.Annotations;

namespace OmopTransformer.CDS.VisitDetails;

[Description("CDS VisitDetails")]
[SourceQuery("CdsVisitDetails.xml")]
internal class CdsVisitDetailsRecord
{
    public string? NHSNumber { get; set; }
    public string? RecordConnectionIdentifier { get; set; }
    public int? HospitalProviderSpellNumber { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
    public int? VisitOccurenceConceptId { get; set; }
    public int? VisitTypeConceptId { get; set; }
}