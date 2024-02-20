drop procedure cdm.insert_update_condition_occurrence;

drop type cdm.condition_occurrence_row;

create type cdm.condition_occurrence_row as table
(
	nhs_number varchar(10) not null,
	RecordConnectionIdentifier varchar(50) null,
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
