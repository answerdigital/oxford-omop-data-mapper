if object_id ('cdm.insert_update_provider') is not null
begin
drop procedure cdm.insert_update_provider;
end
go

create procedure cdm.insert_update_provider
	@rows cdm.provider_row readonly,
	@DataSource varchar(20)
as
begin

	declare @NewRecords as table
	(
		provider_id int
	);
	
	insert into cdm.provider
	(
	provider_name,
	npi,
	dea,
	specialty_concept_id,
	care_site_id,
	year_of_birth,
	gender_concept_id,
	provider_source_value,
	specialty_source_value,
	specialty_source_concept_id,
	gender_source_value,
	gender_source_concept_id
	)
	output inserted.provider_id
	into @NewRecords (provider_id)
	select
		provider_name,
		npi,
		dea,
		specialty_concept_id,
		care_site_id,
		year_of_birth,
		gender_concept_id,
		provider_source_value,
		specialty_source_value,
		specialty_source_concept_id,
		gender_source_value,
		gender_source_concept_id
	from @rows
	where 
		not exists (
			select *
			from cdm.provider p
			where p.provider_id = p.provider_id 
				and p.provider_name = r.provider_name
				and p.specialty_concept_id = r.specialty_concept_id
				and p.specialty_source_value = r.specialty_source_value
		);

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('provider_name'),
	('npi'),
	('dea'),
	('specialty_concept_id'),
	('care_site_id'),
	('year_of_birth'),
	('gender_concept_id'),
	('provider_source_value'),
	('specialty_source_value'),
	('specialty_source_concept_id'),
	('gender_source_value'),
	('gender_source_concept_id');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		33, --	provider
		provider_id,
		lc.name,
		@DataSource
	from @NewRecords rl
	cross apply (select Name from @columns) lc;

end