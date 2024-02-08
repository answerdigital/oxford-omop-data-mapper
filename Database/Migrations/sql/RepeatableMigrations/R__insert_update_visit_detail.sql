if object_id ('cdm.insert_update_visit_detail') is not null
begin
drop procedure cdm.insert_update_visit_detail;
end
go

create procedure cdm.insert_update_visit_detail
	@rows cdm.visit_detail_row readonly,
	@DataSource varchar(20)
as
begin

	declare @NewRecords as table
	(
		visit_detail_id int
	);
	
	insert into cdm.visit_detail
	(
		person_id,
		visit_detail_concept_id,
		visit_detail_start_date,
		visit_detail_start_datetime,
		visit_detail_end_date,
		visit_detail_end_datetime,
		visit_detail_type_concept_id,
		provider_id,
		care_site_id,
		visit_detail_source_value,
		visit_detail_source_concept_id,
		admitted_from_concept_id,
		admitted_from_source_value,
		discharged_to_source_value,
		discharged_to_concept_id,
		visit_occurrence_id,
		HospitalProviderSpellNumber,
		RecordConnectionIdentifier
	)
	output inserted.visit_detail_id
	into @NewRecords (visit_detail_id)
	select
		p.person_id,
		r.visit_detail_concept_id,
		r.visit_detail_start_date,
		r.visit_detail_start_datetime,
		r.visit_detail_end_date,
		r.visit_detail_end_datetime,
		r.visit_detail_type_concept_id,
		r.provider_id,
		r.care_site_id,
		r.visit_detail_source_value,
		r.visit_detail_source_concept_id,
		r.admitted_from_concept_id,
		r.admitted_from_source_value,
		r.discharged_to_source_value,
		r.discharged_to_concept_id,
		(
			select
				top 1
					vo.visit_occurrence_id
			from cdm.visit_occurrence  vo
			where 
				(r.HospitalProviderSpellNumber is not null and vo.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber) 
				or
				(r.RecordConnectionIdentifier is not null and vo.RecordConnectionIdentifier = r.RecordConnectionIdentifier)
		) as visit_occurrence_id,

		r.HospitalProviderSpellNumber,
		r.RecordConnectionIdentifier
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
	where 
		not exists (
			select	*
			from cdm.visit_detail vo
			where 
				(vo.HospitalProviderSpellNumber is not null and vo.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber)
				or
				(vo.RecordConnectionIdentifier is not null and vo.RecordConnectionIdentifier = r.RecordConnectionIdentifier)
		);

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('visit_detail_id'),
	('person_id'),
	('visit_detail_concept_id'),
	('visit_detail_start_date'),
	('visit_detail_start_datetime'),
	('visit_detail_end_date'),
	('visit_detail_end_datetime'),
	('visit_detail_type_concept_id'),
	('provider_id'),
	('care_site_id'),
	('visit_detail_source_value'),
	('visit_detail_source_concept_id'),
	('admitted_from_concept_id'),
	('admitted_from_source_value'),
	('discharged_to_source_value'),
	('discharged_to_concept_id'),
	('preceding_visit_detail_id'),
	('parent_visit_detail_id'),
	('visit_occurrence_id');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		37, --	visit_detail
		visit_detail_id,
		lc.name,
		@DataSource
	from @NewRecords rl
	cross apply (select Name from @columns) lc;

end