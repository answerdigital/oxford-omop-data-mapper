if object_id ('cdm.prune_omop') is not null
begin
	drop procedure cdm.prune_omop;
end

go

create procedure cdm.prune_omop
as
begin

delete
from cdm.person
where gender_concept_id is null
	or person_source_value is null
	or race_concept_id is null
	or ethnicity_concept_id is null;

delete l
from cdm.location l
where not exists (
	select *
	from cdm.person p
	where p.location_id = l.location_id);

end