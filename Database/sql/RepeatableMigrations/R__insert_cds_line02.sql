if object_id ('omop_staging.insert_cds_line02') is not null
begin
drop procedure omop_staging.insert_cds_line02;
end
go
go
create procedure omop_staging.insert_cds_line02
	@rows omop_staging.cds_line02_row readonly
as
begin
insert into omop_staging.cds_line02
select *
from   	@rows;

end
go