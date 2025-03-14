

drop index FI_cdm_visit_occurrence_HospitalProviderSpellNumber on cdm.visit_occurrence
drop index IDX_cdm_visit_occurrence_RecordConnectionIdentifier_person_id on cdm.visit_occurrence

go

create index FI_cdm_visit_occurrence_person_id_RecordConnectionIdentifier on cdm.visit_occurrence (person_id, RecordConnectionIdentifier) include (visit_occurrence_id) where RecordConnectionIdentifier is not null
create index FI_cdm_visit_occurrence_person_id_HospitalProviderSpellNumber on cdm.visit_occurrence (person_id, HospitalProviderSpellNumber) include (visit_occurrence_id) where HospitalProviderSpellNumber is not null

go

drop index idx_cdm_condition_occurrence_RecordConnectionIdentifier_condition_concept_id_condition_start_date on cdm.condition_occurrence;

go

create index FI_cdm_ondition_occurrence_person_id_RecordConnectionIdentifier on cdm.condition_occurrence (person_id, RecordConnectionIdentifier) where RecordConnectionIdentifier is not null;

go

drop index idx_cdm_procedure_occurrence_RecordConnectionIdentifier on cdm.procedure_occurrence;

go

create index FI_cdm_procedure_occurrence_person_id_RecordConnectionIdentifier on cdm.procedure_occurrence (person_id, RecordConnectionIdentifier)  where RecordConnectionIdentifier is not null;

go

drop index IDX_cdm_observation_person_id_observation_date_observation_concept_id_RecordConnectionIdentifier_HospitalProviderSpellNumber on cdm.observation;

go

create index FI_cdm_observation_person_id_RecordConnectionIdentifier on cdm.observation (person_id, RecordConnectionIdentifier) where RecordConnectionIdentifier is not null;
create index FI_cdm_observation_person_id_HospitalProviderSpellNumber on cdm.observation (person_id, HospitalProviderSpellNumber) where HospitalProviderSpellNumber is not null

go

drop index [IDX_cdm_visit_details_HospitalProviderSpellNumber_person_id] ON [cdm].[visit_detail]

go

CREATE NONCLUSTERED INDEX [FI_cdm_visit_details_HospitalProviderSpellNumber_person_id] ON [cdm].[visit_detail]
(
	[person_id] ASC,
	[HospitalProviderSpellNumber] ASC
)
INCLUDE([visit_detail_id])

go

DROP INDEX [IDX_cdm_visit_details_RecordConnectionIdentifier_person_id] ON [cdm].[visit_detail]
GO


/****** Object:  Index [IDX_cdm_visit_details_RecordConnectionIdentifier_person_id]    Script Date: 14/03/2025 14:07:54 ******/
CREATE NONCLUSTERED INDEX [FI_cdm_visit_details_RecordConnectionIdentifier_person_id] ON [cdm].[visit_detail]
(
	[person_id] ASC,
	[RecordConnectionIdentifier] ASC
)
INCLUDE([visit_detail_id]) 
where RecordConnectionIdentifier is not null;

go

drop index idx_cdm_drug_exposure_RecordConnectionIdentifier on cdm.drug_exposure

go

create index FI_cdm_drug_exposure_person_id_RecordConnectionIdentifier on cdm.drug_exposure (person_id, RecordConnectionIdentifier) where RecordConnectionIdentifier is not null;
