if object_id ('omop_staging.insert_cds_line03') is not null
begin
drop procedure omop_staging.insert_cds_line03;
end
go
go
create procedure omop_staging.insert_cds_line03
	@rows omop_staging.cds_line03_row readonly
as
begin
insert into omop_staging.cds_line03
select *
from   	@rows;

end
go