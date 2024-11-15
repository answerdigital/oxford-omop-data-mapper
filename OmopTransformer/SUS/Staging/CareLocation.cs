namespace OmopTransformer.SUS.Staging;

public class CareLocation
{
    public Guid MessageId { get; init; }

    public string? WardCode { get; init; }
    public string? WardSecurityLevel { get; init; }
    public string? LocationClass { get; init; }
    public string? SiteCodeOfTreatment { get; init; }
    public string? OrganisationCodeTypeSiteCodeOfTreatment { get; init; }
    public string? IntendedClinicalCareIntensity { get; init; }
    public string? AgeGroupIntended { get; init; }
    public string? SexOfPatients { get; init; }
    public string? WardDayPeriodAvailability { get; init; }
    public string? WardNightPeriodAvailability { get; init; }
    public string? StartDate { get; init; }
    public string? StartTimeWardStay { get; init; }
    public string? EndDate { get; init; }
    public string? EndTimeWardStay { get; init; }

    public bool IsEmpty =>
        WardCode == null &&
        WardSecurityLevel == null &&
        LocationClass == null &&
        SiteCodeOfTreatment == null &&
        OrganisationCodeTypeSiteCodeOfTreatment == null &&
        IntendedClinicalCareIntensity == null &&
        AgeGroupIntended == null &&
        SexOfPatients == null &&
        WardDayPeriodAvailability == null &&
        WardNightPeriodAvailability == null &&
        StartDate == null &&
        StartTimeWardStay == null &&
        EndDate == null &&
        EndTimeWardStay == null;
}