alter table cdm.observation
	add RecordConnectionIdentifier varchar(50) null;

alter table cdm.observation
	add HospitalProviderSpellNumber int null;

create index IDX_cdm_observation_person_id_observation_date_observation_concept_id_RecordConnectionIdentifier_HospitalProviderSpellNumber
	on cdm.observation
	(
		person_id,
		observation_date,
		observation_concept_id,
		RecordConnectionIdentifier,
		HospitalProviderSpellNumber
	);

create type [cdm].[observation_row] as table
(
	nhs_number varchar(10) not null,
	[RecordConnectionIdentifier] [varchar](50) NULL,
	HospitalProviderSpellNumber int null,
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