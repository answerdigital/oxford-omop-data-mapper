create table omop_staging.concept_code_map
(
	source_concept_code varchar(50) not null,
	source_concept_id int not null,
	target_concept_id int not null,
	domain_id varchar(50) not null,
	mapped_from_standard bit not null
);

go

create nonclustered index IDX_omop_staging_concept_code_map_source_concept_id on omop_staging.concept_code_map (source_concept_id) include (target_concept_id);