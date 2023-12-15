if object_id ('omop_staging.insert_cds_critial_care_activity_codes') is not null
begin
drop procedure omop_staging.insert_cds_critial_care_activity_codes;
end
go
go
create procedure omop_staging.insert_cds_critial_care_activity_codes
	@rows omop_staging.cds_critial_care_activity_codes_row readonly
as
begin
insert into omop_staging.cds_critial_care_activity_codes
select *
from   	@rows;

end