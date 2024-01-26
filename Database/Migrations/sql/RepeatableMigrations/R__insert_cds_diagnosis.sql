if object_id ('omop_staging.insert_cds_diagnosis') is not null
begin
drop procedure omop_staging.insert_cds_diagnosis;
end
go
go
create procedure omop_staging.insert_cds_diagnosis
	@rows omop_staging.cds_diagnosis_row readonly
as
begin
insert into omop_staging.cds_diagnosis
select *
from   	@rows;

end