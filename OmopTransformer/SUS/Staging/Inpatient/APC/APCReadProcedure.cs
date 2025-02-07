namespace OmopTransformer.SUS.Staging.Inpatient.APC;

public class APCReadProcedure
{
    public Guid MessageId { get; init; }

    public string? ProcedureRead { get; init; }
    public string? ProcedureDateRead { get; init; }

    public bool? IsPrimaryProcedure { get; init; }

    public bool IsEmpty =>
        ProcedureRead == null &&
        ProcedureDateRead == null;
}