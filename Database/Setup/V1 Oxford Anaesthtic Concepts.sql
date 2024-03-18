insert into cdm.concept
(
	concept_id,
	concept_name,
	domain_id,
	vocabulary_id,
	concept_class_id,
	standard_concept,
	concept_code,
	valid_start_date,
	valid_end_date,
	invalid_reason
)
values
(
	2000500000, --concept_id
	'OMOP Oxford',--concept_name
	'Metadata', --domain_id
	'Vocabulary', --vocabulary_id
	'Vocabulary', --concept_class_id
	null, --standard_concept
	'OMOP generated', --concept_code
	'1970-01-01', --valid_start_date
	'2099-12-31', --valid_end_date
	null --invalid_reason
);

insert into cdm.vocabulary
(
	vocabulary_id,
	vocabulary_name,
	vocabulary_reference,
	vocabulary_version,
	vocabulary_concept_id
)
values
(
	'OXFORD', --vocabulary_id
	'OXFORD', --vocabulary_name
	'', --vocabulary_reference
	null, --vocabulary_version
	2000500000--vocabulary_concept_id
);


insert into cdm.concept
(
	concept_id,
	concept_name,
	domain_id,
	vocabulary_id,
	concept_class_id,
	standard_concept,
	concept_code,
	valid_start_date,
	valid_end_date,
	invalid_reason
)
values
(
	2000500001,-- concept_id
	'ANAESTHETIC GIVEN DURING LABOUR OR DELIVERY CODE',-- concept_name
	'Observation', -- domain_id
	'OXFORD', -- vocabulary_id
	'Observation',-- concept_class_id
	null, -- standard_concept
	'ANAESTHETIC GIVEN DURING LABOUR OR DELIVERY CODE',-- concept_code
	'1970-01-01', -- valid_start_date
	'2099-12-31', -- valid_end_date
	null -- invalid_reason
);

insert into cdm.concept
(
	concept_id,
	concept_name,
	domain_id,
	vocabulary_id,
	concept_class_id,
	standard_concept,
	concept_code,
	valid_start_date,
	valid_end_date,
	invalid_reason
)
values
(
	2000500002,-- concept_id
	'ANAESTHETIC GIVEN POST LABOUR OR DELIVERY CODE',-- concept_name
	'Observation', -- domain_id
	'OXFORD', -- vocabulary_id
	'Observation',-- concept_class_id
	null, -- standard_concept
	'ANAESTHETIC GIVEN POST LABOUR OR DELIVERY CODE',-- concept_code
	'1970-01-01', -- valid_start_date
	'2099-12-31', -- valid_end_date
	null -- invalid_reason
);