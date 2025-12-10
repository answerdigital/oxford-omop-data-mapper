using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Observation.ProcedureObservation;

[DataOrigin("SUS")]
[Description("SUS Outpatient Procedure Observation")]
[SourceQuery("SusOPProcedureObservation.xml")]
internal class SusOPProcedureObservationRecord
{
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? AppointmentDate { get; set; }
    public string? AppointmentTime { get; set; }
    public string? PrimaryProcedure { get; set; }
}