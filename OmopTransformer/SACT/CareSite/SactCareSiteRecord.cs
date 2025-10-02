using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.CareSite;

[DataOrigin("SACT")]
[Description("SACT Inpatient Care Site")]
[SourceQuery("SactCareSite.xml")]
internal class SactCareSiteRecord
{
    public string? Organisation_Identifier_Code_Of_Provider { get; set; }
}