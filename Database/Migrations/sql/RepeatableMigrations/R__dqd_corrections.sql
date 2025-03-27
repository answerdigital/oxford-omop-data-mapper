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

end