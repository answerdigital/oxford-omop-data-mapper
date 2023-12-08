namespace OmopTransformer.CDS.Parser;

internal class OverseasVisitor
{
    private OverseasVisitor()
    {
    }

    public string? OverseasVisitorsClassification { get; set; }
    public string? OverseasVisitorsStatusStartDate { get; set; }
    public string? OverseasVisitorsStatusEndDate { get; set; }

    public static OverseasVisitor? FromText(string text)
    {
        if (text == null) throw new ArgumentNullException(nameof(text));

        if (text.IsEmpty())
            return null;

        var overseasVisitor = new OverseasVisitor();

        int index = 0;

        overseasVisitor.OverseasVisitorsClassification = text.SubstringOrNull(index, 1);
        index += 1;

        overseasVisitor.OverseasVisitorsStatusStartDate = text.SubstringOrNull(index, 8);
        index += 8;

        overseasVisitor.OverseasVisitorsStatusEndDate = text.SubstringOrNull(index, 8);

        return overseasVisitor;
    }
}