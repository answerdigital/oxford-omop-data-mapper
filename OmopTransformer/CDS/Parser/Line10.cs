namespace OmopTransformer.CDS.Parser;

internal class Line10 : ICdsFrame
{
    public Line10(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? EALAdmissionEntryNumber { get; init; }
    public string? AdministrativeCategoryCode { get; init; }
    public string? CountofDaysSuspended { get; init; }
    public string? ElectiveAdmissionListStatus { get; init; }
    public string? ElectiveAdmissionTypeCode { get; init; }
    public string? IntendedManagementCode { get; init; }
    public string? PriorityTypeCode { get; init; }
    public string? IntendedProcedureStatusCode { get; init; }
    public string? DecidedtoAdmitDate { get; init; }
    public string? AgeAtCDSActivityDate { get; init; }
    public string? OverseasVisitorStatusClassificationAtCDSActivityDate { get; init; }
    public string? GuaranteedAdmissionDate { get; init; }
    public string? LastDNAorCancelledDate { get; init; }
    public string? WaitingListEntryLastReviewedDate { get; init; }
    public string? AdmissionOfferOutcome { get; init; }
    public string? OfferedforAdmissionDate { get; init; }
    public string? EarliestReasonableOfferDate { get; init; }
    public string? OriginalDecidedtoAdmitDate { get; init; }
    public string? RemovalReasonCode { get; init; }
    public string? RemovalDate { get; init; }
    public string? SuspensionStartDate { get; init; }
    public string? SuspensionEndDate { get; init; }
}