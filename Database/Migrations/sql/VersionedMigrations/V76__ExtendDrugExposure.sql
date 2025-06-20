drop procedure if exists cdm.insert_update_drug_exposure

drop type [cdm].[drug_exposure_row] ;

/****** Object:  UserDefinedTableType [cdm].[drug_exposure_row]    Script Date: 16/06/2025 12:10:33 ******/
CREATE TYPE [cdm].[drug_exposure_row] AS TABLE(
	[nhs_number] [varchar](10) NOT NULL,
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
	[drug_source_value] [varchar](500) NULL,
	[drug_source_concept_id] [int] NULL,
	[route_source_value] [varchar](50) NULL,
	[dose_unit_source_value] [varchar](50) NULL,
	[RecordConnectionIdentifier] [varchar](50) NULL
)
GO


alter table cdm.drug_exposure
	alter column drug_source_value varchar(500) null;