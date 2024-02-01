create type [cdm].[visit_occurrence_row] as table
(
	nhs_number varchar(10) not null,
	[HospitalProviderSpellNumber] [int] NULL,
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


create type [cdm].[visit_detail_row] as table
(
	nhs_number varchar(10) not null,
	[HospitalProviderSpellNumber] [int] NULL,
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