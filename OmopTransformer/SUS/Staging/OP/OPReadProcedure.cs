namespace OmopTransformer.SUS.Staging.OP;

public class OPReadProcedure
{
    public Guid MessageId { get; init; }

    public string? ProcedureRead { get; init; }
    public bool? IsPrimaryProcedure { get; init; }

    public bool IsEmpty => ProcedureRead == null;
}