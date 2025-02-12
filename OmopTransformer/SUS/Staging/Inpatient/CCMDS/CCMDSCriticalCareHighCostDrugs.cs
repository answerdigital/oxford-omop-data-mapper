namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

public class CCMDSCriticalCareHighCostDrugs
{
    public Guid MessageId { get; init; }

    public string? CriticalCareHighCostDrugs { get; init; }

    public bool IsEmpty => CriticalCareHighCostDrugs == null;
}