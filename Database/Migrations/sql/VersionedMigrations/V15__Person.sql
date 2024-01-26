-- Make the gender column nullable during the migration.
alter table cdm.person
	alter column gender_concept_id int null;

-- Make person_source_value not null as it should always be set.
alter table cdm.person
	alter column person_source_value varchar(50) not null;

-- Constrain the person table so that we have a maximum of one record per NHS Number.
alter table cdm.person
	add constraint UQ_cdm_person_person_source_value unique (person_source_value);