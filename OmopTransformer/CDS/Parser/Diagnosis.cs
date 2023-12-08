namespace OmopTransformer.CDS.Parser;

internal class Diagnosis
{
    private Diagnosis()
    {
    }

    public string? DiagnosisCode { get; init; }
    public string? PresentOnAdmissionIndicator { get; init; }

    public static Diagnosis? FromText(string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));

        if (text.IsEmpty())
            return null;

        return
            new Diagnosis
            {
                DiagnosisCode = text.SubstringOrNull(0, 6),
                PresentOnAdmissionIndicator = text.SubstringOrNull(0 + 6, 1)
            };
    }
}