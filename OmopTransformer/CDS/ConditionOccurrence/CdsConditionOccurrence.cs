using OmopTransformer.Annotations;
using OmopTransformer.Omop.ConditionOccurrence;
using OmopTransformer.Transformation;

namespace OmopTransformer.CDS.ConditionOccurrence;

[Notes(
    "Duplicates",
    "CDS data contains numerous duplicated records for cds_diagnosis.DiagnosisCode (condition_concept_id), cds_line01.cdsActivityDate (condition_start_date) and cds_line01.NHSNumber (person_id).",
    "In order to avoid true duplicates occurring in the data, we have included distinct records for  cds_diagnosis.DiagnosisCode (condition_concept_id), cds_line01.cdsActivityDate (condition_start_date) , cds_line01.NHSNumber (person_id) and cds_line01.RecordConnectionIdentifier and excluded all duplicates.")]
internal class CdsConditionOccurrence : OmopConditionOccurrence<CdsConditionOccurrenceRecord>
{
    [CopyValue(nameof(Source.NHSNumber))]
    public override string? nhs_number { get; set; }

    [Transform(typeof(Icd10Selector), nameof(Source.DiagnosisCode))]
    public override int? condition_source_concept_id { get; set; }

    [Transform(typeof(StandardConditionConceptSelector), useOmopTypeAsSource: true, nameof(condition_source_concept_id))]
    public override int? condition_concept_id { get; set; }

    [Transform(typeof(DateConverter), nameof(Source.CDSActivityDate))]
    public override DateTime? condition_start_date { get; set; }

    [CopyValue(nameof(Source.RecordConnectionIdentifier))]
    public override string? RecordConnectionIdentifier { get; set; }

    [CopyValue(nameof(Source.DiagnosisCode))]
    public override string? condition_source_value { get; set; }
    
    [ConstantValue(32020, "EHR encounter diagnosis")]
    public override int? condition_type_concept_id { get; set; }
}