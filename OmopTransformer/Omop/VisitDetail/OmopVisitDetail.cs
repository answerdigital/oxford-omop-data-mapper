namespace OmopTransformer.Omop.VisitDetail;

internal abstract class OmopVisitDetail<T> : IOmopRecord<T>
{
    public virtual string? nhs_number { get; set; }
    public virtual string? HospitalProviderSpellNumber { get; set; }
    public virtual string? RecordConnectionIdentifier { get; set; }
    public virtual int? visit_detail_concept_id { get; set; }
    public virtual DateTime? visit_detail_start_date { get; set; }
    public virtual DateTime? visit_detail_start_datetime { get; set; }
    public virtual DateTime? visit_detail_end_date { get; set; }
    public virtual DateTime? visit_detail_end_datetime { get; set; }
    public virtual int? visit_detail_type_concept_id { get; set; }
    public virtual int? provider_id { get; set; }
    public virtual int? care_site_id { get; set; }
    public virtual string? visit_detail_source_value { get; set; }
    public virtual string? visit_detail_source_concept_id { get; set; }
    public virtual int? admitted_from_concept_id { get; set; }
    public virtual string? admitted_from_source_value { get; set; }
    public virtual string? discharged_to_source_value { get; set; }
    public virtual int? discharged_to_concept_id { get; set; }
    public string OmopTargetTypeDescription => "VisitDetail";
    public T? Source { get; set; }
}