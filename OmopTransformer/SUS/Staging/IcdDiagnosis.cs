namespace OmopTransformer.SUS.Staging;

internal class IcdDiagnosis
{
    public Guid MessageId { get; init; }

    public string? DiagnosisICD { get; init; }
    public string? PresentOnAdmissionIndicatorDiagnosis { get; init; }

    public bool IsPrimaryDiagnosis { get; init; }

    public bool IsEmpty => DiagnosisICD == null && PresentOnAdmissionIndicatorDiagnosis == null;
}