using OmopTransformer.Annotations;
using OmopTransformer.COSD.Demographics;
using OmopTransformer.Transformation;

namespace OmopTransformer.Omop.COSD;

internal class CosdLocation : OmopLocation<CosdDemographics>
{
    [CopyValue(nameof(Source.StreetAddressLine1))]
    public override string? address_1 { get; set; }

    [CopyValue(nameof(Source.StreetAddressLine2))]
    public override string? address_2 { get; set; }

    [CopyValue(nameof(Source.StreetAddressLine3))]
    public override string? city { get; set; }

    [CopyValue(nameof(Source.StreetAddressLine4))]
    public override string? county { get; set; }

    [CopyValue(nameof(Source.PostcodeOfUsualAddressAtDiagnosis))]
    public override string? zip { get; set; }

    [Transform(
        typeof(TextDeliminator), 
        nameof(Source.StreetAddressLine1),
        nameof(Source.StreetAddressLine2),
        nameof(Source.StreetAddressLine3),
        nameof(Source.StreetAddressLine4),
        nameof(Source.PostcodeOfUsualAddressAtDiagnosis))]
    public override string? location_source_value { get; set; }
}