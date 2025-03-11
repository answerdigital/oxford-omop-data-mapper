if object_id ('cdm.insert_update_condition_occurrence') is not null
begin
	drop procedure cdm.insert_update_condition_occurrence;
end

go

create procedure cdm.insert_update_condition_occurrence
	@rows cdm.condition_occurrence_row readonly,
	@DataSource varchar(20)
as

begin
	set nocount on;

	declare @NewConditions table
	(
		condition_occurrence_id int not null
	);
	
	insert into cdm.condition_occurrence
	(
		person_id,
		condition_concept_id,
		condition_start_date,
		condition_start_datetime,
		condition_end_date,
		condition_end_datetime,
		condition_type_concept_id,
		condition_status_concept_id,
		stop_reason,
		provider_id,
		visit_occurrence_id,
		visit_detail_id,
		condition_source_value,
		condition_source_concept_id,
		condition_status_source_value,
		RecordConnectionIdentifier
	)
	output inserted.condition_occurrence_id
	into @NewConditions
	select
		p.person_id,
		r.condition_concept_id,
		r.condition_start_date,
		r.condition_start_datetime,
		r.condition_end_date,
		r.condition_end_datetime,
		r.condition_type_concept_id,
		r.condition_status_concept_id,
		r.stop_reason,
		r.provider_id,
		r.visit_occurrence_id,
		r.visit_detail_id,
		r.condition_source_value,
		r.condition_source_concept_id,
		r.condition_status_source_value,
		r.RecordConnectionIdentifier
	from @rows r
    inner join cdm.person p on tr.nhs_number = p.person_source_value
    where not exists (
        select 1 
        from cdm.condition_occurrence co 
        where tr.RecordConnectionIdentifier is not null
            and co.RecordConnectionIdentifier = tr.RecordConnectionIdentifier
            and co.condition_concept_id = tr.condition_concept_id
    )
    and not exists (
        select 1 
        from cdm.condition_occurrence co 
        where tr.RecordConnectionIdentifier is null
            and co.condition_concept_id = tr.condition_concept_id
            and co.condition_start_date = tr.condition_start_date
            and co.person_id = p.person_id
    );

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('condition_concept_id'),
	('condition_start_date'),
	('condition_start_datetime'),
	('condition_end_date'),
	('condition_end_datetime'),
	('condition_type_concept_id'),
	('condition_status_concept_id'),
	('stop_reason'),
	('provider_id'),
	('visit_occurrence_id'),
	('visit_detail_id'),
	('condition_source_value'),
	('condition_source_concept_id'),
	('condition_status_source_value');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		11,	-- condition_occurrence
		condition_occurrence_id,
		lc.name,
		@DataSource
	from @NewConditions rl
	cross join (select Name from @columns) lc;

end