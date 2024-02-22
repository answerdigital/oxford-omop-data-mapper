-- Extend field lengths.
alter table cdm.location alter column address_1 varchar(255) null;
alter table cdm.location alter column address_2 varchar(255) null;
alter table cdm.location alter column county varchar(255) null;
alter table cdm.location alter column location_source_value varchar(255) null;
alter table cdm.location alter column city varchar(255) null;