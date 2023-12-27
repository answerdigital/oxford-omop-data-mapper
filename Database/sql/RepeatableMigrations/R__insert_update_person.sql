if object_id ('cdm.insert_update_person') is not null
begin
drop procedure cdm.insert_update_person;
end
go

create procedure cdm.insert_update_person
	@rows cdm.person_row readonly
as
begin

SET ANSI_WARNINGS OFF

declare @uniquePerson as table
(
	gender_concept_id	int null,
	year_of_birth	int null, 
	month_of_birth	int null, 
	day_of_birth	int null, 
	birth_datetime	datetime null, 
	race_concept_id	int null, 
	ethnicity_concept_id	int null, 
	provider_id	int null, 
	care_site_id	int null, 
	person_source_value	varchar(max) not null, 
	gender_source_value	varchar(max) null, 
	gender_source_concept_id	int null, 
	race_source_value	varchar(max) null, 
	race_source_concept_id	int null, 
	ethnicity_source_value	varchar(max) null, 
	ethnicity_source_concept_id	int null 
);

insert into @uniquePerson
(
	gender_concept_id,
	year_of_birth, 
	month_of_birth, 
	day_of_birth, 
	birth_datetime, 
	race_concept_id, 
	ethnicity_concept_id, 
	provider_id, 
	care_site_id, 
	person_source_value, 
	gender_source_value, 
	gender_source_concept_id, 
	race_source_value, 
	race_source_concept_id, 
	ethnicity_source_value, 
	ethnicity_source_concept_id 
)
select	
	max(gender_concept_id) as gender_concept_id,
	max(year_of_birth) as year_of_birth,
	max(month_of_birth) as month_of_birth,
	max(day_of_birth) as day_of_birth,
	max(birth_datetime) as birth_datetime,
	max(race_concept_id) as race_concept_id,
	max(ethnicity_concept_id) as ethnicity_concept_id,
	max(provider_id) as provider_id,
	max(care_site_id) as care_site_id,
	person_source_value,
	max(gender_source_value) as gender_source_value,
	max(gender_source_concept_id) as gender_source_concept_id,
	max(race_source_value) as race_source_value,
	max(race_source_concept_id) as race_source_concept_id,
	max(ethnicity_source_value) as ethnicity_source_value,
	max(ethnicity_source_concept_id) as ethnicity_source_concept_id
from @rows
group by person_source_value

-- Insert new patients.
insert into cdm.person
(
    gender_concept_id,
    year_of_birth,
    month_of_birth,
    day_of_birth,
    birth_datetime,
    race_concept_id,
    ethnicity_concept_id,
    location_id,
    provider_id,
    care_site_id,
    person_source_value,
    gender_source_value,
    gender_source_concept_id,
    race_source_value,
    race_source_concept_id,
    ethnicity_source_value,
    ethnicity_source_concept_id
)
select
	gender_concept_id,
    year_of_birth,
    month_of_birth,
    day_of_birth,
    birth_datetime,
    race_concept_id,
    ethnicity_concept_id,
    null, -- This gets set when recording locations.
    provider_id,
    care_site_id,
    person_source_value,
    gender_source_value,
    gender_source_concept_id,
    race_source_value,
    race_source_concept_id,
    ethnicity_source_value,
    ethnicity_source_concept_id
from @uniquePerson up
where not exists (select * from cdm.person p where p.person_source_value = up.person_source_value);

-- Update existing patients.

update p
	set
		p.gender_concept_id = case when up.gender_concept_id is not null then up.gender_concept_id else p.gender_concept_id end,
		p.year_of_birth = case when up.year_of_birth is not null then up.year_of_birth else p.year_of_birth end, 
		p.month_of_birth = case when up.month_of_birth is not null then up.month_of_birth else p.month_of_birth end, 
		p.day_of_birth = case when up.day_of_birth is not null then up.day_of_birth else p.day_of_birth end, 
		p.birth_datetime = case when up.birth_datetime is not null then up.birth_datetime else p.birth_datetime end, 
		p.race_concept_id = case when up.race_concept_id is not null then up.race_concept_id else p.race_concept_id end, 
		p.ethnicity_concept_id = case when up.ethnicity_concept_id is not null then up.ethnicity_concept_id else p.ethnicity_concept_id end, 
		p.provider_id = case when up.provider_id is not null then up.provider_id else p.provider_id end, 
		p.care_site_id = case when up.care_site_id is not null then up.care_site_id else p.care_site_id end, 
		p.person_source_value = case when up.person_source_value is not null then up.person_source_value else p.person_source_value end, 
		p.gender_source_value = case when up.gender_source_value is not null then up.gender_source_value else p.gender_source_value end, 
		p.gender_source_concept_id = case when up.gender_source_concept_id is not null then up.gender_source_concept_id else p.gender_source_concept_id end, 
		p.race_source_value = case when up.race_source_value is not null then up.race_source_value else p.race_source_value end, 
		p.race_source_concept_id = case when up.race_source_concept_id is not null then up.race_source_concept_id else p.race_source_concept_id end, 
		p.ethnicity_source_value = case when up.ethnicity_source_value is not null then up.ethnicity_source_value else p.ethnicity_source_value end, 
		p.ethnicity_source_concept_id = case when up.ethnicity_source_concept_id is not null then up.ethnicity_source_concept_id else p.ethnicity_source_concept_id end
from cdm.person p
	left outer join @uniquePerson up
		on p.person_source_value = up.person_source_value


end