if object_id ('omop_staging.insert_cds_line08') is not null
begin
drop procedure omop_staging.insert_cds_line08;
end
go
go
create procedure omop_staging.insert_cds_line08
	@rows omop_staging.cds_line08_row readonly
as
begin
insert into omop_staging.cds_line08
select *
from   	@rows;

end