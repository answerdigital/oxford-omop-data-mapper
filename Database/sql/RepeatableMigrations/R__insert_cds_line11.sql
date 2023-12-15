if object_id ('omop_staging.insert_cds_line11') is not null
begin
drop procedure omop_staging.insert_cds_line11;
end
go
go
create procedure omop_staging.insert_cds_line11
	@rows omop_staging.cds_line11_row readonly
as
begin
insert into omop_staging.cds_line11
select *
from   	@rows;

end