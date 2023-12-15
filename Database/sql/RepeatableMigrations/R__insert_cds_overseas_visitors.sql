if object_id ('omop_staging.insert_cds_overseas_visitors') is not null
begin
drop procedure omop_staging.insert_cds_overseas_visitors;
end
go
go
create procedure omop_staging.insert_cds_overseas_visitors
	@rows omop_staging.cds_overseas_visitors_row readonly
as
begin
insert into omop_staging.cds_overseas_visitors
select *
from   	@rows;

end