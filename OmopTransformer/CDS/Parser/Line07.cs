namespace OmopTransformer.CDS.Parser;

internal class Line07 : ICdsFrame
{
    public Line07(string sourceText)
    {
        SourceText = sourceText ?? throw new ArgumentNullException(nameof(sourceText));
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? CriticalCareCount { get; init; }
    public string? LineCount { get; init; }
    public string? ActivityDateCriticalCare { get; init; }
    public string? PersonWeight { get; init; }

    public List<string> CriticalCareActivityCodes { get; set; } = new();

    public List<string> HighCostDrugsOPCSCodes { get; set; } = new();
}