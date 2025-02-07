namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

internal class CCMDSRow
{
    public Guid MessageId { get; init; }
    public string? GeneratedRecordID { get; set; }
    public string? LoadStagingDate { get; set; }
    public string? CriticalCarePeriodSequenceNumber { get; set; }
    public string? CDSVersionontheepisodes { get; set; }
    public string? HESEPITYPEoftheepisode { get; set; }
    public string? CDSInterchangeID { get; set; }
    public string? HESEPISTAToftheepisode { get; set; }
    public string? EventDate { get; set; }
    public string? ActivityDateCriticalCare { get; set; }
    public string? CriticalCarePeriodType { get; set; }
    public string? CriticalCareEpisodeRelationship { get; set; }
    public string? CriticalCareUnitFunction { get; set; }
    public string? CriticalCareStartDate { get; set; }
    public string? CriticalCareStartTime { get; set; }
    public string? CriticalCarePeriodDischargeDate { get; set; }
    public string? CriticalCarePeriodDischargeTime { get; set; }
    public string? CriticalCarePeriodLocalIdentifier { get; set; }
    public string? GestationLengthAtDelivery { get; set; }
    public string? CriticalCareSequenceNumberDerived { get; set; }
    public string? TotalnumberofCriticalCareActivitiesDerived { get; set; }
    public string? LastRecordforthisCriticalCarePeriodIndicatorDerived { get; set; }
    public string? CriticalCareActivitytoEpisodeRelationshipDerived { get; set; }
    public string? PersonWeight { get; set; }
}