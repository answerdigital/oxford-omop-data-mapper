create type [cdm].[death_row] as table
(
	nhs_number varchar(10) not null,
	[death_date] [date] NOT NULL,
	[death_datetime] [datetime] NULL,
	[death_type_concept_id] [int] NULL,
	[cause_concept_id] [int] NULL,
	[cause_source_value] [varchar](50) NULL,
	[cause_source_concept_id] [int] NULL
);