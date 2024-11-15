namespace OmopTransformer.SUS.Staging;

public class CriticalCare
{
    public Guid MessageId { get; init; }

    public string? CriticalCareLocalIdentifier { get; init; }
    public string? CriticalCareStartDate { get; init; }
    public string? CriticalCareUnitFunction { get; init; }
    public string? AdvancedRespiratorySupportDays { get; init; }
    public string? BasicRespiratorySupportDays { get; init; }
    public string? AdvancedCardiovascularSupportDays { get; init; }
    public string? BasicCardiovascularSupportDays { get; init; }
    public string? RenalSupportDays { get; init; }
    public string? NeurologicalSupportDays { get; init; }
    public string? DermatologicalSupportDays { get; init; }
    public string? LiverSupportDays { get; init; }
    public string? CriticalCareLevel2Days { get; init; }
    public string? CriticalCareLevel3Days { get; init; }
    public string? CriticalCareDischargeDate { get; init; }
    public string? CriticalCareUnitBedConfiguration { get; init; }
    public string? CriticalCareAdmissionSource { get; init; }
    public string? CriticalCareSourceLocation { get; init; }
    public string? CriticalCareAdmissionType { get; init; }
    public string? GastroIntestinalSupportDays { get; init; }
    public string? OrganSupportMaximum { get; init; }
    public string? CriticalCareDischargeReadyDate { get; init; }
    public string? CriticalCareDischargeReadyTime { get; init; }
    public string? CriticalCareDischargeStatus { get; init; }
    public string? CriticalCareDischargeDestination { get; init; }
    public string? CriticalCareDischargeLocation { get; init; }
    public string? CriticalCareDischargeTime { get; init; }
    public string? CriticalCareActivityToEpisodeRelationshipDerived { get; init; }
    public string? CriticalCarePeriodSequenceNumber { get; init; }
    public string? CriticalCareStartTime { get; init; }
    public string? CriticalCarePeriodType { get; init; }

    public bool IsEmpty =>
        CriticalCareLocalIdentifier == null &&
        CriticalCareStartDate == null &&
        CriticalCareUnitFunction == null &&
        AdvancedRespiratorySupportDays == null &&
        BasicRespiratorySupportDays == null &&
        AdvancedCardiovascularSupportDays == null &&
        BasicCardiovascularSupportDays == null &&
        RenalSupportDays == null &&
        NeurologicalSupportDays == null &&
        DermatologicalSupportDays == null &&
        LiverSupportDays == null &&
        CriticalCareLevel2Days == null &&
        CriticalCareLevel3Days == null &&
        CriticalCareDischargeDate == null &&
        CriticalCareUnitBedConfiguration == null &&
        CriticalCareAdmissionSource == null &&
        CriticalCareSourceLocation == null &&
        CriticalCareAdmissionType == null &&
        GastroIntestinalSupportDays == null &&
        OrganSupportMaximum == null &&
        CriticalCareDischargeReadyDate == null &&
        CriticalCareDischargeReadyTime == null &&
        CriticalCareDischargeStatus == null &&
        CriticalCareDischargeDestination == null &&
        CriticalCareDischargeLocation == null &&
        CriticalCareDischargeTime == null &&
        CriticalCareActivityToEpisodeRelationshipDerived == null &&
        CriticalCarePeriodSequenceNumber == null &&
        CriticalCareStartTime == null &&
        CriticalCarePeriodType == null;
}