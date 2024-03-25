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
	2000500003,-- concept_id
	'History Of Alcohol (Current)',-- concept_name
	'Observation', -- domain_id
	'OXFORD', -- vocabulary_id
	'Observation',-- concept_class_id
	null, -- standard_concept
	'History Of Alcohol (Current)',-- concept_code
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
	2000500004,-- concept_id
	'History Of Alcohol (Past)',-- concept_name
	'Observation', -- domain_id
	'OXFORD', -- vocabulary_id
	'Observation',-- concept_class_id
	null, -- standard_concept
	'History Of Alcohol (Past)',-- concept_code
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
	2000500005,-- concept_id
	'Familial Cancer (Indicator)',-- concept_name
	'Observation', -- domain_id
	'OXFORD', -- vocabulary_id
	'Observation',-- concept_class_id
	null, -- standard_concept
	'Familial Cancer (Indicator)',-- concept_code
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
	2000500006,-- concept_id
	'Familial Cancer (Comment)',-- concept_name
	'Observation', -- domain_id
	'OXFORD', -- vocabulary_id
	'Observation',-- concept_class_id
	null, -- standard_concept
	'Familial Cancer (Comment)',-- concept_code
	'1970-01-01', -- valid_start_date
	'2099-12-31', -- valid_end_date
	null -- invalid_reason
);