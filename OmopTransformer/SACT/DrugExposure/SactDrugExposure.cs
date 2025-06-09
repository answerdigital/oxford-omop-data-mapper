using OmopTransformer.Annotations;
using OmopTransformer.Omop.DrugExposure;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.DrugExposure;

internal class SactDrugExposure : OmopDrugExposure<SactDrugExposureRecord>
{
    [CopyValue(nameof(Source.NHS_Number))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(StandardDrugConceptSelector), useOmopTypeAsSource: true, nameof(drug_source_concept_id))]
    public override int? drug_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Administration_Date))]
    public override DateTime? drug_exposure_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Administration_Date))]
    public override DateTime? drug_exposure_end_date { get; set; }

    [ConstantValue(32818, "`EHR administration record`")]
    public override int? drug_type_concept_id { get; set; }

    [Transform(typeof(SactDrugLookup), nameof(Source.Drug_Name))]
    public override int? drug_source_concept_id { get; set; }

    [CopyValue(nameof(Source.Drug_Name))]
    public override string? drug_source_value { get; set; }

    [Transform(typeof(SactUnitOfMeasurement), nameof(Source.Administration_Measurement_Per_Actual_Dose))]
    public override string? dose_unit_source_value { get; set; }
}
