if object_id ('omop_staging.insert_oxford_gp_event_row') is not null
begin
	drop procedure omop_staging.insert_oxford_gp_event_row;
end

go

create procedure omop_staging.insert_oxford_gp_event_row		
	@rows omop_staging.oxford_gp_event_row readonly		
as												
begin											
												
insert into omop_staging.oxford_gp_event					
select *										
from @rows;								
												
end