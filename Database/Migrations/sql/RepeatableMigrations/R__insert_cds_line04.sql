if object_id ('omop_staging.insert_cds_line04') is not null
begin
drop procedure omop_staging.insert_cds_line04;
end
go
go
create procedure omop_staging.insert_cds_line04
	@rows omop_staging.cds_line04_row readonly
as
begin
insert into omop_staging.cds_line04
select *
from   	@rows;

end