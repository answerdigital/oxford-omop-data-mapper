namespace OmopTransformer.Omop.VisitOccurrence;

internal abstract class OmopVisitOccurrence<T> : IOmopRecord<T>
{
    public virtual string? NhsNumber { get; set; }
    public virtual int? visit_concept_id { get; set; }
    public virtual DateTime? visit_start_date { get; set; }
    public virtual DateTime? visit_start_datetime { get; set; }
    public virtual DateTime? visit_end_date { get; set; }
    public virtual DateTime? visit_end_datetime { get; set; }
    public virtual int? visit_type_concept_id { get; set; }
    public virtual int? provider_id { get; set; }
    public virtual int? care_site_id { get; set; }
    public virtual string? visit_source_value { get; set; }
    public virtual int? visit_source_concept_id { get; set; }
    public virtual int? admitted_from_concept_id { get; set; }
    public virtual string? admitted_from_source_value { get; set; }
    public virtual int? discharged_to_concept_id { get; set; }
    public virtual string? discharged_to_source_value { get; set; }
    public virtual int? preceding_visit_occurrence_id { get; set; }
    public virtual string? HospitalProviderSpellNumber { get; set; }
    public virtual string? RecordConnectionIdentifier { get; set; }
    public string OmopTargetTypeDescription => "VisitOccurrence";
    public T? Source { get; set; }

    public virtual bool IsValid =>
        NhsNumber != null &&
        visit_start_date.HasValue &&
        visit_end_date.HasValue &&
        visit_type_concept_id != null;
}