using OmopTransformer.Annotations;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.DemographicsV9;

internal class CosdLocationV9 : OmopLocation<CosdDemographicsV9>
{
    [Transform(typeof(UppercaseAndTrimWhitespace), nameof(Source.StreetAddressLine1))]
    public override string? address_1 { get; set; }

    [Transform(typeof(UppercaseAndTrimWhitespace), nameof(Source.StreetAddressLine2))]
    public override string? address_2 { get; set; }

    [Transform(typeof(UppercaseAndTrimWhitespace), nameof(Source.StreetAddressLine3))]
    public override string? city { get; set; }

    [Transform(typeof(UppercaseAndTrimWhitespace), nameof(Source.StreetAddressLine4))]
    public override string? county { get; set; }

    [Transform(typeof(PostcodeFormatter), nameof(Source.Postcode))]
    public override string? zip { get; set; }

    [Transform(
        typeof(TextDeliminator),
        nameof(Source.StreetAddressLine1),
        nameof(Source.StreetAddressLine2),
        nameof(Source.StreetAddressLine3),
        nameof(Source.StreetAddressLine4),
        nameof(Source.Postcode))]
    public override string? location_source_value { get; set; }

    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }
}