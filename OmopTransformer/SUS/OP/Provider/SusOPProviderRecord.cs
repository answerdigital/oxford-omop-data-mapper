using OmopTransformer.Annotations;

namespace OmopTransformer.SUS.OP.Provider;

[DataOrigin("SUS")]
[Description("SUS Outpatient Provider")]
[SourceQuery("SusOPProvider.xml")]
internal class SusOPProviderRecord
{
    public string? ConsultantCode { get; set; }
    public string? MainSpecialtyCode { get; set; }
}