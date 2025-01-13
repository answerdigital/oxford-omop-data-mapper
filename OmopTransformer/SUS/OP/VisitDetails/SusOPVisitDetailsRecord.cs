using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.VisitDetails;

[DataOrigin("SUS")]
[Description("Sus Inptatient VisitDetails")]
[SourceQuery("SusOPVisitDetails.xml")]
internal class SusOPVisitDetailsRecord
{
    public string? NHSNumber { get; set; }
    public string? GeneratedRecordIdentifier { get; set; }
    public int? HospitalProviderSpellNumber { get; set; }
    public string? VisitStartDate { get; set; }
    public string? VisitStartTime { get; set; }
    public string? VisitEndDate { get; set; }
    public string? VisitEndTime { get; set; }
    public int? VisitOccurrenceConceptId { get; set; }
    public int? VisitTypeConceptId { get; set; }
    public int? SourceOfAdmissionHospitalProviderSpell { get; set; }
    public int? DischargeDestinationHospitalProviderSpell { get; set; }
}