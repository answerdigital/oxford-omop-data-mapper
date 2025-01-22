-- Observation

drop index [IDX_cdm_observation_person_id_observation_date_observation_concept_id_RecordConnectionIdentifier_HospitalProviderSpellNumber] on cdm.observation;

go

EXEC sp_rename 'cdm.observation.HospitalProviderSpellNumber', 'HospitalProviderSpellNumber1', 'COLUMN';

alter table cdm.observation
	add HospitalProviderSpellNumber varchar(100) null;

go

update cdm.observation
set HospitalProviderSpellNumber = HospitalProviderSpellNumber1;

alter table cdm.observation
	drop column HospitalProviderSpellNumber1;

go

/****** Object:  Index [IDX_cdm_observation_person_id_observation_date_observation_concept_id_RecordConnectionIdentifier_HospitalProviderSpellNumber]    Script Date: 20/01/2025 14:20:33 ******/
CREATE NONCLUSTERED INDEX [IDX_cdm_observation_person_id_observation_date_observation_concept_id_RecordConnectionIdentifier_HospitalProviderSpellNumber] ON [cdm].[observation]
(
	[person_id] ASC,
	[observation_date] ASC,
	[observation_concept_id] ASC,
	[RecordConnectionIdentifier] ASC,
	[HospitalProviderSpellNumber] ASC
)
GO


-- Visit detail


drop index [IDX_cdm_visit_details_HospitalProviderSpellNumber_person_id] ON [cdm].[visit_detail];

go

EXEC sp_rename 'cdm.visit_detail.HospitalProviderSpellNumber', 'HospitalProviderSpellNumber1', 'COLUMN';

go

alter table cdm.visit_detail
	add HospitalProviderSpellNumber varchar(100) null;

go

update cdm.visit_detail
set HospitalProviderSpellNumber = HospitalProviderSpellNumber1;

go

alter table cdm.visit_detail
	drop column HospitalProviderSpellNumber1;


CREATE NONCLUSTERED INDEX [IDX_cdm_visit_details_HospitalProviderSpellNumber_person_id] ON [cdm].[visit_detail]
(
	[person_id] ASC,
	[HospitalProviderSpellNumber] ASC
)
INCLUDE([visit_occurrence_id])


-- Visit occuurrence

DROP INDEX [FI_cdm_visit_occurrence_HospitalProviderSpellNumber] ON [cdm].[visit_occurrence]

GO

EXEC sp_rename 'cdm.visit_occurrence.HospitalProviderSpellNumber', 'HospitalProviderSpellNumber1', 'COLUMN';

go

alter table cdm.visit_occurrence
	add HospitalProviderSpellNumber varchar(100) null;

go

update cdm.visit_occurrence
set HospitalProviderSpellNumber = HospitalProviderSpellNumber1;

alter table cdm.visit_occurrence
	drop column HospitalProviderSpellNumber1;

CREATE UNIQUE NONCLUSTERED INDEX [FI_cdm_visit_occurrence_HospitalProviderSpellNumber] ON [cdm].[visit_occurrence]
(
	[HospitalProviderSpellNumber] ASC
)
WHERE ([HospitalProviderSpellNumber] IS NOT NULL)
