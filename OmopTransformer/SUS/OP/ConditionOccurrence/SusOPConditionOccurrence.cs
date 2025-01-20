using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.OP.ConditionOccurrence;

internal class SusOPConditionOccurrence : OmopConditionOccurrence<SusOPConditionOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.DiagnosisICD))]
    public override int? condition_source_concept_id { get; set; }

    [Transform(typeof(StandardConditionConceptSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    public override int? condition_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_end_datetime { get; set; }

    [CopyValue(nameof(Source.DiagnosisICD))]
    public override string? condition_source_value { get; set; }
    
    [ConstantValue(32818, "EHR administration record")]
    public override int? condition_type_concept_id { get; set; }
}