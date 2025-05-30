using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.SACT.ConditionOccurrence;

internal class SactConditionOccurrence : OmopConditionOccurrence<SactConditionOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHS_Number))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(Icd10StandardNonStandardSelector), nameof(Source.Primary_Diagnosis))]
    public override int? condition_source_concept_id { get; set; }

    [Transform(typeof(StandardConditionConceptSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    public override int? condition_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Administration_Date))]
    public override DateTime? condition_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.Administration_Date))]
    public override DateTime? condition_end_date { get; set; }

    [CopyValue(nameof(Source.Primary_Diagnosis))]
    public override string? condition_source_value { get; set; }
    
    [ConstantValue(32818, "EHR administration record")]
    public override int? condition_type_concept_id { get; set; }
}