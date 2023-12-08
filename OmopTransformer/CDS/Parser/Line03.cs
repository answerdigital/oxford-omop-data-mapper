namespace OmopTransformer.CDS.Parser;

internal class Line03 : ICdsFrame
{
    public Line03(string sourceText)
    {
        SourceText = sourceText;
    }

    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? LineId { get; init; }
    public string? LineCount { get; init; }
    public string? ProcedureSchemeInUse { get; init; }

    public Procedure? PrimaryProcedure { get; set; }

    public List<Procedure>? SecondaryProcedures { get; set; }
}