if object_id ('cdm.insert_update_procedure_occurrence') is not null
begin
drop procedure cdm.insert_update_procedure_occurrence;
end
go

create procedure cdm.insert_update_procedure_occurrence
	@rows cdm.procedure_occurrence_row readonly,
	@DataSource varchar(20)
as
begin
	set nocount on;

	declare @NewRecords as table
	(
		procedure_occurrence_id int
	);
	
	insert into cdm.procedure_occurrence
	(
		person_id,
		procedure_concept_id,
		procedure_date,
		procedure_datetime,
		procedure_end_date,
		procedure_end_datetime,
		procedure_type_concept_id,
		modifier_concept_id,
		quantity,
		provider_id,
		visit_occurrence_id,
		visit_detail_id,
		procedure_source_value,
		procedure_source_concept_id,
		modifier_source_value,
		RecordConnectionIdentifier
	)
	output inserted.procedure_occurrence_id
	into @NewRecords (procedure_occurrence_id)
	select
		p.person_id,
		r.procedure_concept_id,
		r.procedure_date,
		r.procedure_datetime,
		r.procedure_end_date,
		r.procedure_end_datetime,
		r.procedure_type_concept_id,
		r.modifier_concept_id,
		r.quantity,
		r.provider_id,
		r.visit_occurrence_id,
		r.visit_detail_id,
		r.procedure_source_value,
		r.procedure_source_concept_id,
		r.modifier_source_value,
		r.RecordConnectionIdentifier
	from @rows r
		inner join cdm.person p on r.nhs_number = p.person_source_value
		where not exists (
			select 1 
			from cdm.procedure_occurrence po
			where r.RecordConnectionIdentifier is not null
				and co.RecordConnectionIdentifier = r.RecordConnectionIdentifier
				and po.procedure_date = r.procedure_date
				and po.procedure_concept_id = r.procedure_concept_id
		)
		and not exists (
			select 1 
			from cdm.procedure_occurrence po
			where r.RecordConnectionIdentifier is null
				and po.procedure_concept_id = r.procedure_concept_id
				and po.procedure_date = r.procedure_date
				and po.person_id = p.person_id
		);

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('person_id'),
	('procedure_concept_id'),
	('procedure_date'),
	('procedure_datetime'),
	('procedure_end_date'),
	('procedure_end_datetime'),
	('procedure_type_concept_id'),
	('modifier_concept_id'),
	('quantity'),
	('provider_id'),
	('visit_occurrence_id'),
	('visit_detail_id'),
	('procedure_source_value'),
	('procedure_source_concept_id'),
	('modifier_source_value'),
	('RecordConnectionIdentifier');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		32, --	procedure_occurrence
		procedure_occurrence_id,
		lc.name,
		@DataSource
	from @NewRecords rl
	cross join (select Name from @columns) lc;

end