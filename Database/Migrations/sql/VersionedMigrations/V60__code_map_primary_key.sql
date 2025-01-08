alter table omop_staging.concept_code_map
	add constraint PK_omop_staging_concept_code_map_source_concept_id_target_concept_id
		primary key (
			source_concept_id,
			target_concept_id
		);