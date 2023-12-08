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
    public string? CriticalCareActivityCode1 { get; init; }
    public string? CriticalCareActivityCode2 { get; init; }
    public string? CriticalCareActivityCode3 { get; init; }
    public string? CriticalCareActivityCode4 { get; init; }
    public string? CriticalCareActivityCode5 { get; init; }
    public string? CriticalCareActivityCode6 { get; init; }
    public string? CriticalCareActivityCode7 { get; init; }
    public string? CriticalCareActivityCode8 { get; init; }
    public string? CriticalCareActivityCode9 { get; init; }
    public string? CriticalCareActivityCode10 { get; init; }
    public string? CriticalCareActivityCode11 { get; init; }
    public string? CriticalCareActivityCode12 { get; init; }
    public string? CriticalCareActivityCode13 { get; init; }
    public string? CriticalCareActivityCode14 { get; init; }
    public string? CriticalCareActivityCode15 { get; init; }
    public string? CriticalCareActivityCode16 { get; init; }
    public string? CriticalCareActivityCode17 { get; init; }
    public string? CriticalCareActivityCode18 { get; init; }
    public string? CriticalCareActivityCode19 { get; init; }
    public string? CriticalCareActivityCode20 { get; init; }
    public string? HighCostDrugsOPCS1 { get; init; }
    public string? HighCostDrugsOPCS2 { get; init; }
    public string? HighCostDrugsOPCS3 { get; init; }
    public string? HighCostDrugsOPCS4 { get; init; }
    public string? HighCostDrugsOPCS5 { get; init; }
    public string? HighCostDrugsOPCS6 { get; init; }
    public string? HighCostDrugsOPCS7 { get; init; }
    public string? HighCostDrugsOPCS8 { get; init; }
    public string? HighCostDrugsOPCS9 { get; init; }
    public string? HighCostDrugsOPCS10 { get; init; }
    public string? HighCostDrugsOPCS11 { get; init; }
    public string? HighCostDrugsOPCS12 { get; init; }
    public string? HighCostDrugsOPCS13 { get; init; }
    public string? HighCostDrugsOPCS14 { get; init; }
    public string? HighCostDrugsOPCS15 { get; init; }
    public string? HighCostDrugsOPCS16 { get; init; }
    public string? HighCostDrugsOPCS17 { get; init; }
    public string? HighCostDrugsOPCS18 { get; init; }
    public string? HighCostDrugsOPCS19 { get; init; }
    public string? HighCostDrugsOPCS20 { get; init; }
}