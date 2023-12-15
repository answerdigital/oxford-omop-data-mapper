namespace OmopTransformer.CDS.Parser;

internal class Line12 : ICdsFrame
{
    public Line12(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? LineCount { get; init; }
    public string? InvestigationSchemeinUse { get; init; }

    public string? PrimaryInvestigation { get; set; }

    public List<string> SecondaryInvestigations { get; set; } = new();
}