if object_id ('cdm.prune_omop') is not null
begin
	drop procedure cdm.prune_omop;
end

go

create procedure cdm.prune_omop
as
begin

declare @personsToDelete table
(
	person_id int not null
);

insert into @personsToDelete
(
	person_id
)
select
	person_id
from cdm.person
where gender_concept_id is null
	or person_source_value is null
	or race_concept_id is null
	or ethnicity_concept_id is null;

delete co
from cdm.condition_occurrence co
	inner join @personsToDelete p
		on co.person_id = p.person_id;

delete vd
from cdm.visit_detail vd
	inner join @personsToDelete p
		on vd.person_id = p.person_id;

delete vo
from cdm.visit_occurrence vo
	inner join @personsToDelete p
		on vo.person_id = p.person_id;

delete p
from cdm.person p
	inner join @personsToDelete ptd
		on p.person_id = ptd.person_id;

delete l
from cdm.location l
where not exists (
	select *
	from cdm.person p
	where p.location_id = l.location_id);

end