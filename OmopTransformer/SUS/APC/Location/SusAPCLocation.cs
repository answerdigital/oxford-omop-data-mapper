using OmopTransformer.Annotations;
using OmopTransformer.Omop.Location;

namespace OmopTransformer.SUS.APC.Location;

internal class SusAPCLocation : OmopLocation<SusAPCLocationRecord>
{
    [CopyValue(nameof(Source.Postcode))]
    public override string? location_source_value { get; set; }
}