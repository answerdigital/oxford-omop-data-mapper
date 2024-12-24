namespace OmopTransformer.Omop.ConditionOccurrence;

internal abstract class OmopConditionOccurrence<T> : IOmopRecord<T>
{
    public virtual string? nhs_number { get; set; }
    public virtual string? RecordConnectionIdentifier { get; set; }
    public virtual int? condition_concept_id { get; set; }
    public virtual DateTime? condition_start_date { get; set; }
    public virtual DateTime? condition_start_datetime { get; set; }
    public virtual DateTime? condition_end_date { get; set; }
    public virtual DateTime? condition_end_datetime { get; set; }
    public virtual int? condition_type_concept_id { get; set; }
    public virtual int? condition_status_concept_id { get; set; }
    public virtual string? stop_reason { get; set; }
    public virtual int? provider_id { get; set; }
    public virtual int? visit_occurrence_id { get; set; }
    public virtual int? visit_detail_id { get; set; }
    public virtual string? condition_source_value { get; set; }
    public virtual int? condition_source_concept_id { get; set; }
    public virtual string? condition_status_source_value { get; set; }

    public string OmopTargetTypeDescription => "ConditionOccurrence";
    public T? Source { get; set; }
}