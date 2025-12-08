using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Observation.ProcedureObservations;

[DataOrigin("SUS")]
[Description("SUS APC Procedure Occurrence")]
[SourceQuery("SusAPCProcedureObservations.xml")]
internal class SusAPCProcedureObservationsRecord
{
    public string? GeneratedRecordIdentifier { get; set; }
    public string? NHSNumber { get; set; }
    public string? PrimaryProcedureDate { get; set; }
    public string? PrimaryProcedure { get; set; }
}