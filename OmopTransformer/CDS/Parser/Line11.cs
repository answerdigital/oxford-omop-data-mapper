namespace OmopTransformer.CDS.Parser;

internal class Line11 : ICdsFrame
{
    public Line11(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? AttendanceNumber { get; init; }
    public string? ArrivalModeCode { get; init; }
    public string? AttendanceCategoryCode { get; init; }
    public string? AttendanceDisposal { get; init; }
    public string? IncidentLocationType { get; init; }
    public string? PatientGroup { get; init; }
    public string? SourceofReferral { get; init; }
    public string? AEDepartmentType { get; init; }
    public string? ArrivalDate { get; init; }
    public string? ArrivalTime { get; init; }
    public string? AgeAtCDSActivityDate { get; init; }
    public string? OverseasVisitorStatusClassificationAtCDSActivityDate { get; init; }
    public string? InitialAssessmentDate { get; init; }
    public string? InitialAssessmentTime { get; init; }
    public string? DateSeenforTreatment { get; init; }
    public string? TimeSeenforTreatment { get; init; }
    public string? AttendanceConclusionDate { get; init; }
    public string? AttendanceConclusionTime { get; init; }
    public string? DepartureDate { get; init; }
    public string? DepartureTime { get; init; }
    public string? AmbulanceIncidentNumber { get; init; }
    public string? OrganisationCodeConveyingAmbulanceTrust { get; init; }
    public string? AEStaffMemberCode { get; init; }
}