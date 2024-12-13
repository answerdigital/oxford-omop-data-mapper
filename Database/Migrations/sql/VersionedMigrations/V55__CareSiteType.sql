create type [cdm].[care_site_row] as table
(
	[care_site_name] [varchar](50) NULL,
	[place_of_service_concept_id] [int] NULL,
	[location_id] [int] NULL,
	[care_site_source_value] [varchar](50) NULL,
	[place_of_service_source_value] [varchar](50) NULL
);