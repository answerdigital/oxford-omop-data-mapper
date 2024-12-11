using OmopTransformer.Annotations;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.Location;

internal class SusAPCLocation : OmopLocation<SusAPCLocationRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(PostcodeFormatter), nameof(Source.Postcode))]
    public override string? zip { get; set; }

    [CopyValue(nameof(Source.Postcode))]
    public override string? location_source_value { get; set; }
}