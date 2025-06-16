using OmopTransformer.Annotations;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordPrescribing.DrugExposure;

internal class OxfordPrescribingDrugExposure : OmopDrugExposure<OxfordPrescribingDrugExposureRecord>
{
    [CopyValue(nameof(Source.NHS_Number))]
    public override string? nhs_number { get; set; }

    //TODO
    // [Transform(typeof(StandardDrugConceptSelector), useOmopTypeAsSource: true, nameof(drug_source_concept_id))]
    public override int? drug_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Begin_Date))]
    public override DateTime? drug_exposure_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Begin_Date))]
    public override DateTime? drug_exposure_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.End_Date))]
    public override DateTime? drug_exposure_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.End_Date))]
    public override DateTime? drug_exposure_end_datetime { get; set; }

    [ConstantValue(32825, "`EHR dispensing record`")]
    public override int? drug_type_concept_id { get; set; }

    // TODO
    // [Transform(typeof(SactDrugLookup), nameof(Source.Order_Mnemonic))]
    public override int? drug_source_concept_id { get; set; }

    [CopyValue(nameof(Source.Order_Mnemonic))]
    public override string? drug_source_value { get; set; }
    
    [CopyValue(nameof(Source.Quantity))]
    public override float? quantity { get; set; }

    [CopyValue(nameof(Source.Strengthdoseunit))]
    public override string? dose_unit_source_value { get; set; }

    [CopyValue(nameof(Source.Order_Detail_Display_Line))]
    public override string? sig { get; set; }

    [Transform(typeof(PrescribingDrugRouteLookup), nameof(Source.Rxroute))]
    public override int? route_concept_id { get; set; }

    [CopyValue(nameof(Source.Rxroute))]
    public override string? route_source_value { get; set; }
}
