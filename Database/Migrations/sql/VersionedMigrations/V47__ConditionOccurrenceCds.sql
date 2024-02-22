drop index FI_cdm_condition_occurrence on cdm.condition_occurrence;

alter table cdm.condition_occurrence
	drop column cds_diagnosis_id

alter table cdm.condition_occurrence
	add RecordConnectionIdentifier varchar(50) null;

go

create index idx_cdm_condition_occurrence_RecordConnectionIdentifier on cdm.condition_occurrence (RecordConnectionIdentifier);
