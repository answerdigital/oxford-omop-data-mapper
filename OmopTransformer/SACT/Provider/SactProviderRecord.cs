using OmopTransformer.Annotations;

namespace OmopTransformer.SACT.Provider;

[DataOrigin("SACT")]
[Description("SACT Provider")]
[SourceQuery("SactProvider.xml")]
internal class SactProviderRecord
{
    public string? Consultant_GMC_Code { get; set; }
    public string? Consultant_Specialty_Code { get; set; }
}