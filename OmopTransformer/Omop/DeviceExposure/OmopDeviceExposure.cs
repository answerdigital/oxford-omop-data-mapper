namespace OmopTransformer.Omop.DeviceExposure;

internal abstract class OmopDeviceExposure<T> : IOmopRecord<T>
{
    public virtual string? nhs_number { get; set; }
    public virtual int? device_concept_id { get; set; }
    public virtual DateTime? device_exposure_start_date { get; set; }
    public virtual DateTime? device_exposure_start_datetime { get; set; }
    public virtual DateTime? device_exposure_end_date { get; set; }
    public virtual DateTime? device_exposure_end_datetime { get; set; }
    public virtual int? device_type_concept_id { get; set; }
    public virtual string? unique_device_id { get; set; }
    public virtual string? production_id { get; set; }
    public virtual float? quantity { get; set; }
    public virtual int? provider_id { get; set; }
    public virtual int? visit_occurrence_id { get; set; }
    public virtual int? visit_detail_id { get; set; }
    public virtual string? device_source_value { get; set; }
    public virtual int? device_source_concept_id { get; set; }
    public virtual int? unit_concept_id { get; set; }
    public virtual string? unit_source_value { get; set; }
    public virtual int? unit_source_concept_id { get; set; }
    public virtual string? HospitalProviderSpellNumber { get; set; }
    public virtual string? RecordConnectionIdentifier { get; set; }
    public string OmopTargetTypeDescription => "DeviceExposure";
    public T? Source { get; set; }

    public virtual bool IsValid =>
        device_concept_id != null &&
        device_exposure_start_date.HasValue &&
        device_type_concept_id.HasValue &&
        nhs_number != null;
}