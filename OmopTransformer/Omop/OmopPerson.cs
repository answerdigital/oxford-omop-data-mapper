namespace OmopTransformer.Omop;

internal abstract class OmopPerson<T> : IOmopRecord<T>
{
    public T? Source { get; set; }
    public string OmopTargetTypeDescription => "Person";
    public virtual int person_id { get; set; }
    public virtual int gender_concept_id { get; set; }
    public virtual int year_of_birth { get; set; }
    public virtual int month_of_birth { get; set; }
    public virtual int day_of_birth { get; set; }
    public virtual DateTime birth_datetime { get; set; }
    public virtual int race_concept_id { get; set; }
    public virtual int ethnicity_concept_id { get; set; }
    public virtual int location_id { get; set; }
    public virtual int provider_id { get; set; }
    public virtual int care_site_id { get; set; }
    public virtual string? person_source_value { get; set; }
    public virtual string? gender_source_value { get; set; }
    public virtual int gender_source_concept_id { get; set; }
    public virtual string? race_source_value { get; set; }
    public virtual int race_source_concept_id { get; set; }
    public virtual string? ethnicity_source_value { get; set; }
    public virtual int ethnicity_source_concept_id { get; set; }
}