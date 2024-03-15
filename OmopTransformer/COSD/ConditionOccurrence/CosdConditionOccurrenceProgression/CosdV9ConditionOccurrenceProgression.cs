using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.ConditionOccurrence.CosdConditionOccurrenceProgression;

internal class CosdV9ConditionOccurrenceProgression : OmopConditionOccurrence<CosdV9ConditionOccurrenceProgressionRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.NonPrimaryDiagnosisDate))]
    public override DateTime? condition_start_date { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? condition_type_concept_id { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.NonPrimaryProgressionOriginalDiagnosis))]
    public override int? condition_source_concept_id { get; set; }

    [Transform(typeof(SnomedSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    public override int[]? condition_concept_id { get; set; }

    [CopyValue(nameof(Source.NonPrimaryProgressionOriginalDiagnosis))]
    public override string? condition_source_value { get; set; }
}