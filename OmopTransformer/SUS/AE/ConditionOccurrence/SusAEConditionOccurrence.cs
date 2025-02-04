using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.SUS.AE.ConditionOccurrence;

internal class SusAEConditionOccurrence : OmopConditionOccurrence<SusAEConditionOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    // [Transform(typeof(Icd10StandardNonStandardSelector), nameof(Source.AccidentAndEmergencyDiagnosis))]
    // public override int? condition_source_concept_id { get; set; }

    // [Transform(typeof(StandardConditionConceptSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    // public override int? condition_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_start_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_start_datetime { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_end_date { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_end_datetime { get; set; }
    
    [ConstantValue(32818, "EHR administration record")]
    public override int? condition_type_concept_id { get; set; }

    [CopyValue(nameof(Source.GeneratedRecordIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }
}