if object_id ('omop_staging.insert_oxford_gp_demographic_row') is not null
begin
	drop procedure omop_staging.insert_oxford_gp_demographic_row;
end

go

create procedure omop_staging.insert_oxford_gp_demographic_row		
	@rows omop_staging.oxford_gp_demographic_row readonly		
as												
begin											
												
insert into omop_staging.oxford_gp_demographic					
select *										
from @rows;								
												
end