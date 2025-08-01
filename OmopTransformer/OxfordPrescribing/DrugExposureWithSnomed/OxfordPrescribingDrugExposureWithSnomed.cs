using OmopTransformer.Annotations;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordPrescribing.DrugExposureWithSnomed;

internal class OxfordPrescribingDrugExposureWithSnomed : OmopDrugExposure<OxfordPrescribingDrugExposureWithSnomedRecord>
{
    [CopyValue(nameof(Source.patient_identifier_Value))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(StandardDrugConceptSelector), useOmopTypeAsSource: true, nameof(drug_source_concept_id))]
    public override int[]? drug_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.beg_dt_tm))]
    public override DateTime? drug_exposure_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.beg_dt_tm))]
    public override DateTime? drug_exposure_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.end_dt_tm))]
    public override DateTime? drug_exposure_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.end_dt_tm))]
    public override DateTime? drug_exposure_end_datetime { get; set; }

    [ConstantValue(32825, "`EHR dispensing record`")]
    public override int? drug_type_concept_id { get; set; }

    [Transform(typeof(FloatParser), nameof(Source.strengthdose))]
    public override float? quantity { get; set; }

    [Transform(typeof(SnomedSelector), nameof(Source.concept_identifier))]
    public override int? drug_source_concept_id { get; set; }

    [CopyValue(nameof(Source.order_mnemonic))]
    public override string? drug_source_value { get; set; }

    [CopyValue(nameof(Source.strengthdoseunit))]
    public override string? dose_unit_source_value { get; set; }

    [CopyValue(nameof(Source.order_detail_display_line))]
    public override string? sig { get; set; }

    [Transform(typeof(PrescribingDrugRouteLookup), nameof(Source.rxroute))]
    public override int? route_concept_id { get; set; }

    [CopyValue(nameof(Source.rxroute))]
    public override string? route_source_value { get; set; }

    [CopyValue(nameof(Source.EVENT_ID))]
    public override string? RecordConnectionIdentifier { get; set; }
}
