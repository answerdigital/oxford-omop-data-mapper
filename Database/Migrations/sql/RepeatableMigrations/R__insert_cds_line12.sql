if object_id ('omop_staging.insert_cds_line12') is not null
begin
drop procedure omop_staging.insert_cds_line12;
end
go
go
create procedure omop_staging.insert_cds_line12
	@rows omop_staging.cds_line12_row readonly
as
begin
insert into omop_staging.cds_line12
select *
from   	@rows;

end