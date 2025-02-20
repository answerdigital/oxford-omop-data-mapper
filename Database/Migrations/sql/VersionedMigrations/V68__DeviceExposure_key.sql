drop procedure cdm.insert_update_device_exposure;

go

drop type [cdm].[device_exposure_row];

go

create type [cdm].[device_exposure_row] as table
(
    nhs_number varchar(10) not null,
    [device_concept_id] [int] NOT NULL,
    [device_exposure_start_date] [date] NOT NULL,
    [device_exposure_start_datetime] [datetime] NULL,
    [device_exposure_end_date] [date] NULL,
    [device_exposure_end_datetime] [datetime] NULL,
    [device_type_concept_id] [int] NOT NULL,
    [unique_device_id] [varchar](50) NULL,
    [production_id] [varchar](50) NULL,
    [quantity] [float] NULL,
    [provider_id] [int] NULL,
    [visit_occurrence_id] [int] NULL,
    [visit_detail_id] [int] NULL,
    [device_source_value] [varchar](50) NULL,
    [device_source_concept_id] [int] NULL,
    [unit_concept_id] [int] NULL,
    [unit_source_value] [varchar](50) NULL,
    [unit_source_concept_id] [int] NULL,
    [RecordConnectionIdentifier] [varchar](50) NULL,
    [HospitalProviderSpellNumber] [varchar](100) NULL
);

alter table cdm.device_exposure
    add HospitalProviderSpellNumber varchar(100) null;

go

create index idx_cdm_device_exposure_HospitalProviderSpellNumber on cdm.device_exposure (HospitalProviderSpellNumber);