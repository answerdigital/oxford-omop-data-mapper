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
	'NHS Ethnic Category',
	'NHS Ethnic Category',
	'https://www.datadictionary.nhs.uk/data_elements/ethnic_category.html#element_ethnic_category.description',
	2023,
	33095
)


insert into cdm.concept
(
	concept_id,
	concept_name,
	domain_id,
	vocabulary_id,
	concept_class_id,
	--standard_concept,
	concept_code,
	valid_start_date,
	valid_end_date
)
values 
(700385,	'White - British'	,'Race'	,'NHS Ethnic Category'	,'Race',		'A'	,'20230522',	'20991231'),
(700386,	'White - Irish'	,'Race'	,'NHS Ethnic Category'	,'Race',		'B'	,'20230522',	'20991231'),
(700387,	'White - Any other White background'	,'Race'	,'NHS Ethnic Category'	,'Race',		'C'	,'20230522',	'20991231'),
(700388,	'Mixed - White and Black Caribbean'	,'Race'	,'NHS Ethnic Category'	,'Race',		'D'	,'20230522',	'20991231'),
(700389,	'Mixed - White and Black African'	,'Race'	,'NHS Ethnic Category'	,'Race',		'E'	,'20230522',	'20991231'),
(700390,	'Mixed - White and Asian'	,'Race'	,'NHS Ethnic Category'	,'Race',		'F'	,'20230522',	'20991231'),
(700391,	'Mixed - Any other mixed background'	,'Race'	,'NHS Ethnic Category'	,'Race',		'G'	,'20230522',	'20991231'),
(700362,	'Asian or Asian British - Indian'	,'Race'	,'NHS Ethnic Category'	,'Race',		'H'	,'20230522',	'20991231'),
(700363,	'Asian or Asian British - Pakistani'	,'Race'	,'NHS Ethnic Category'	,'Race',		'J'	,'20230522',	'20991231'),
(700364,	'Asian or Asian British - Bangladeshi'	,'Race'	,'NHS Ethnic Category'	,'Race',		'K'	,'20230522',	'20991231'),
(700365,	'Asian or Asian British - Any other Asian background'	,'Race'	,'NHS Ethnic Category'	,'Race',		'L'	,'20230522',	'20991231'),
(700366,	'Black or Black British - Caribbean'	,'Race'	,'NHS Ethnic Category'	,'Race',		'M'	,'20230522',	'20991231'),
(700367,	'Black or Black British - African'	,'Race'	,'NHS Ethnic Category'	,'Race',		'N'	,'20230522',	'20991231'),
(700368,	'Black or Black British - Any other Black background'	,'Race'	,'NHS Ethnic Category'	,'Race',		'P'	,'20230522',	'20991231'),
(700369,	'Other Ethnic Groups - Chinese'	,'Race'	,'NHS Ethnic Category'	,'Race',		'R'	,'20230522',	'20991231');
