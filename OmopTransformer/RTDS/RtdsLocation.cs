using OmopTransformer.Annotations;
using OmopTransformer.Omop.Location;
using OmopTransformer.RTDS.Demographics;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS;

internal class RtdsLocation : OmopLocation<RtdsPasLocation>
{
    [Transform(typeof(PostcodeFormatter), nameof(Source.Postcode))]
    public override string? zip { get; set; }

    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [CopyValue(nameof(Source.NhsNumber))]
    public override string? location_source_value { get; set; }
}