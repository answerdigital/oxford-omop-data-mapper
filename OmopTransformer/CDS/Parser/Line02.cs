namespace OmopTransformer.CDS.Parser;

internal class Line02 : ICdsFrame
{
    public Line02(string sourceText)
    {
        if (string.IsNullOrEmpty(sourceText))
            throw new ArgumentException("Value cannot be null or empty.", nameof(sourceText));

        SourceText = sourceText;
    }

    public string? LineId { get; init; }
    public string? RecordConnectionIdentifier { get; init; }
    public string SourceText { get; }
    public string? LineCount { get; init; }
    public string? DiagnosisSchemeInUse { get; init; }

    public Diagnosis? PrimaryDiagnosis { get; set; }

    public List<Diagnosis> SecondaryDiagnoses { get; set; } = new();
}