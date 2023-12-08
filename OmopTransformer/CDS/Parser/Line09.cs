namespace OmopTransformer.CDS.Parser;

internal class Line09 : ICdsFrame
{
    public Line09(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? AttendanceIdentifier { get; init; }
    public string? AdministrativeCategoryCode { get; init; }
    public string? AttendedOrDidNotAttendCode { get; init; }
    public string? FirstAttendanceCode { get; init; }
    public string? MedicalStaffTypeSeeingPatient { get; init; }
    public string? OperationStatusCode { get; init; }
    public string? OutcomeofAttendanceCode { get; init; }
    public string? AppointmentDate { get; init; }
    public string? AppointmentTime { get; init; }
    public string? ExpectedDurationOfAppointment { get; init; }
    public string? AgeAtCDSActivityDate { get; init; }
    public string? OverseasVisitorStatusClassificationAtCDSActivityDate { get; init; }
    public string? EarliestReasonableOfferDate { get; init; }
    public string? EarliestClinicallyAppropriateDate { get; init; }
    public string? ConsultationMediumUsed { get; init; }
    public string? MultiProfessionalorMultidisciplinaryConsultationIndicationCode { get; init; }
    public string? RehabilitationAssessmentTeamType { get; init; }
    public string? PriorityTypeCode { get; init; }
    public string? ServiceTypeRequestedCode { get; init; }
    public string? SourceofReferralforOutpatients { get; init; }
    public string? ReferralRequestReceivedDate { get; init; }
    public string? LastDNAorPatientCancelledDate { get; init; }
}