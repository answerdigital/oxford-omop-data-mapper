using OmopTransformer.Annotations;
using OmopTransformer.CDS.StructuredAddress;
using OmopTransformer.Omop.Location;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS;

internal class CdsStructuredLocation : OmopLocation<CdsStructuredAddress>
{
    [Transform(
        typeof(TextDeliminator),
        nameof(Source.PatientAddressStructured1),
        nameof(Source.PatientAddressStructured2))]
    public override string? address_1 { get; set; }

    [CopyValue(nameof(Source.PatientAddressStructured3))]
    public override string? address_2 { get; set; }

    [CopyValue(nameof(Source.PatientAddressStructured4))]
    public override string? city { get; set; }

    [CopyValue(nameof(Source.PatientAddressStructured5))]
    public override string? county { get; set; }

    [Transform(typeof(PostcodeFormatter), nameof(Source.Postcode))]
    public override string? zip { get; set; }

    [Transform(
        typeof(TextDeliminator),
        nameof(Source.PatientAddressStructured1),
        nameof(Source.PatientAddressStructured2),
        nameof(Source.PatientAddressStructured3),
        nameof(Source.PatientAddressStructured4),
        nameof(Source.PatientAddressStructured5),
        nameof(Source.Postcode))]
    public override string? location_source_value { get; set; }

    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }
}