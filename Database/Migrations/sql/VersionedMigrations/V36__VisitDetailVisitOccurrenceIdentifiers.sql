alter table cdm.visit_occurrence
	add HospitalProviderSpellNumber int null;
	
alter table cdm.visit_occurrence
	add RecordConnectionIdentifier varchar(50) null;

go

create unique index FI_cdm_visit_occurrence_HospitalProviderSpellNumber
	on cdm.visit_occurrence (HospitalProviderSpellNumber)
where HospitalProviderSpellNumber is not null;

create unique index FI_cdm_visit_occurrence_RecordConnectionIdentifier
	on cdm.visit_occurrence (RecordConnectionIdentifier)
where RecordConnectionIdentifier is not null;

go

alter table cdm.visit_detail
	add HospitalProviderSpellNumber int null;

alter table cdm.visit_detail
	add	RecordConnectionIdentifier varchar(50) null;

go

create unique index FI_cdm_visit_details_HospitalProviderSpellNumber
	on cdm.visit_detail (HospitalProviderSpellNumber)
where HospitalProviderSpellNumber is not null;

create unique index FI_cdm_visit_details_RecordConnectionIdentifier
	on cdm.visit_detail (RecordConnectionIdentifier)
where RecordConnectionIdentifier is not null;