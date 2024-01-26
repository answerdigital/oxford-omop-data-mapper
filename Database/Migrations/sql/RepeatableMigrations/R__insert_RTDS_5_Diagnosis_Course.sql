if object_id ('omop_staging.insert_RTDS_5_Diagnosis_Course') is not null
begin
	drop procedure omop_staging.insert_RTDS_5_Diagnosis_Course;
end

go

create procedure omop_staging.insert_RTDS_5_Diagnosis_Course		
	@rows omop_staging.RTDS_5_Diagnosis_Course_row readonly	
as										
begin									
										
insert into omop_staging.RTDS_5_Diagnosis_Course	
select *								
from @rows;							
										
end										