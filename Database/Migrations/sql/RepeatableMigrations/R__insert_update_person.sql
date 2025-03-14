if object_id ('cdm.insert_update_person') is not null
begin
drop procedure cdm.insert_update_person;
end
go

create procedure cdm.insert_update_person
	@rows cdm.person_row readonly,
	@DataSource varchar(100)
as
begin
	set nocount on;

declare @NewPerson table
(
	person_id int not null
);

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
output inserted.person_id
into @NewPerson
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
from @rows up
where not exists (select 1 from cdm.person p where p.person_source_value = up.person_source_value);

declare @ColumnList table ([name] varchar(max));

insert into @ColumnList ([name])
values
('gender_concept_id'),
('year_of_birth'),
('month_of_birth'),
('day_of_birth'),
('birth_datetime'),
('race_concept_id'),
('ethnicity_concept_id'),
('location_id'),
('provider_id'),
('care_site_id'),
('person_source_value'),
('gender_source_value'),
('gender_source_concept_id'),
('race_source_value'),
('race_source_concept_id'),
('ethnicity_source_value'),
('ethnicity_source_concept_id');

insert into provenance
(
	table_type_id,
	table_key,
	column_name,
	data_source
)
select
	31, -- Person,
	np.person_id,
	cl.name,
	@DataSource
from @NewPerson np
cross apply (select Name from @ColumnList) cl;

-- Update existing patients.

declare @UpdatedPatients table
(
	[person_id] [int] NOT NULL,
	[gender_concept_id] [int] NULL,
	[year_of_birth] [int] NULL,
	[month_of_birth] [int] NULL,
	[day_of_birth] [int] NULL,
	[birth_datetime] [datetime] NULL,
	[race_concept_id] [int] NULL,
	[ethnicity_concept_id] [int] NULL,
	[location_id] [int] NULL,
	[provider_id] [int] NULL,
	[care_site_id] [int] NULL,
	[person_source_value] [varchar](50) NOT NULL,
	[gender_source_value] [varchar](50) NULL,
	[gender_source_concept_id] [int] NULL,
	[race_source_value] [varchar](50) NULL,
	[race_source_concept_id] [int] NULL,
	[ethnicity_source_value] [varchar](50) NULL,
	[ethnicity_source_concept_id] [int] NULL
);

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
output
	inserted.person_id,
	(case when inserted.gender_concept_id != deleted.gender_concept_id then 1 else 0 end),
	(case when inserted.year_of_birth != deleted.year_of_birth then 1 else 0 end),
	(case when inserted.month_of_birth != deleted.month_of_birth then 1 else 0 end),
	(case when inserted.day_of_birth != deleted.day_of_birth then 1 else 0 end),
	(case when inserted.birth_datetime != deleted.birth_datetime then 1 else 0 end),
	(case when inserted.race_concept_id != deleted.race_concept_id then 1 else 0 end),
	(case when inserted.ethnicity_concept_id != deleted.ethnicity_concept_id then 1 else 0 end),
	(case when inserted.location_id != deleted.location_id then 1 else 0 end),
	(case when inserted.provider_id != deleted.provider_id then 1 else 0 end),
	(case when inserted.care_site_id != deleted.care_site_id then 1 else 0 end),
	(case when inserted.person_source_value != deleted.person_source_value then 1 else 0 end),
	(case when inserted.gender_source_value != deleted.gender_source_value then 1 else 0 end),
	(case when inserted.gender_source_concept_id != deleted.gender_source_concept_id then 1 else 0 end),
	(case when inserted.race_source_value != deleted.race_source_value then 1 else 0 end),
	(case when inserted.race_source_concept_id != deleted.race_source_concept_id then 1 else 0 end),
	(case when inserted.ethnicity_source_value != deleted.ethnicity_source_value then 1 else 0 end),
	(case when inserted.ethnicity_source_concept_id != deleted.ethnicity_source_concept_id then 1 else 0 end)
into @UpdatedPatients
from cdm.person p
	inner join @rows up
		on p.person_source_value = up.person_source_value


;with ProvenanceData as ( 
	select 'gender_concept_id' as column_name, person_id from @UpdatedPatients where gender_concept_id = 1 union
	select 'year_of_birth' as column_name, person_id from @UpdatedPatients where year_of_birth = 1 union
	select 'month_of_birth' as column_name, person_id from @UpdatedPatients where month_of_birth = 1 union
	select 'day_of_birth' as column_name, person_id from @UpdatedPatients where day_of_birth = 1 union
	select 'birth_datetime' as column_name, person_id from @UpdatedPatients where birth_datetime = 1 union
	select 'race_concept_id' as column_name, person_id from @UpdatedPatients where race_concept_id = 1 union
	select 'ethnicity_concept_id' as column_name, person_id from @UpdatedPatients where ethnicity_concept_id = 1 union
	select 'location_id' as column_name, person_id from @UpdatedPatients where location_id = 1 union
	select 'provider_id' as column_name, person_id from @UpdatedPatients where provider_id = 1 union
	select 'care_site_id' as column_name, person_id from @UpdatedPatients where care_site_id = 1 union
	select 'person_source_value' as column_name, person_id from @UpdatedPatients where person_source_value = 1 union
	select 'gender_source_value' as column_name, person_id from @UpdatedPatients where gender_source_value = 1 union
	select 'gender_source_concept_id' as column_name, person_id from @UpdatedPatients where gender_source_concept_id = 1 union
	select 'race_source_value' as column_name, person_id from @UpdatedPatients where race_source_value = 1 union
	select 'race_source_concept_id' as column_name, person_id from @UpdatedPatients where race_source_concept_id = 1 union
	select 'ethnicity_source_value' as column_name, person_id from @UpdatedPatients where ethnicity_source_value = 1 union
	select 'ethnicity_source_concept_id' as column_name, person_id from @UpdatedPatients where ethnicity_source_concept_id = 1
)
update p
set data_source = @DataSource
from provenance p
	inner join ProvenanceData pd
		on p.table_key = pd.person_id
		and p.column_name = pd.column_name;

end