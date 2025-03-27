namespace OmopTransformer.Omop.Person;

internal abstract class OmopPerson<T> : IOmopRecord<T>
{
    public virtual int? gender_concept_id { get; set; }
    public virtual int? year_of_birth { get; set; }
    public virtual int? month_of_birth { get; set; }
    public virtual int? day_of_birth { get; set; }
    public virtual DateTime? birth_datetime { get; set; }
    public virtual int? race_concept_id { get; set; }
    public virtual int? ethnicity_concept_id { get; set; }
    public virtual int? provider_id { get; set; }
    public virtual int? care_site_id { get; set; }
    public virtual string? person_source_value { get; set; }
    public virtual string? gender_source_value { get; set; }
    public virtual int? gender_source_concept_id { get; set; }
    public virtual string? race_source_value { get; set; }
    public virtual int? race_source_concept_id { get; set; }
    public virtual string? ethnicity_source_value { get; set; }
    public virtual int? ethnicity_source_concept_id { get; set; }

    public T? Source { get; set; }

    public string OmopTargetTypeDescription => "Person";

    public virtual bool IsValid =>
        year_of_birth != null &&
        person_source_value != null &&
        race_concept_id != null;
}