namespace OmopTransformer.Omop.ProcedureOccurrence;

internal abstract class OmopProcedureOccurrence<T> : IOmopRecord<T>
{
    public virtual string? nhs_number { get; set; }
    public virtual int? procedure_concept_id { get; set; }
    public virtual DateTime? procedure_date { get; set; }
    public virtual DateTime? procedure_datetime { get; set; }
    public virtual DateTime? procedure_end_date { get; set; }
    public virtual DateTime? procedure_end_datetime { get; set; }
    public virtual int? procedure_type_concept_id { get; set; }
    public virtual int? modifier_concept_id { get; set; }
    public virtual int? quantity { get; set; }
    public virtual int? provider_id { get; set; }
    public virtual int? visit_occurrence_id { get; set; }
    public virtual int? visit_detail_id { get; set; }
    public virtual string? procedure_source_value { get; set; }
    public virtual int? procedure_source_concept_id { get; set; }
    public virtual string? modifier_source_value { get; set; }
    public virtual string? RecordConnectionIdentifier { get; set; }

    public string OmopTargetTypeDescription => "ProcedureOccurrence";
    public T? Source { get; set; }

    public virtual bool IsValid =>
        nhs_number != null &&
        procedure_concept_id != null &&
        procedure_date.HasValue &&
        procedure_type_concept_id != null;
}