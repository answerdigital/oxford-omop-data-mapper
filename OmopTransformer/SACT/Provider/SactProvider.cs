using OmopTransformer.Annotations;
using OmopTransformer.Omop.Provider;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.Provider;

internal class SactProvider : OmopProvider<SactProviderRecord>
{
    [CopyValue(nameof(Source.Consultant_GMC_Code))]
    public override string? provider_name { get; set; }

    [CopyValue(nameof(Source.Consultant_GMC_Code))]
    public override string? provider_source_value { get; set; }

    [CopyValue(nameof(Source.Consultant_Specialty_Code))]
    public override string? specialty_source_value { get; set; }

    [Transform(typeof(NhsMainSpecialityCodeLookup), nameof(Source.Consultant_Specialty_Code))]
    public override int? specialty_concept_id { get; set; }
}