if object_id ('cdm.insert_update_visit_occurrence') is not null
begin
drop procedure cdm.insert_update_visit_occurrence;
end
go

create procedure cdm.insert_update_visit_occurrence
	@rows cdm.visit_occurrence_row readonly,
	@DataSource varchar(100)
as
begin

	declare @NewRecords as table
	(
		visit_occurrence_id int
	);

	declare @UpdatedRecords table
	(
		[visit_occurrence_id] [int] NOT NULL,
		visit_start_date int not null,
		visit_start_datetime int not null,
		visit_end_date int not null,
		visit_end_datetime int not null
	);

	update vo
		set 
			vo.visit_start_date = case when r.visit_start_date < vo.visit_start_date then r.visit_start_date else vo.visit_start_date end,
			vo.visit_start_datetime = case when r.visit_start_datetime < vo.visit_start_datetime then r.visit_start_datetime else vo.visit_start_datetime end,
			vo.visit_end_date = case when r.visit_end_date > vo.visit_end_date then r.visit_end_date else vo.visit_end_date end,
			vo.visit_end_datetime = case when r.visit_end_datetime > vo.visit_end_datetime then r.visit_end_datetime else vo.visit_end_datetime end
	output
		inserted.visit_occurrence_id,
		(case when inserted.visit_start_date != deleted.visit_start_date then 1 else 0 end),
		(case when inserted.visit_start_datetime != deleted.visit_start_datetime then 1 else 0 end),
		(case when inserted.visit_end_date != deleted.visit_end_date then 1 else 0 end),
		(case when inserted.visit_end_datetime != deleted.visit_end_datetime then 1 else 0 end)
	into @UpdatedRecords
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
		inner join cdm.visit_occurrence vo
			on p.person_id = vo.person_id
			and r.HospitalProviderSpellNumber = vo.HospitalProviderSpellNumber
	where r.HospitalProviderSpellNumber is null;

	update vo
		set 
			vo.visit_start_date = case when r.visit_start_date < vo.visit_start_date then r.visit_start_date else vo.visit_start_date end,
			vo.visit_start_datetime = case when r.visit_start_datetime < vo.visit_start_datetime then r.visit_start_datetime else vo.visit_start_datetime end,
			vo.visit_end_date = case when r.visit_end_date > vo.visit_end_date then r.visit_end_date else vo.visit_end_date end,
			vo.visit_end_datetime = case when r.visit_end_datetime > vo.visit_end_datetime then r.visit_end_datetime else vo.visit_end_datetime end
	output
		inserted.visit_occurrence_id,
		(case when inserted.visit_start_date != deleted.visit_start_date then 1 else 0 end),
		(case when inserted.visit_start_datetime != deleted.visit_start_datetime then 1 else 0 end),
		(case when inserted.visit_end_date != deleted.visit_end_date then 1 else 0 end),
		(case when inserted.visit_end_datetime != deleted.visit_end_datetime then 1 else 0 end)
	into @UpdatedRecords
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
		inner join cdm.visit_occurrence vo
			on p.person_id = vo.person_id
			and r.RecordConnectionIdentifier = vo.RecordConnectionIdentifier
	where r.RecordConnectionIdentifier is null;
	
	;with ProvenanceData as ( 
		select 'visit_start_date' as column_name, visit_occurrence_id from @UpdatedRecords where visit_start_date = 1 union
		select 'visit_start_datetime' as column_name, visit_occurrence_id from @UpdatedRecords where visit_start_datetime = 1 union
		select 'visit_end_date' as column_name, visit_occurrence_id from @UpdatedRecords where visit_end_date = 1 union
		select 'visit_end_datetime' as column_name, visit_occurrence_id from @UpdatedRecords where visit_end_datetime = 1
	)
	update p
		set data_source = @DataSource
	from provenance p
		inner join ProvenanceData pd
			on p.table_key = pd.visit_occurrence_id
			and p.column_name = pd.column_name
	where data_source <> @DataSource

	
	insert into cdm.visit_occurrence
	(
		person_id,
		visit_concept_id,
		visit_start_date,
		visit_start_datetime,
		visit_end_date,
		visit_end_datetime,
		visit_type_concept_id,
		provider_id,
		care_site_id,
		visit_source_value,
		visit_source_concept_id,
		admitted_from_concept_id,
		admitted_from_source_value,
		discharged_to_concept_id,
		discharged_to_source_value,
		HospitalProviderSpellNumber,
		RecordConnectionIdentifier
	)
	output inserted.visit_occurrence_id
	into @NewRecords (visit_occurrence_id)
	select
		p.person_id,
		r.visit_concept_id,
		r.visit_start_date,
		r.visit_start_datetime,
		r.visit_end_date,
		r.visit_end_datetime,
		r.visit_type_concept_id,
		r.provider_id,
		r.care_site_id,
		r.visit_source_value,
		r.visit_source_concept_id,
		r.admitted_from_concept_id,
		r.admitted_from_source_value,
		r.discharged_to_concept_id,
		r.discharged_to_source_value,
		r.HospitalProviderSpellNumber,
		r.RecordConnectionIdentifier
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
	where 
		(
			r.RecordConnectionIdentifier is not null 
			and not exists (
				select	*
				from cdm.visit_occurrence vo
				where vo.RecordConnectionIdentifier = r.RecordConnectionIdentifier
					and vo.person_id = p.person_id
				)
		)
		or
		(
			r.HospitalProviderSpellNumber is not null 
			and not exists (
				select	*
				from cdm.visit_occurrence vo
				where vo.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber
					and vo.person_id = p.person_id
			)
		);

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('person_id'),
	('visit_concept_id'),
	('visit_start_date'),
	('visit_start_datetime'),
	('visit_end_date'),
	('visit_end_datetime'),
	('visit_type_concept_id'),
	('provider_id'),
	('care_site_id'),
	('visit_source_value'),
	('visit_source_concept_id'),
	('admitted_from_concept_id'),
	('admitted_from_source_value'),
	('discharged_to_concept_id'),
	('discharged_to_source_value'),
	('HospitalProviderSpellNumber'),
	('RecordConnectionIdentifier');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		38, --	visit_occurrence
		visit_occurrence_id,
		lc.name,
		@DataSource
	from @NewRecords rl
	cross apply (select Name from @columns) lc;

end