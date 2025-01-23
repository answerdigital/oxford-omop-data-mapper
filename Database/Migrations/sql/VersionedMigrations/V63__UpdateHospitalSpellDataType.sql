if object_id ('cdm.insert_update_observation') is not null
begin
	drop procedure cdm.insert_update_observation
end

if object_id ('cdm.insert_update_visit_detail') is not null
begin
	drop procedure cdm.insert_update_visit_detail
end

if object_id ('cdm.insert_update_visit_occurrence') is not null
begin
	drop procedure cdm.insert_update_visit_occurrence
end


drop type cdm.observation_row
drop type cdm.visit_detail_row
drop type cdm.visit_occurrence_row


create type [cdm].[observation_row] as table
(
	nhs_number varchar(10) not null,
	[RecordConnectionIdentifier] [varchar](50) NULL,
	HospitalProviderSpellNumber varchar(100) null,
	[observation_concept_id] [int] NOT NULL,
	[observation_date] [date] NOT NULL,
	[observation_datetime] [datetime] NULL,
	[observation_type_concept_id] [int] NOT NULL,
	[value_as_number] [float] NULL,
	[value_as_string] [varchar](60) NULL,
	[value_as_concept_id] [int] NULL,
	[qualifier_concept_id] [int] NULL,
	[unit_concept_id] [int] NULL,
	[provider_id] [int] NULL,
	[observation_source_value] [varchar](50) NULL,
	[observation_source_concept_id] [int] NULL,
	[unit_source_value] [varchar](50) NULL,
	[qualifier_source_value] [varchar](50) NULL,
	[value_source_value] [varchar](50) NULL,
	[observation_event_id] [int] NULL,
	[obs_event_field_concept_id] [int] NULL
);

create type [cdm].[visit_detail_row] as table
(
	nhs_number varchar(10) not null,
	[HospitalProviderSpellNumber] varchar(100) NULL,
	[RecordConnectionIdentifier] [varchar](50) NULL,
	[visit_detail_concept_id] [int] NOT NULL,
	[visit_detail_start_date] [date] NOT NULL,
	[visit_detail_start_datetime] [datetime] NULL,
	[visit_detail_end_date] [date] NOT NULL,
	[visit_detail_end_datetime] [datetime] NULL,
	[visit_detail_type_concept_id] [int] NOT NULL,
	[provider_id] [int] NULL,
	[care_site_id] [int] NULL,
	[visit_detail_source_value] [varchar](50) NULL,
	[visit_detail_source_concept_id] [int] NULL,
	[admitted_from_concept_id] [int] NULL,
	[admitted_from_source_value] [varchar](50) NULL,
	[discharged_to_source_value] [varchar](50) NULL,
	[discharged_to_concept_id] [int] NULL
);


create type [cdm].[visit_occurrence_row] as table
(
	nhs_number varchar(10) not null,
	[HospitalProviderSpellNumber] varchar(100) NULL,
	[RecordConnectionIdentifier] [varchar](50) NULL,
	[visit_concept_id] [int] NOT NULL,
	[visit_start_date] [date] NOT NULL,
	[visit_start_datetime] [datetime] NULL,
	[visit_end_date] [date] NOT NULL,
	[visit_end_datetime] [datetime] NULL,
	[visit_type_concept_id] [int] NOT NULL,
	[provider_id] [int] NULL,
	[care_site_id] [int] NULL,
	[visit_source_value] [varchar](50) NULL,
	[visit_source_concept_id] [int] NULL,
	[admitted_from_concept_id] [int] NULL,
	[admitted_from_source_value] [varchar](50) NULL,
	[discharged_to_concept_id] [int] NULL,
	[discharged_to_source_value] [varchar](50) NULL
);

go

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
	where 
		not exists (
			select *
			from cdm.observation o
			where 
				(
					r.RecordConnectionIdentifier is not null and
					o.person_id = p.person_id and
					o.observation_date = r.observation_date	and
					o.observation_concept_id = r.observation_concept_id and
					o.RecordConnectionIdentifier = r.RecordConnectionIdentifier and
					(r.HospitalProviderSpellNumber is null or o.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber)
				)
				or
				(
					r.RecordConnectionIdentifier is null and
					o.person_id = p.person_id and
					o.observation_date = r.observation_date	and
					o.observation_concept_id = r.observation_concept_id
				)
		);

	declare @columns table (Name varchar(max));

	insert into @columns
	(
		Name
	)
	values
	('observation_id'),
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
	cross apply (select Name from @columns) lc;

end

go

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
			case 
				when r.HospitalProviderSpellNumber is not null then
				(
					select
						top 1
							vo.visit_occurrence_id
					from cdm.visit_occurrence  vo
					where vo.person_id = p.person_id 
						and vo.HospitalProviderSpellNumber = r.HospitalProviderSpellNumber
				)
			else
				(
					select
						top 1
							vo.visit_occurrence_id
					from cdm.visit_occurrence  vo
					where vo.person_id = p.person_id 
						and vo.RecordConnectionIdentifier = r.RecordConnectionIdentifier
				)
			end
		) as visit_occurrence_id,

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
				from cdm.visit_detail vo
				where vo.RecordConnectionIdentifier = r.RecordConnectionIdentifier
					and vo.person_id = p.person_id
				)
		)
		or
		(
			r.HospitalProviderSpellNumber is not null 
			and not exists (
				select	*
				from cdm.visit_detail vo
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

go

if object_id ('cdm.insert_update_visit_occurrence') is not null
begin
drop procedure cdm.insert_update_visit_occurrence;
end
go

create procedure cdm.insert_update_visit_occurrence
	@rows cdm.visit_occurrence_row readonly,
	@DataSource varchar(20)
as
begin

	declare @NewRecords as table
	(
		visit_occurrence_id int
	);
	
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
	('visit_occurrence_id'),
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