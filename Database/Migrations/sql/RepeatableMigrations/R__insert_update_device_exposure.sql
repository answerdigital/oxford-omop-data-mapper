if object_id ('cdm.insert_update_device_exposure') is not null
begin
drop procedure cdm.insert_update_device_exposure;
end
go

create procedure cdm.insert_update_device_exposure
	@rows cdm.device_exposure_row readonly,
	@DataSource varchar(100)
as
begin

	declare @NewRecords as table
	(
		device_exposure_id int
	);
	
	insert into cdm.device_exposure
	(
		person_id,
        device_concept_id,
        device_exposure_start_date,
        device_exposure_start_datetime,
        device_exposure_end_date,
        device_exposure_end_datetime,
        device_type_concept_id,
        unique_device_id,
        production_id,
        quantity,
        provider_id,
        visit_occurrence_id,
        visit_detail_id,
        device_source_value,
        device_source_concept_id,
        unit_concept_id,
        unit_source_value,
        unit_source_concept_id,
		RecordConnectionIdentifier,
        HospitalProviderSpellNumber
	)
	output inserted.device_exposure_id
	into @NewRecords (device_exposure_id)
	select
		p.person_id,
        r.device_concept_id,
        r.device_exposure_start_date,
        r.device_exposure_start_datetime,
        r.device_exposure_end_date,
        r.device_exposure_end_datetime,
        r.device_type_concept_id,
        r.unique_device_id,
        r.production_id,
        r.quantity,
        r.provider_id,
		(
			select
				top 1
					vo.visit_occurrence_id
			from cdm.visit_occurrence vo
			where vo.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber
			and vo.person_id = p.person_id
		) as visit_occurrence_id,
		(
			select
				top 1
					vd.visit_detail_id
			from cdm.visit_detail vd
			where vd.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber
			and vd.person_id = p.person_id
		) as visit_detail_id,
        r.device_source_value,
        r.device_source_concept_id,
        r.unit_concept_id,
        r.unit_source_value,
        r.unit_source_concept_id,
		r.RecordConnectionIdentifier,
        r.HospitalProviderSpellNumber
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
	where 
		not exists (
			select	*
			from cdm.device_exposure vo
			where vo.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber
				and vo.person_id = p.person_id
				and vo.device_concept_id = r.device_concept_id
		);

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		14, --	device_exposure
		device_exposure_id,
		'#row#',
		@DataSource
	from @NewRecords rl

end