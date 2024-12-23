using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.APC.Provider;

[DataOrigin("SUS")]
[Description("SUS Inpatient Provider")]
[SourceQuery("SusAPCProvider.xml")]
internal class SusAPCProviderRecord
{
    public string? ConsultantCode { get; set; }
    public string? MainSpecialtyCode { get; set; }
}