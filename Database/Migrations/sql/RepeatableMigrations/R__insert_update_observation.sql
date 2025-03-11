if object_id ('cdm.insert_update_observation') is not null
begin
drop procedure cdm.insert_update_observation;
end
go

create procedure cdm.insert_update_observation
	@rows cdm.observation_row readonly,
	@DataSource varchar(20)
as
begin
	set nocount on;

	declare @NewRecords as table
	(
		observation_id int
	);
	
	insert into cdm.observation
	(
		person_id,
		observation_concept_id,
		observation_date,
		observation_datetime,
		observation_type_concept_id,
		value_as_number,
		value_as_string,
		value_as_concept_id,
		qualifier_concept_id,
		unit_concept_id,
		provider_id,
		visit_occurrence_id,
		visit_detail_id,
		observation_source_value,
		observation_source_concept_id,
		unit_source_value,
		qualifier_source_value,
		value_source_value,
		observation_event_id,
		obs_event_field_concept_id,
		RecordConnectionIdentifier,
		HospitalProviderSpellNumber
	)
	output inserted.observation_id
	into @NewRecords (observation_id)
	select
		p.person_id,
		r.observation_concept_id,
		r.observation_date,
		r.observation_datetime,
		r.observation_type_concept_id,
		r.value_as_number,
		r.value_as_string,
		r.value_as_concept_id,
		r.qualifier_concept_id,
		r.unit_concept_id,
		r.provider_id,
		(
			select
				top 1
					vd.visit_occurrence_id
			from cdm.visit_detail vd
			where vd.RecordConnectionIdentifier = r.RecordConnectionIdentifier
				and vd.person_id = p.person_id
		) as visit_occurrence_id,
		(
			select
				top 1
					vd.visit_detail_id
			from cdm.visit_detail vd
			where vd.RecordConnectionIdentifier = r.RecordConnectionIdentifier
				and vd.person_id = p.person_id
		) as visit_detail_id,
		r.observation_source_value,
		r.observation_source_concept_id,
		r.unit_source_value,
		r.qualifier_source_value,
		r.value_source_value,
		r.observation_event_id,
		r.obs_event_field_concept_id,
		r.RecordConnectionIdentifier,
		r.HospitalProviderSpellNumber
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
		where not exists (
			select 1
			from cdm.observation o
			where r.recordconnectionidentifier is not null
				and o.person_id = p.person_id
				and o.observation_date = r.observation_date
				and o.observation_concept_id = r.observation_concept_id
				and o.recordconnectionidentifier = r.recordconnectionidentifier
				and (r.hospitalproviderspellnumber is null or o.hospitalproviderspellnumber = r.hospitalproviderspellnumber)
		)
		and not exists (
			select 1
			from cdm.observation o
			where r.recordconnectionidentifier is null
				and o.person_id = p.person_id
				and o.observation_date = r.observation_date
				and o.observation_concept_id = r.observation_concept_id
		);

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('person_id'),
	('observation_concept_id'),
	('observation_date'),
	('observation_datetime'),
	('observation_type_concept_id'),
	('value_as_number'),
	('value_as_string'),
	('value_as_concept_id'),
	('qualifier_concept_id'),
	('unit_concept_id'),
	('provider_id'),
	('visit_occurrence_id'),
	('visit_detail_id'),
	('observation_source_value'),
	('observation_source_concept_id'),
	('unit_source_value'),
	('qualifier_source_value'),
	('value_source_value'),
	('observation_event_id'),
	('obs_event_field_concept_id'),
	('RecordConnectionIdentifier'),
	('HospitalProviderSpellNumber');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		28, --	observation
		observation_id,
		lc.name,
		@DataSource
	from @NewRecords rl
	cross join (select Name from @columns) lc;

end