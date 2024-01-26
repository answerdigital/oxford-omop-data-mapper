if object_id ('omop_staging.insert_cds_line06') is not null
begin
drop procedure omop_staging.insert_cds_line06;
end
go
go
create procedure omop_staging.insert_cds_line06
	@rows omop_staging.cds_line06_row readonly
as
begin
insert into omop_staging.cds_line06
select *
from   	@rows;

end