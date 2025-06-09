if object_id ('omop_staging.insert_oxford_prescribing_row') is not null
begin
	drop procedure omop_staging.insert_oxford_prescribing_row;
end

go

create procedure omop_staging.insert_oxford_prescribing_row		
	@rows omop_staging.oxford_prescribing_row readonly		
as												
begin											
												
insert into omop_staging.oxford_prescribing					
select *										
from @rows;								
												
end