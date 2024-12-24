﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.COSD.ConditionOccurrence.CosdV8ConditionOccurrencePrimaryDiagnosis;

[Notes(
    "Assumptions",
    "* Any changes in a Diagnosis that may occur in later submissions, for the same Diagnosis date, is taken to be an additional diagnosis as opposed to a change (hence removal of the original)",
    "* If the same Diagnosis occurs but we have 2 separate \"basis of diagnosis\" values, then the first one will be taken only")]
internal class CosdV8ConditionOccurrencePrimaryDiagnosis : OmopConditionOccurrence<CosdV8ConditionOccurrencePrimaryDiagnosisRecord>
{
    [CopyValue(nameof(Source.NhsNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.DiagnosisDate))]
    public override DateTime? condition_start_date { get; set; }

    [ConstantValue(32828, "`EHR episode record`")]
    public override int? condition_type_concept_id { get; set; }

    [Transform(typeof(DataDictionaryBasisOfDiagnosisCancerLookup), nameof(Source.BasisOfDiagnosisCancer))]
    public override int? condition_status_concept_id { get; set; }

    [CopyValue(nameof(Source.BasisOfDiagnosisCancer))]
    public override string? condition_status_source_value { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.CancerDiagnosis))]
    public override int? condition_source_concept_id { get; set; }

    [Transform(typeof(StandardConditionConceptSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    public override int? condition_concept_id { get; set; }

    [CopyValue(nameof(Source.CancerDiagnosis))]
    public override string? condition_source_value { get; set; }
}