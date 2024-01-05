if object_id ('omop_staging.insert_RTDS_3_Prescription') is not null
begin
	drop procedure omop_staging.insert_RTDS_3_Prescription;
end

go

create procedure omop_staging.insert_RTDS_3_Prescription		
	@rows omop_staging.RTDS_3_Prescription_row readonly	
as										
begin									
										
insert into omop_staging.RTDS_3_Prescription	
select *								
from @rows;							
										
end										