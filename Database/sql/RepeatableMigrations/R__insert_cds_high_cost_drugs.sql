if object_id ('omop_staging.insert_cds_high_cost_drugs') is not null
begin
drop procedure omop_staging.insert_cds_high_cost_drugs;
end
go
go
create procedure omop_staging.insert_cds_high_cost_drugs
	@rows omop_staging.cds_high_cost_drugs_row readonly
as
begin
insert into omop_staging.cds_high_cost_drugs
select *
from   	@rows;

end