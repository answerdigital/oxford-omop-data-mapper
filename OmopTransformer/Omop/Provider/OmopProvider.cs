namespace OmopTransformer.Omop.Provider;

internal abstract class OmopProvider<T> : IOmopRecord<T>
{
    public virtual int? provider_id { get; set; }
    public virtual string? provider_name { get; set; }
    public virtual string? npi { get; set; }
    public virtual string? dea { get; set; }
    public virtual int? specialty_concept_id { get; set; }
    public virtual int? care_site_id { get; set; }
    public virtual string? year_of_birth { get; set; }
    public virtual string? gender_concept_id { get; set; }
    public virtual string? provider_source_value { get; set; }
    public virtual string? specialty_source_value { get; set; }
    public virtual string? specialty_source_concept_id { get; set; }
    public virtual string? gender_source_value { get; set; }
    public virtual string? gender_source_concept_id { get; set; }

    public T? Source { get; set; }

    public string OmopTargetTypeDescription => "Provider";
}