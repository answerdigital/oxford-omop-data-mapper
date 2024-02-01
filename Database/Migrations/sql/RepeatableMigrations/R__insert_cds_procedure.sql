if object_id ('omop_staging.insert_cds_procedure') is not null
begin
drop procedure omop_staging.insert_cds_procedure;
end
go
go
create procedure omop_staging.insert_cds_procedure
	@rows omop_staging.cds_procedure_row readonly
as
begin
insert into omop_staging.cds_procedure
select *
from   	@rows;

end