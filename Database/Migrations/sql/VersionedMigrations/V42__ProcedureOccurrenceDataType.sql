create type [cdm].[procedure_occurrence_row] as table
(
	nhs_number varchar(10) not null,
	[procedure_concept_id] [int] NOT NULL,
	[procedure_date] [date] NOT NULL,
	[procedure_datetime] [datetime] NULL,
	[procedure_end_date] [date] NULL,
	[procedure_end_datetime] [datetime] NULL,
	[procedure_type_concept_id] [int] NOT NULL,
	[modifier_concept_id] [int] NULL,
	[quantity] [int] NULL,
	[provider_id] [int] NULL,
	[visit_occurrence_id] [int] NULL,
	[visit_detail_id] [int] NULL,
	[procedure_source_value] [varchar](50) NULL,
	[procedure_source_concept_id] [int] NULL,
	[modifier_source_value] [varchar](50) NULL,
	[RecordConnectionIdentifier] [varchar](50) NULL
 )