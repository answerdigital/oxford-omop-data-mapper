if object_id('omop_staging.generate_concept_code_map') is not null
begin
	drop procedure omop_staging.generate_concept_code_map;
end

go

create procedure omop_staging.generate_concept_code_map
as

begin

begin transaction

 truncate table omop_staging.concept_code_map;

 declare @date date = convert(date, getdate());

 with InvalidConceptMap as (
 	select
 		c1.concept_code as source_concept_code,
		c1.concept_id as source_concept_id,
		c2.concept_id as target_concept_id,
		c2.domain_id
 	from cdm.concept c1
		inner join cdm.concept_relationship cr
			on c1.concept_id = cr.concept_id_1
 		inner join cdm.concept c2
			on cr.concept_id_2 = c2.concept_id		
 	where not
 		(
 			c1.standard_concept is not null
 			and c1.standard_concept = 'S'
 			and @date between c1.valid_start_date and c1.valid_end_date
 		)
		and cr.relationship_id in ('Maps to', 'Source - RxNorm eq')
 		and c2.standard_concept is not null
 		and c2.standard_concept = 'S'
 		and @date between c2.valid_start_date and c2.valid_end_date
 ), Mapped as (
 	select -- Valid standard codes that we map to self
 		c.concept_code as source_concept_code,
		c.concept_id as source_concept_id,
 		c.concept_id as target_concept_id,
 		c.domain_id as domain_id,
 		convert(bit, 1) as mapped_from_standard
 	from cdm.concept c
 	where c.standard_concept is not null
 		and c.standard_concept = 'S'
 		and @date between c.valid_start_date and c.valid_end_date

 	union 

 	select -- Invalid codes that we can map to a standard code
 		icm.source_concept_code,
		icm.source_concept_id,
 		icm.target_concept_id as concept_id,
 		c.domain_id,
 		convert(bit, 0) as mapped_from_standard
 	from InvalidConceptMap icm
 		inner join cdm.concept c
 			on icm.target_concept_id = c.concept_id
 	where icm.target_concept_id is not null
 )
 insert into omop_staging.concept_code_map
 (
 	source_concept_code,
	source_concept_id,
 	target_concept_id,
 	domain_id,
 	mapped_from_standard
 )
 select
	distinct
		source_concept_code,
		source_concept_id,
 		target_concept_id,
 		domain_id,
 		mapped_from_standard
from Mapped;

-- Also map Snomed drug codes that do not map to any standard concepts to their RxNorm ingredient equivalent.

insert into omop_staging.concept_code_map
(
	source_concept_code,
	source_concept_id,
	target_concept_id,
	domain_id,
	mapped_from_standard
)
select
	c.concept_code as source_concept_code,
	c.concept_id as source_concept_id,
	rxnormConcept.concept_id as target_concept_id,
	'Drug' as domain_id, 
	convert(bit, 1) as mapped_from_standard
from cdm.concept c
	inner join cdm.concept dmdConcept 
		on c.concept_code = dmdConcept.concept_code
	inner join cdm.concept_relationship cr
		on dmdConcept.concept_id = cr.concept_id_1
	inner join cdm.concept rxnormConcept
		on cr.concept_id_2 = rxnormConcept.concept_id
where c.vocabulary_id = 'SNOMED'
	and c.domain_id = 'Drug'
	and not exists (
		select *
		from omop_staging.concept_code_map ccm
		where ccm.source_concept_id = c.concept_id
	)
	and dmdConcept.domain_id = 'Drug'
	and dmdConcept.vocabulary_id = 'DM+D'
	and dmdConcept.concept_class_id = 'VTM'
	and cr.relationship_id = 'Source - RxNorm eq'
	and rxnormConcept.standard_concept = 'S'
	and rxnormConcept.domain_id = 'Drug'
	and rxnormConcept.vocabulary_id in ('RxNorm', 'RxNorm Extension');

 commit transaction

end