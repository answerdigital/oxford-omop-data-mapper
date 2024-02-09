namespace OmopTransformer.Omop.Death;

internal abstract class OmopDeath<T> : IOmopRecord<T>
{
    public virtual string? NhsNumber { get; set; }
    public virtual DateTime? death_date { get; set; }
    public virtual DateTime? death_datetime { get; set; }
    public virtual int? death_type_concept_id { get; set; }
    public virtual int? cause_concept_id { get; set; }
    public virtual string? cause_source_value { get; set; }
    public virtual int? cause_source_concept_id { get; set; }
    public string OmopTargetTypeDescription => "Death";
    public T? Source { get; set; }
}