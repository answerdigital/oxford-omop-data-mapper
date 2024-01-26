-- Extend field lengths.
alter table cdm.location alter column address_1 varchar(255) null;
alter table cdm.location alter column address_2 varchar(255) null;
alter table cdm.location alter column county varchar(255) null;
alter table cdm.location alter column location_source_value varchar(255) null;
alter table cdm.location alter column city varchar(255) null;

-- Update location_id to be an automatically incrementing identity column.
alter table cdm.care_site
	drop constraint fpk_care_site_location_id;

alter table cdm.person
	drop constraint fpk_person_location_id;

drop index idx_location_id_1 on cdm.location;

alter table cdm.location
	drop constraint xpk_location;

alter table cdm.location
	drop column location_id;
	
alter table cdm.location
	add location_id int not null identity (1, 1);

alter table cdm.location
	add constraint PK_cdm_location_location_id primary key (location_id);

alter table cdm.person
	add constraint FK_cdm_person_location_id	
		foreign key (location_id)
		references cdm.location (location_id);

alter table cdm.care_site
	add constraint FK_cdm_care_site_location_id
		foreign key (location_id)
		references cdm.location (location_id);