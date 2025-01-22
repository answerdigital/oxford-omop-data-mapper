namespace OmopTransformer.SUS.Staging.AE;

public class SusAEDiagnosis
{
    public Guid MessageId { get; init; }
    public string? AccidentAndEmergencyDiagnosis { get; init; }

    public bool IsEmpty => AccidentAndEmergencyDiagnosis == null;
}