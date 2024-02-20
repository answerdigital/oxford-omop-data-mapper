if object_id ('cdm.insert_update_drug_exposure') is not null
begin
drop procedure cdm.insert_update_drug_exposure;
end
go

create procedure cdm.insert_update_drug_exposure
	@rows cdm.drug_exposure_row readonly,
	@DataSource varchar(20)
as
begin

	declare @NewRecords as table
	(
		drug_exposure_id int
	);
	
	insert into cdm.drug_exposure
	(
		person_id,
		drug_concept_id,
		drug_exposure_start_date,
		drug_exposure_start_datetime,
		drug_exposure_end_date,
		drug_exposure_end_datetime,
		verbatim_end_date,
		drug_type_concept_id,
		stop_reason,
		refills,
		quantity,
		days_supply,
		sig,
		route_concept_id,
		lot_number,
		provider_id,
		visit_occurrence_id,
		visit_detail_id,
		drug_source_value,
		drug_source_concept_id,
		route_source_value,
		dose_unit_source_value,
		RecordConnectionIdentifier
	)
	output inserted.drug_exposure_id
	into @NewRecords (drug_exposure_id)
	select
		p.person_id,
		r.drug_concept_id,
		r.drug_exposure_start_date,
		r.drug_exposure_start_datetime,
		r.drug_exposure_end_date,
		r.drug_exposure_end_datetime,
		r.verbatim_end_date,
		r.drug_type_concept_id,
		r.stop_reason,
		r.refills,
		r.quantity,
		r.days_supply,
		r.sig,
		r.route_concept_id,
		r.lot_number,
		r.provider_id,
		(
			select
				top 1
					vd.visit_occurrence_id
			from cdm.visit_detail vd
			where vd.RecordConnectionIdentifier = r.RecordConnectionIdentifier
		) as visit_occurrence_id,
		(
			select
				top 1
					vd.visit_detail_id
			from cdm.visit_detail vd
			where vd.RecordConnectionIdentifier = r.RecordConnectionIdentifier
		) as visit_detail_id,
		r.drug_source_value,
		r.drug_source_concept_id,
		r.route_source_value,
		r.dose_unit_source_value,
		r.RecordConnectionIdentifier
	from @rows r
		inner join cdm.person p
			on r.nhs_number = p.person_source_value
	where 
		not exists (
			select	*
			from cdm.drug_exposure vo
			where vo.RecordConnectionIdentifier = r.RecordConnectionIdentifier
				and vo.drug_concept_id = r.drug_concept_id
		);

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('drug_exposure_id'),
	('person_id'),
	('drug_concept_id'),
	('drug_exposure_start_date'),
	('drug_exposure_start_datetime'),
	('drug_exposure_end_date'),
	('drug_exposure_end_datetime'),
	('verbatim_end_date'),
	('drug_type_concept_id'),
	('stop_reason'),
	('refills'),
	('quantity'),
	('days_supply'),
	('sig'),
	('route_concept_id'),
	('lot_number'),
	('provider_id'),
	('visit_occurrence_id'),
	('visit_detail_id'),
	('drug_source_value'),
	('drug_source_concept_id'),
	('route_source_value'),
	('dose_unit_source_value'),
	('RecordConnectionIdentifier');

	insert into provenance
	(
		table_type_id,
		table_key,
		column_name,
		data_source
	)
	select
		18, --	drug_exposure
		drug_exposure_id,
		lc.name,
		@DataSource
	from @NewRecords rl
	cross apply (select Name from @columns) lc;

end