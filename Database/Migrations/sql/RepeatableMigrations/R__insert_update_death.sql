if object_id ('cdm.insert_update_death') is not null
begin
drop procedure cdm.insert_update_death;
end
go

create procedure cdm.insert_update_death
	@rows cdm.death_row readonly,
	@DataSource varchar(20)
as
begin

	declare @NewRecords as table
	(
		person_id int
	);
	
	insert into cdm.death
	(
		person_id,
		death_date,
		death_datetime,
		death_type_concept_id,
		cause_concept_id,
		cause_source_value,
		cause_source_concept_id
	)
	output inserted.person_id
	into @NewRecords (person_id)
	select
		p.person_id,
		r.death_date,
		r.death_datetime,
		r.death_type_concept_id,
		r.cause_concept_id,
		r.cause_source_value,
		r.cause_source_concept_id
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
	where 
		not exists (
			select	*
			from cdm.death d
			where d.person_id = p.person_id
		);


	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('death_date'),
	('death_datetime'),
	('death_type_concept_id'),
	('cause_concept_id'),
	('cause_source_value'),
	('cause_source_concept_id');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		distinct
			13, --	death
			person_id,
			lc.name,
			@DataSource
	from @NewRecords rl
	cross apply (select Name from @columns) lc;

end