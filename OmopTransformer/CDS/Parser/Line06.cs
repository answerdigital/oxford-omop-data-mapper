namespace OmopTransformer.CDS.Parser;

internal class Line06 : ICdsFrame
{
    public Line06(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? LineCount { get; init; }
    public string? CriticalCareTypeID { get; init; }
    public string? CriticalCareLocalIdentifier { get; init; }
    public string? CriticalCareStartDate { get; init; }
    public string? CriticalCareStartTime { get; init; }
    public string? CriticalCareUnitFunction { get; init; }
    public string? GestationLengthAtDelivery { get; init; }
    public string? UnitBedConfiguration { get; init; }
    public string? CriticalCareAdmissionSource { get; init; }
    public string? CriticalCareSourceLocation { get; init; }
    public string? CriticalCareAdmissionType { get; init; }
    public string? AdvancedRespiratorySupportDays { get; init; }
    public string? BasicRespiratorySupportsDays { get; init; }
    public string? AdvancedCardiovascularSupportDays { get; init; }
    public string? BasicCardiovascularSupportDays { get; init; }
    public string? RenalSupportDays { get; init; }
    public string? NeurologicalSupportDays { get; init; }
    public string? GastroIntestinalSupportDays { get; init; }
    public string? DermatologicalSupportDays { get; init; }
    public string? LiverSupportDays { get; init; }
    public string? OrganSupportMaximum { get; init; }
    public string? CriticalCareLevel2Days { get; init; }
    public string? CriticalCareLevel3Days { get; init; }
    public string? CriticalCareDischargeDate { get; init; }
    public string? CriticalCareDischargeTime { get; init; }
    public string? CriticalCareDischargeReadyDate { get; init; }
    public string? CriticalCareDischargeReadyTime { get; init; }
    public string? CriticalCareDischargeStatus { get; init; }
    public string? CriticalCareDischargeDestination { get; init; }
    public string? CriticalCareDischargeLocation { get; init; }
}