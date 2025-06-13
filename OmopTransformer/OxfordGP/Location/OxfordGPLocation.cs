using OmopTransformer.Annotations;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordGP.Location;

internal class OxfordGPLocation : OmopLocation<OxfordGPLocationRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(PostcodeFormatter), nameof(Source.Postcode))]
    public override string? zip { get; set; }

    [CopyValue(nameof(Source.Postcode))]
    public override string? location_source_value { get; set; }
}