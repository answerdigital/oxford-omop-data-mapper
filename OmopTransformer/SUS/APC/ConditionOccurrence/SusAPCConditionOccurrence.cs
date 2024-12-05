using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.APC.ConditionOccurrence;

internal class SusAPCConditionOccurrence : OmopConditionOccurrence<SusAPCConditionOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.DiagnosisICD))]
    public override int? condition_source_concept_id { get; set; }

    [Transform(typeof(SnomedSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    public override int[]? condition_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_start_date { get; set; }

    [CopyValue(nameof(Source.DiagnosisICD))]
    public override string? condition_source_value { get; set; }
    
    [ConstantValue(32020, "EHR encounter diagnosis")]
    public override int? condition_type_concept_id { get; set; }
}