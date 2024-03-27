if object_id ('cdm.insert_update_measurement') is not null
begin
drop procedure cdm.insert_update_measurement;
end
go

create procedure cdm.insert_update_measurement
	@rows cdm.measurement_row readonly,
	@DataSource varchar(20)
as
begin

	declare @NewRecords as table
	(
		measurement_id int
	);
	
	insert into cdm.measurement
	(
		person_id,
		measurement_concept_id,
		measurement_date,
		measurement_datetime,
		measurement_time,
		measurement_type_concept_id,
		operator_concept_id,
		value_as_number,
		value_as_concept_id,
		unit_concept_id,
		range_low,
		range_high,
		provider_id,
		measurement_source_value,
		measurement_source_concept_id,
		unit_source_value,
		unit_source_concept_id,
		value_source_value,
		measurement_event_id,
		meas_event_field_concept_id
	)
	output inserted.measurement_id
	into @NewRecords (measurement_id)
	select
		p.person_id,
		r.measurement_concept_id,
		r.measurement_date,
		r.measurement_datetime,
		r.measurement_time,
		r.measurement_type_concept_id,
		r.operator_concept_id,
		r.value_as_number,
		r.value_as_concept_id,
		r.unit_concept_id,
		r.range_low,
		r.range_high,
		r.provider_id,
		r.measurement_source_value,
		r.measurement_source_concept_id,
		r.unit_source_value,
		r.unit_source_concept_id,
		r.value_source_value,
		r.measurement_event_id,
		r.meas_event_field_concept_id
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
	where 
		not exists (
			select *
			from cdm.measurement m
			where m.person_id = p.person_id 
				and m.measurement_date = r.measurement_date
				and m.measurement_concept_id = r.measurement_concept_id
		);

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('person_id'),
	('measurement_concept_id'),
	('measurement_date'),
	('measurement_datetime'),
	('measurement_time'),
	('measurement_type_concept_id'),
	('operator_concept_id'),
	('value_as_number'),
	('value_as_concept_id'),
	('unit_concept_id'),
	('range_low'),
	('range_high'),
	('provider_id'),
	('measurement_source_value'),
	('measurement_source_concept_id'),
	('unit_source_value'),
	('unit_source_concept_id'),
	('value_source_value'),
	('measurement_event_id'),
	('meas_event_field_concept_id');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		24, --	measurement
		measurement_id,
		lc.name,
		@DataSource
	from @NewRecords rl
	cross apply (select Name from @columns) lc;

end