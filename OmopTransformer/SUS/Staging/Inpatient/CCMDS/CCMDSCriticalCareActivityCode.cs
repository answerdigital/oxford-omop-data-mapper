namespace OmopTransformer.SUS.Staging.Inpatient.CCMDS;

public class CCMDSCriticalCareActivityCode
{
    public Guid MessageId { get; init; }

    public string? CriticalCareActivityCode { get; init; }

    public bool IsEmpty => CriticalCareActivityCode == null;
}