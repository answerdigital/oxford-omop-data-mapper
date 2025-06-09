if object_id ('omop_staging.insert_oxford_gp_medication_row') is not null
begin
	drop procedure omop_staging.insert_oxford_gp_medication_row;
end

go

create procedure omop_staging.insert_oxford_gp_medication_row		
	@rows omop_staging.oxford_gp_medication_row readonly		
as												
begin											
												
insert into omop_staging.oxford_gp_medication					
select *										
from @rows;								
												
end