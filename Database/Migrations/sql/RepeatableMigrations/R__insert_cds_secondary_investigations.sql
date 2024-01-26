if object_id ('omop_staging.insert_cds_secondary_investigations') is not null
begin
drop procedure omop_staging.insert_cds_secondary_investigations;
end
go
go
create procedure omop_staging.insert_cds_secondary_investigations
	@rows omop_staging.cds_secondary_investigations_row readonly
as
begin
insert into omop_staging.cds_secondary_investigations
select *
from   	@rows;

end
go