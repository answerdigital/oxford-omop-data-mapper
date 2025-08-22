if object_id ('cdm.dqd_corrections') is not null
begin
drop procedure cdm.dqd_corrections
end
go

create procedure cdm.dqd_corrections
as
begin

update p
set p.gender_concept_id = 8507
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
	JOIN cdm.concept_ancestor ca
		ON ca.descendant_concept_id = cdmTable.CONDITION_CONCEPT_ID
			
WHERE ca.ancestor_concept_id IN (4090861, 4025213)
AND p.gender_concept_id <> 8507 


update p
set p.gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 201801
	AND p.gender_concept_id <> 8532 


update p
set p.gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 200052
	AND p.gender_concept_id <> 8532 



update p
set p.gender_concept_id = 8507
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 79758
	AND p.gender_concept_id <> 8507 

update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 4194652
	AND p.gender_concept_id <> 8532 

update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 437501
	AND p.gender_concept_id <> 8532 
		
update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id		
WHERE cdmTable.CONDITION_CONCEPT_ID = 201817
	AND p.gender_concept_id <> 8532 
		
update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id	
WHERE cdmTable.CONDITION_CONCEPT_ID = 201238
	AND p.gender_concept_id <> 8532 
		
update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id	
WHERE cdmTable.CONDITION_CONCEPT_ID = 195500
	AND p.gender_concept_id <> 8532 
		
update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id	
WHERE cdmTable.CONDITION_CONCEPT_ID = 195197
	AND p.gender_concept_id <> 8532 


update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 437501
	AND p.gender_concept_id <> 8532 

update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 201817
	AND p.gender_concept_id <> 8532 

update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 201238
	AND p.gender_concept_id <> 8532 


update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
			
WHERE cdmTable.CONDITION_CONCEPT_ID = 195500
	AND p.gender_concept_id <> 8532 


update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 197236
  	AND p.gender_concept_id <> 8532 

update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 199764
  	AND p.gender_concept_id <> 8532 

update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 4162860
  	AND p.gender_concept_id <> 8532

update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 441805
  	AND p.gender_concept_id <> 8532 

update p
set gender_concept_id = 8532
FROM cdm.CONDITION_OCCURRENCE cdmTable
	JOIN cdm.person p
		ON cdmTable.person_id = p.person_id
WHERE cdmTable.CONDITION_CONCEPT_ID = 196359
  	AND p.gender_concept_id <> 8532 



declare @deleteddeaths table
(
	person_id int not null
);

delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DEVICE_EXPOSURE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.DEVICE_EXPOSURE_END_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DEVICE_EXPOSURE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.DEVICE_EXPOSURE_END_DATETIME AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DEVICE_EXPOSURE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.DEVICE_EXPOSURE_START_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DEVICE_EXPOSURE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.DEVICE_EXPOSURE_START_DATETIME AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.PROCEDURE_OCCURRENCE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.PROCEDURE_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.PROCEDURE_OCCURRENCE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.PROCEDURE_DATETIME AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.PROCEDURE_OCCURRENCE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.PROCEDURE_END_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.PROCEDURE_OCCURRENCE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.PROCEDURE_END_DATETIME AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_DETAIL cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.VISIT_DETAIL_END_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_DETAIL cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.VISIT_DETAIL_START_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_DETAIL cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.VISIT_DETAIL_START_DATETIME AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_OCCURRENCE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.VISIT_END_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_OCCURRENCE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.VISIT_START_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_OCCURRENCE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.VISIT_START_DATETIME AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.CONDITION_ERA cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.CONDITION_ERA_END_DATE IS NOT NULL 
    AND CAST(cdmTable.CONDITION_ERA_END_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DEVICE_EXPOSURE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.DEVICE_EXPOSURE_END_DATE IS NOT NULL 
    AND CAST(cdmTable.DEVICE_EXPOSURE_END_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DEVICE_EXPOSURE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.DEVICE_EXPOSURE_END_DATETIME IS NOT NULL 
    AND CAST(cdmTable.DEVICE_EXPOSURE_END_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DEVICE_EXPOSURE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.DEVICE_EXPOSURE_START_DATE IS NOT NULL 
    AND CAST(cdmTable.DEVICE_EXPOSURE_START_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DEVICE_EXPOSURE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.DEVICE_EXPOSURE_START_DATETIME IS NOT NULL 
    AND CAST(cdmTable.DEVICE_EXPOSURE_START_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.OBSERVATION cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.OBSERVATION_DATE IS NOT NULL 
    AND CAST(cdmTable.OBSERVATION_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.OBSERVATION cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.OBSERVATION_DATETIME IS NOT NULL 
    AND CAST(cdmTable.OBSERVATION_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.PROCEDURE_OCCURRENCE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.PROCEDURE_DATE IS NOT NULL 
    AND CAST(cdmTable.PROCEDURE_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.PROCEDURE_OCCURRENCE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.PROCEDURE_DATETIME IS NOT NULL 
    AND CAST(cdmTable.PROCEDURE_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.PROCEDURE_OCCURRENCE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.PROCEDURE_END_DATE IS NOT NULL 
    AND CAST(cdmTable.PROCEDURE_END_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.PROCEDURE_OCCURRENCE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.PROCEDURE_END_DATETIME IS NOT NULL 
    AND CAST(cdmTable.PROCEDURE_END_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_DETAIL cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.VISIT_DETAIL_END_DATE IS NOT NULL 
    AND CAST(cdmTable.VISIT_DETAIL_END_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_DETAIL cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.VISIT_DETAIL_END_DATETIME IS NOT NULL 
    AND CAST(cdmTable.VISIT_DETAIL_END_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_DETAIL cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.VISIT_DETAIL_START_DATE IS NOT NULL 
    AND CAST(cdmTable.VISIT_DETAIL_START_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_DETAIL cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.VISIT_DETAIL_START_DATETIME IS NOT NULL 
    AND CAST(cdmTable.VISIT_DETAIL_START_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_OCCURRENCE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.VISIT_END_DATE IS NOT NULL 
    AND CAST(cdmTable.VISIT_END_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_OCCURRENCE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.VISIT_END_DATETIME IS NOT NULL 
    AND CAST(cdmTable.VISIT_END_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_OCCURRENCE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.VISIT_START_DATE IS NOT NULL 
    AND CAST(cdmTable.VISIT_START_DATE AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.VISIT_OCCURRENCE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE cdmTable.VISIT_START_DATETIME IS NOT NULL 
    AND CAST(cdmTable.VISIT_START_DATETIME AS DATE) > DATEADD(day, 60, de.death_date)


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DRUG_EXPOSURE cdmTable

JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.DRUG_EXPOSURE_END_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DRUG_EXPOSURE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.DRUG_EXPOSURE_END_DATETIME AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DRUG_EXPOSURE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.DRUG_EXPOSURE_START_DATE AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete de
output deleted.person_id
into @deleteddeaths
FROM cdm.DRUG_EXPOSURE cdmTable
    
JOIN cdm.death de 
    ON cdmTable.person_id = de.person_id
WHERE CAST(cdmTable.DRUG_EXPOSURE_START_DATETIME AS DATE) > DATEADD(day, 60, CAST(de.death_date AS DATE))


delete p
from provenance p
	inner join @deleteddeaths d
		on p.table_key = d.person_id
where p.table_type_id = 13 -- death

end