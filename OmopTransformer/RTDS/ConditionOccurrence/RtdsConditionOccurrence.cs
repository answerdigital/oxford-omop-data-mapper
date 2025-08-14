using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.RTDS.ConditionOccurrence;

internal class RtdsConditionOccurrence : OmopConditionOccurrence<RtdsConditionOccurrenceRecord>
{
    [CopyValue(nameof(Source.PatientId))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(StandardConditionConceptSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    public override int[]? condition_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_start_date))]
    public override DateTime? condition_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_start_date))]
    public override DateTime? condition_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_end_date))]
    public override DateTime? condition_end_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.event_end_date))]
    public override DateTime? condition_end_date { get; set; }

    [ConstantValue(32818, "`EHR Administration record`")]
    public override int? condition_type_concept_id { get; set; }

    [CopyValue(nameof(Source.DiagnosisCode))]
    public override string? condition_source_value { get; set; }

    [Transform(typeof(Icd10StandardNonStandardSelector), nameof(Source.DiagnosisCode))]
    public override int? condition_source_concept_id { get; set; }
}