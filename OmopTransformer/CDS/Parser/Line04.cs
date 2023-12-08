namespace OmopTransformer.CDS.Parser;

internal class Line04 : ICdsFrame
{
    public Line04(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? LineCount { get; init; }
    public string? LocationClass { get; init; }
    public string? SiteCodeofTreatment { get; init; }
    public string? ActivityLocationType { get; init; }
    public string? IntendedClinicalCareIntensityCode { get; init; }
    public string? AgeGroupIntended { get; init; }
    public string? SexofPatientsCode { get; init; }
    public string? WardNightPeriodAvailabilityCode { get; init; }
    public string? WardDayPeriodAvailabilityCode { get; init; }
    public string? StartDateWardStay { get; init; }
    public string? StartTimeWardStay { get; init; }
    public string? EndDateWardStay { get; init; }
    public string? EndTimeWardStay { get; init; }
    public string? WardSecurityLevel { get; init; }
    public string? WardCode { get; init; }
    public string? ClinicCode { get; init; }
    public string? DetainedandorLongTermPsychiatricCensusDate { get; init; }
}