if object_id ('omop_staging.insert_oxford_gp_appointment_row') is not null
begin
	drop procedure omop_staging.insert_oxford_gp_appointment_row;
end

go

create procedure omop_staging.insert_oxford_gp_appointment_row		
	@rows omop_staging.oxford_gp_appointment_row readonly		
as												
begin											
												
insert into omop_staging.oxford_gp_appointment					
select *										
from @rows;								
												
end