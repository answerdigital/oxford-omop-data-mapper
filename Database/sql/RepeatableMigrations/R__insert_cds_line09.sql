if object_id ('omop_staging.insert_cds_line09') is not null
begin
drop procedure omop_staging.insert_cds_line09;
end
go
go
create procedure omop_staging.insert_cds_line09
	@rows omop_staging.cds_line09_row readonly
as
begin
insert into omop_staging.cds_line09
select *
from   	@rows;

end