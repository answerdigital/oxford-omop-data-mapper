using OmopTransformer.Annotations;
using OmopTransformer.Omop.Provider;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.Provider;

internal class SusAPCProvider : OmopProvider<SusAPCProviderRecord>
{
    [CopyValue(nameof(Source.ConsultantCode))]
    public override string? provider_source_value { get; set; }

    [CopyValue(nameof(Source.MainSpecialtyCode))]
    public override string? specialty_source_value { get; set; }

    [Transform(typeof(NhsMainSpecialityCodeLookup), nameof(Source.MainSpecialtyCode))]
    public override int? specialty_concept_id { get; set; }
}