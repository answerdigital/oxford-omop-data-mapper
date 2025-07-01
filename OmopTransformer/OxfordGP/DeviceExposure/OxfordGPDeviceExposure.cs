using OmopTransformer.Annotations;
using OmopTransformer.Omop.DeviceExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordGP.DeviceExposure;

internal class OxfordGPDeviceExposure : OmopDeviceExposure<OxfordGPDeviceExposureRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(ConceptDeviceSelector), useOmopTypeAsSource: true, nameof(device_source_concept_id))]
    public override int[]? device_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? device_exposure_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? device_exposure_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? device_exposure_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.EventDate))]
    public override DateTime? device_exposure_end_datetime { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? device_type_concept_id { get; set; }

    [Transform(typeof(SnomedSelector), nameof(Source.SuppliedCode))]
    public override int? device_source_concept_id { get; set; }

    [CopyValue(nameof(Source.SuppliedCode))]
    public override string? device_source_value { get; set; }

}