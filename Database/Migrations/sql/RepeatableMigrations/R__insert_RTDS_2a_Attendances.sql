if object_id ('omop_staging.insert_RTDS_2a_Attendances') is not null
begin
	drop procedure omop_staging.insert_RTDS_2a_Attendances;
end

go

create procedure omop_staging.insert_RTDS_2a_Attendances		
	@rows omop_staging.RTDS_2a_Attendances_row readonly	
as										
begin									
										
insert into omop_staging.RTDS_2a_Attendances	
select *								
from @rows;							
										
end										