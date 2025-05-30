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
 		(
 			select 
 				top 1
 					c.concept_id
 			from cdm.concept_relationship cr
 				inner join cdm.concept c
 					on cr.concept_id_2 = c.concept_id
 			where cr.concept_id_1 = c1.concept_id
 				and cr.relationship_id = 'Maps to'
 				and c.standard_concept is not null
 				and c.standard_concept = 'S'
 				and @date between c.valid_start_date and c.valid_end_date
			order by c.concept_id desc
 		) as target_concept_id
 	from cdm.concept c1
 	where not
 	(
 		c1.standard_concept is not null
 		and c1.standard_concept = 'S'
 		and @date between c1.valid_start_date and c1.valid_end_date
 	)
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
 ), MappedWithRank as (
 	select
 		source_concept_code,
		source_concept_id,
 		target_concept_id,
 		domain_id,
 		mapped_from_standard,
 		row_number() over (partition by source_concept_id collate SQL_Latin1_General_CP1_CS_AS, domain_id order by mapped_from_standard desc) as [rank]
 	from Mapped
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
 from MappedWithRank
 where [Rank] = 1;

 commit transaction

 end