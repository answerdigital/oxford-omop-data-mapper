if object_id ('omop_staging.insert_RTDS_1_Demographics') is not null
begin
	drop procedure omop_staging.insert_RTDS_1_Demographics;
end

go

create procedure omop_staging.insert_RTDS_1_Demographics		
	@rows omop_staging.RTDS_1_Demographics_row readonly	
as										
begin									
										
insert into omop_staging.RTDS_1_Demographics	
select *								
from @rows;							
										
end										