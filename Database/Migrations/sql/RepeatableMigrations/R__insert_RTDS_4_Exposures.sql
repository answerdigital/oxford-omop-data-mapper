if object_id ('omop_staging.insert_RTDS_4_Exposures') is not null
begin
	drop procedure omop_staging.insert_RTDS_4_Exposures;
end

go

create procedure omop_staging.insert_RTDS_4_Exposures		
	@rows omop_staging.RTDS_4_Exposures_row readonly	
as										
begin									
										
insert into omop_staging.RTDS_4_Exposures	
select *								
from @rows;							
										
end										