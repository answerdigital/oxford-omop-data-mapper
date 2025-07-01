using OmopTransformer.Annotations;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.OxfordGP.DrugExposure;

internal class OxfordGPDrugExposure : OmopDrugExposure<OxfordGPDrugExposureRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(StandardDrugConceptSelector), useOmopTypeAsSource: true, nameof(drug_source_concept_id))]
    public override int[]? drug_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.LastIssueDate))]
    public override DateTime? drug_exposure_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.LastIssueDate))]
    public override DateTime? drug_exposure_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.LastIssueDate))]
    public override DateTime? drug_exposure_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.LastIssueDate))]
    public override DateTime? drug_exposure_end_datetime { get; set; }

    [ConstantValue(32825, "`EHR dispensing record`")]
    public override int? drug_type_concept_id { get; set; }

    [Transform(typeof(FloatParser), nameof(Source.Quantity))]
    public override float? quantity { get; set; }

    [Transform(typeof(SnomedSelector), nameof(Source.SuppliedCode))]
    public override int? drug_source_concept_id { get; set; }

    [CopyValue(nameof(Source.SuppliedCode))]
    public override string? drug_source_value { get; set; }

    [CopyValue(nameof(Source.Units))]
    public override string? dose_unit_source_value { get; set; }

}
