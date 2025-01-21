namespace OmopTransformer.Omop.CareSite;

internal abstract class OmopCareSite<T> : IOmopRecord<T>
{
    public virtual string? care_site_id { get; set; }
    public virtual string? care_site_name { get; set; }
    public virtual int? place_of_service_concept_id { get; set; }
    public virtual int? location_id { get; set; }
    public virtual string? care_site_source_value { get; set; }
    public virtual string? place_of_service_source_value { get; set; }

    public T? Source { get; set; }
    public virtual bool IsValid => true;

    public string OmopTargetTypeDescription => "CareSite";
}