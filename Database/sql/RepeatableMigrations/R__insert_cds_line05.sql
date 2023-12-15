if object_id ('omop_staging.insert_cds_line05') is not null
begin
drop procedure omop_staging.insert_cds_line05;
end
go
go
create procedure omop_staging.insert_cds_line05
	@rows omop_staging.cds_line05_row readonly
as
begin
insert into omop_staging.cds_line05
select *
from   	@rows;

end