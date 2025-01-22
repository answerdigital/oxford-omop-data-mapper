namespace OmopTransformer.SUS.Staging.AE;

public class SusAETreatment
{
    public Guid MessageId { get; init; }
    public string? AccidentAndEmergencyTreatment { get; init; }

    public bool IsEmpty => AccidentAndEmergencyTreatment == null;
}