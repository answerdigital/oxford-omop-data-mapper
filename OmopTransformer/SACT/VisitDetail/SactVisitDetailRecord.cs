using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.VisitDetail;

[DataOrigin("SACT")]
[Description("Sact VisitDetail")]
[SourceQuery("SactVisitDetail.xml")]
internal class SactVisitDetailRecord
{
    public string? NHS_Number { get; set; }
    public string? Administration_date { get; set; }
}