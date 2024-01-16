using OmopTransformer.Annotations;
using OmopTransformer.CDS.UnstructuredAddress;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS;

internal class CdsLocation : OmopLocation<CdsUnstructuredAddress>
{
    [Transform(typeof(PostcodeFormatter), nameof(Source.Postcode))]
    public override string? zip { get; set; }

    [CopyValue(nameof(Source.Postcode))]
    public override string? location_source_value { get; set; }
}