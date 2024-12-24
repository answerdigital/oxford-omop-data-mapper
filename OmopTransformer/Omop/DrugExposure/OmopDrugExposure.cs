namespace OmopTransformer.Omop.DrugExposure;

internal abstract class OmopDrugExposure<T> : IOmopRecord<T>
{
    public virtual string? nhs_number { get; set; }
    public virtual int? drug_concept_id { get; set; }
    public virtual DateTime? drug_exposure_start_date { get; set; }
    public virtual DateTime? drug_exposure_start_datetime { get; set; }
    public virtual DateTime? drug_exposure_end_date { get; set; }
    public virtual DateTime? drug_exposure_end_datetime { get; set; }
    public virtual DateTime? verbatim_end_date { get; set; }
    public virtual int? drug_type_concept_id { get; set; }
    public virtual string? stop_reason { get; set; }
    public virtual int? refills { get; set; }
    public virtual float? quantity { get; set; }
    public virtual int? days_supply { get; set; }
    public virtual string? sig { get; set; }
    public virtual int? route_concept_id { get; set; }
    public virtual string? lot_number { get; set; }
    public virtual int? provider_id { get; set; }
    public virtual string? drug_source_value { get; set; }
    public virtual int? drug_source_concept_id { get; set; }
    public virtual string? route_source_value { get; set; }
    public virtual string? dose_unit_source_value { get; set; }
    public virtual string? RecordConnectionIdentifier { get; set; }
    public string OmopTargetTypeDescription => "DrugExposure";
    public T? Source { get; set; }
}