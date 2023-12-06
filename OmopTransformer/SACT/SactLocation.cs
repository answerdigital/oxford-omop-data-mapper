using OmopTransformer.Annotations;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT;

internal class SactLocation: OmopLocation<Sact>
{
    [Transform(typeof(PostcodeFormatter), (nameof(Source.Patient_Postcode)))]
    public override string? zip { get; set; }

    [CopyValue(nameof(Source.Patient_Postcode))]
    public override string? location_source_value { get; set; }
}