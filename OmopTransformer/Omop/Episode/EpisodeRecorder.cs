namespace OmopTransformer.Omop.Episode;

internal abstract class OmopEpisode<T> : IOmopRecord<T>
{
    public virtual string? nhs_number { get; set; }
    public virtual int? episode_concept_id{ get; set; }
    public virtual DateOnly ? episode_start_date { get; set; }
    public virtual DateTime? episode_start_datetime { get; set; }
    public virtual DateOnly? episode_end_date { get; set; }
    public virtual DateTime ? episode_end_datetime { get; set; }
    public virtual int? episode_parent_id { get; set; }
    public virtual int? episode_number { get; set; }
    public virtual int? episode_object_concept_id{ get; set; }
    public virtual int? episode_type_concept_id{ get; set; }
    public virtual string? episode_source_value { get; set; }
    public virtual int? episode_source_concept_id { get; set; }

    public T? Source { get; set; }
    public virtual bool IsValid => 
        nhs_number != null && 
        episode_concept_id.HasValue && 
        episode_start_date.HasValue && 
        episode_object_concept_id.HasValue && 
        episode_type_concept_id.HasValue;

    public string OmopTargetTypeDescription => "Episode";
}