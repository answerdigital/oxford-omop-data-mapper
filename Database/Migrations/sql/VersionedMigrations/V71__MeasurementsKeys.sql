alter table cdm.measurement
	add 
		RecordConnectionIdentifier varchar(50) null,
		HospitalProviderSpellNumber varchar(100) null;

go

create index FI_cdm_measurement_person_id_RecordConnectionIdentifier on cdm.measurement (person_id, RecordConnectionIdentifier) where RecordConnectionIdentifier is not null
create index FI_cdm_measurement_person_id_HospitalProviderSpellNumber on cdm.measurement (person_id, HospitalProviderSpellNumber) where HospitalProviderSpellNumber is not null

go

drop type cdm.measurement_row

drop procedure if exists staging.insert_update_measurement


go

create type cdm.measurement_row as table
(
	nhs_number varchar(10) not null,
	[measurement_concept_id] [int] NOT NULL,
	[measurement_date] [date] NOT NULL,
	[measurement_datetime] [datetime] NULL,
	[measurement_time] [varchar](10) NULL,
	[measurement_type_concept_id] [int] NOT NULL,
	[operator_concept_id] [int] NULL,
	[value_as_number] [float] NULL,
	[value_as_concept_id] [int] NULL,
	[unit_concept_id] [int] NULL,
	[range_low] [float] NULL,
	[range_high] [float] NULL,
	[provider_id] [int] NULL,
	[measurement_source_value] [varchar](50) NULL,
	[measurement_source_concept_id] [int] NULL,
	[unit_source_value] [varchar](50) NULL,
	[unit_source_concept_id] [int] NULL,
	[value_source_value] [varchar](50) NULL,
	[measurement_event_id] [int] NULL,
	[meas_event_field_concept_id] [int] NULL,
	RecordConnectionIdentifier varchar(50) null,
	HospitalProviderSpellNumber varchar(100) null
);