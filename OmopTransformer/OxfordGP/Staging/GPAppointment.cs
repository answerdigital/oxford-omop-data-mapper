namespace OmopTransformer.OxfordGP.Staging;

internal class GPAppointment
{
    public string? GPAppointmentsPrimaryKey { get; set; }
    public string? PatientIdentifier { get; set; }
    public string? AppointmentDate { get; set; }
    public string? AppointmentStatus { get; set; }
    public string? AppointmentBookedDate { get; set; }
    public string? ClinicianCode { get; set; }
    public string? AppointmentCancelledDate { get; set; }
    public string? OrganisationName { get; set; }
    public string? SourceName { get; set; }
    public string? StatusDescription { get; set; }
    public string? DNAFlag { get; set; }
    public string? OrganisationNationalCode { get; set; }
    public string? ClinicianType { get; set; }
    public string? OrganisationIdentifier { get; set; }
    public string? Location { get; set; }
    public string? LocationType { get; set; }
    public string? Type { get; set; }
    public string? Specialty { get; set; }
    public string? ClinicName { get; set; }
    public string? BookingSource { get; set; }
    public string? BookingMethod { get; set; }
    public string? PatientArrivedDateTime { get; set; }
    public string? PatientSeenDateTime { get; set; }
    public string? DeliveryMethodText { get; set; }
    public string? PlannedMinutesDuration { get; set; }
    public string? ActualMinutesDuration { get; set; }
    public string? NationalSlotDesc { get; set; }
    public string? NationalSlotName { get; set; }
    public string? NationalContext { get; set; }
    public string? NationalService { get; set; }
    public string? UrgentFlag { get; set; }
    public string? FollowUp { get; set; }
    public string? ExternalPatient { get; set; }
    public string? ExternalPatientOrganisationIdentifierSystem { get; set; }
    public string? ExternalPatientOrganisationIdentifierValue { get; set; }
    public string? ExternalPatientOrganisationDisplay { get; set; }
    public string? CancellationReasonText { get; set; }
    public string? SessionIdentifierValue { get; set; }
    public string? ClinicianIdentifierValue { get; set; }
    public string? SlotEndDateTime { get; set; }
}