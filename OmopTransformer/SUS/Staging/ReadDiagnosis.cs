namespace OmopTransformer.SUS.Staging;

public class ReadDiagnosis
{
    public Guid MessageId { get; init; }

    public string? DiagnosisRead { get; init; }

    public bool IsPrimaryDiagnosis { get; init; }

    public bool IsEmpty => DiagnosisRead == null;

}