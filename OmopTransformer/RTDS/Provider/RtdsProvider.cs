using OmopTransformer.Annotations;
using OmopTransformer.Omop.Provider;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS.Provider;

internal class RtdsProvider : OmopProvider<RtdsProviderRecord>
{
    [CopyValue(nameof(Source.DoctorId))]
    public override string? provider_name { get; set; }

    [CopyValue(nameof(Source.DoctorId))]
    public override string? provider_source_value { get; set; }
}