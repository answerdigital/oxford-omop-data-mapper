alter table omop_staging.sus_CCMDS
alter column GeneratedRecordID varchar(70) null;

create index FI_omop_staging_sus_CCMDS_GeneratedRecordID on omop_staging.sus_CCMDS (GeneratedRecordID) where GeneratedRecordID is not null
create index FI_omop_staging_sus_APC_GeneratedRecordIdentifier on omop_staging.sus_APC (GeneratedRecordIdentifier) where GeneratedRecordIdentifier is not null

go
