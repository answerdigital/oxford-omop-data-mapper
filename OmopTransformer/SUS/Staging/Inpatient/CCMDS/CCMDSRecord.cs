namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

internal class CCMDSRecord
{
    public CCMDSRecord(CCMDSRow CCMDSRow, IReadOnlyCollection<CCMDSCriticalCareActivityCode> activityCodes, IReadOnlyCollection<CCMDSCriticalCareHighCostDrugs> highCostDrugs)
    {
        Row = CCMDSRow;
        ActivityCodes = activityCodes;
        HighCostDrugs = highCostDrugs;
    }

    public CCMDSRow Row { get; init; }

    public IReadOnlyCollection<CCMDSCriticalCareActivityCode> ActivityCodes { get; init; }
    public IReadOnlyCollection<CCMDSCriticalCareHighCostDrugs> HighCostDrugs { get; init; }
}