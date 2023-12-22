create type cdm.person_row as table
(
	gender_concept_id	int null,
	year_of_birth	int null, 
	month_of_birth	int null, 
	day_of_birth	int null, 
	birth_datetime	datetime null, 
	race_concept_id	int null, 
	ethnicity_concept_id	int null, 
	provider_id	int null, 
	care_site_id	int null, 
	person_source_value	varchar (max) not null, 
	gender_source_value	varchar (max) null, 
	gender_source_concept_id	int null, 
	race_source_value	varchar (max) null, 
	race_source_concept_id	int null, 
	ethnicity_source_value	varchar (max) null, 
	ethnicity_source_concept_id	int null 
);