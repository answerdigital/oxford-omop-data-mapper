if object_id ('omop_staging.insert_cds_line07') is not null
begin
drop procedure omop_staging.insert_cds_line07;
end
go
go
create procedure omop_staging.insert_cds_line07
	@rows omop_staging.cds_line07_row readonly
as
begin
insert into omop_staging.cds_line07
select *
from   	@rows;

end