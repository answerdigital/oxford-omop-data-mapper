using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.ConditionOccurrence.CosdConditionOccurrencePrimaryDiagnosis;

internal class CosdConditionOccurrencePrimaryDiagnosis : OmopConditionOccurrence<CosdV9ConditionOccurrencePrimaryDiagnosisRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DateOfPrimaryDiagnosisClinicallyAgreed))]
    public override DateTime? condition_start_date { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? condition_type_concept_id { get; set; }

    [Transform(typeof(DataDictionaryBasisOfDiagnosisCancerLookup), nameof(Source.BasisOfDiagnosisCancer))]
    public override int? condition_status_concept_id { get; set; }

    [CopyValue(nameof(Source.BasisOfDiagnosisCancer))]
    public override string? condition_status_source_value { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.CancerDiagnosis))]
    public override int? condition_source_concept_id { get; set; }

    [Transform(typeof(SnomedSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    public override int[]? condition_concept_id { get; set; }

    [CopyValue(nameof(Source.CancerDiagnosis))]
    public override string? condition_source_value { get; set; }
} 