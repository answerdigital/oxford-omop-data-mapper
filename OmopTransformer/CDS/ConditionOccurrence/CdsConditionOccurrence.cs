﻿using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.ConditionOccurrence;

internal class CdsConditionOccurrence : OmopConditionOccurrence<CdsConditionOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.DiagnosisCode))]
    public override int? condition_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_start_date { get; set; }

    [CopyValue(nameof(Source.DiagnosisId))]
    public override int? cds_diagnosis_id { get; set; }

    [CopyValue(nameof(Source.DiagnosisCode))]
    public override string? condition_source_value { get; set; }
    
    [ConstantValue(32020, "EHR encounter diagnosis")]
    public override int? condition_type_concept_id { get; set; }
}