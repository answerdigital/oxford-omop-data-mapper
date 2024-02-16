alter table cdm.procedure_occurrence
	drop constraint xpk_procedure_occurrence;

alter table cdm.procedure_occurrence
	drop column procedure_occurrence_id;

go

alter table cdm.procedure_occurrence
	add procedure_occurrence_id int not null identity;

alter table  cdm.procedure_occurrence
	add constraint PK_cdm_procedure_occurrence_procedure_occurrence_id
		primary key (
			procedure_occurrence_id
		);

alter table cdm.procedure_occurrence
	add RecordConnectionIdentifier varchar(50) null;