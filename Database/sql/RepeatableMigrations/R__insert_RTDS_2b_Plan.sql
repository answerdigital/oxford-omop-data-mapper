if object_id ('omop_staging.insert_RTDS_2b_Plan') is not null
begin
	drop procedure omop_staging.insert_RTDS_2b_Plan;
end

go

create procedure omop_staging.insert_RTDS_2b_Plan		
	@rows omop_staging.RTDS_2b_Plan_row readonly	
as										
begin									
										
insert into omop_staging.RTDS_2b_Plan	
select *								
from @rows;							
										
end										