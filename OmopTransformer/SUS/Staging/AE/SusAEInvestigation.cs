namespace OmopTransformer.SUS.Staging.AE;

public class SusAEInvestigation
{
    public Guid MessageId { get; init; }
    public string? AccidentAndEmergencyInvestigation { get; init; }

    public bool IsEmpty => AccidentAndEmergencyInvestigation == null;
}