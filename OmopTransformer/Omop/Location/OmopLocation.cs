namespace OmopTransformer.Omop.Location;

internal abstract class OmopLocation<T> : IOmopRecord<T>
{
    public virtual string? address_1 { get; set; }
    public virtual string? address_2 { get; set; }
    public virtual string? city { get; set; }
    public virtual string? state { get; set; }
    public virtual string? zip { get; set; }
    public virtual string? county { get; set; }
    public virtual string? location_source_value { get; set; }
    public virtual int? country_concept_id { get; set; }
    public virtual string? country_source_value { get; set; }
    public virtual double? latitude { get; set; }
    public virtual double? longitude { get; set; }
    public virtual string? nhs_number { get; set; }
    public string OmopTargetTypeDescription => "Location";
    public T? Source { get; set; }
    public virtual bool IsValid => true;
}