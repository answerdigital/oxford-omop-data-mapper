using OmopTransformer.Annotations;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.AE.Location;

internal class SusAELocation : OmopLocation<SusAELocationRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(PostcodeFormatter), nameof(Source.Postcode))]
    public override string? zip { get; set; }

    [CopyValue(nameof(Source.Postcode))]
    public override string? location_source_value { get; set; }
}