using OmopTransformer.Annotations;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.DrugExposure;

internal class CdsDrugExposure : OmopDrugExposure<CdsDrugExposureRecord>
{
    [CopyValue(nameof(Source.nhs_number))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(StandardDrugConceptSelector), useOmopTypeAsSource: true, nameof(drug_source_concept_id))]
    public override int? drug_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.ExposureStartDate))]
    public override DateTime? drug_exposure_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.ExposureEndDate))]
    public override DateTime? drug_exposure_end_date { get; set; }

    [CopyValue(nameof(Source.DrugTypeConceptId))]
    public override int? drug_type_concept_id { get; set; }

    [CopyValue(nameof(Source.DrugSourceValue))]
    public override string? drug_source_value { get; set; }

    [Transform(typeof(Opcs4Selector), nameof(Source.DrugSourceValue))]
    public override int? drug_source_concept_id { get; set; }

    [CopyValue(nameof(Source.RecordConnectionIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }
}