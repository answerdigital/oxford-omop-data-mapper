if object_id ('omop_staging.insert_cds_birth_details') is not null
begin
drop procedure omop_staging.insert_cds_birth_details;
end
go
go
create procedure omop_staging.insert_cds_birth_details
	@rows omop_staging.cds_birth_details_row readonly
as
begin
insert into omop_staging.cds_birth_details
select *
from   	@rows;

end