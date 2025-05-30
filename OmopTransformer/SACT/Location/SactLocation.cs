using OmopTransformer.Annotations;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.Location;

internal class SactLocation: OmopLocation<SactLocationRecord>
{
    [Transform(typeof(PostcodeFormatter), (nameof(Source.Patient_Postcode)))]
    public override string? zip { get; set; }

    [CopyValue(nameof(Source.Patient_Postcode))]
    public override string? location_source_value { get; set; }

    [CopyValue(nameof(Source.NHS_Number))]
    public override string? nhs_number { get; set; }
}