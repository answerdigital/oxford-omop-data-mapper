if object_id ('omop_staging.insert_cds_line10') is not null
begin
drop procedure omop_staging.insert_cds_line10;
end
go
go
create procedure omop_staging.insert_cds_line10
	@rows omop_staging.cds_line10_row readonly
as
begin
insert into omop_staging.cds_line10
select *
from   	@rows;

end