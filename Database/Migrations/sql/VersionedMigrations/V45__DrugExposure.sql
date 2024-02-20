create type [cdm].[drug_exposure_row] as table
(
	nhs_number varchar(10) not null,
	[drug_concept_id] [int] NOT NULL,
	[drug_exposure_start_date] [date] NOT NULL,
	[drug_exposure_start_datetime] [datetime] NULL,
	[drug_exposure_end_date] [date] NOT NULL,
	[drug_exposure_end_datetime] [datetime] NULL,
	[verbatim_end_date] [date] NULL,
	[drug_type_concept_id] [int] NOT NULL,
	[stop_reason] [varchar](20) NULL,
	[refills] [int] NULL,
	[quantity] [float] NULL,
	[days_supply] [int] NULL,
	[sig] [varchar](max) NULL,
	[route_concept_id] [int] NULL,
	[lot_number] [varchar](50) NULL,
	[provider_id] [int] NULL,
	[drug_source_value] [varchar](50) NULL,
	[drug_source_concept_id] [int] NULL,
	[route_source_value] [varchar](50) NULL,
	[dose_unit_source_value] [varchar](50) NULL,
	[RecordConnectionIdentifier] [varchar](50) NULL
);

alter table cdm.drug_exposure
	add RecordConnectionIdentifier varchar(50) null;

go

create index idx_cdm_drug_exposure_RecordConnectionIdentifier on cdm.drug_exposure (RecordConnectionIdentifier);