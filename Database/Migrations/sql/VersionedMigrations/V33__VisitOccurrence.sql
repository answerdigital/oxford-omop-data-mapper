alter table cdm.condition_occurrence
	drop constraint xpk_condition_occurrence;

alter table cdm.condition_occurrence
	drop column condition_occurrence_id

alter table cdm.condition_occurrence
	add condition_occurrence_id int not null identity(1, 1);

alter table cdm.condition_occurrence
	add constraint PK_cdm_condition_occurrence_condition_occurrence_id
		primary key (condition_occurrence_id);

alter table cdm.condition_occurrence
	add cds_diagnosis_id int null;

go

create unique index FI_cdm_condition_occurrence on cdm.condition_occurrence (person_id, cds_diagnosis_id)
where cds_diagnosis_id is not null;

create type cdm.condition_occurrence_row as table
(
	nhs_number varchar(10) not null,
	cds_diagnosis_id int null,
	[condition_concept_id] [int] NOT NULL,
	[condition_start_date] [date] NOT NULL,
	[condition_start_datetime] [datetime] NULL,
	[condition_end_date] [date] NULL,
	[condition_end_datetime] [datetime] NULL,
	[condition_type_concept_id] [int] NOT NULL,
	[condition_status_concept_id] [int] NULL,
	[stop_reason] [varchar](20) NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[condition_source_value] [varchar](50) NULL,
	[condition_source_concept_id] [int] NULL,
	[condition_status_source_value] [varchar](50) NULL
);
