using OmopTransformer.Annotations;

namespace OmopTransformer.OxfordGP.VisitDetail;

[DataOrigin("Oxford-GP")]
[Description("Oxford Visit Details")]
[SourceQuery("OxfordGPVisitDetail.xml")]
internal class OxfordGPVisitDetailRecord
{
    public string? GPEventsPrimaryKey { get; set; }
    public string? NHSNumber { get; set; }
    public string? EventDate { get; set; }
}