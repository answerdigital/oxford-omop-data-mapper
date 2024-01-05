if object_id ('omop_staging.insert_RTDS_PASDATA') is not null
begin
	drop procedure omop_staging.insert_RTDS_PASDATA;
end

go

create procedure omop_staging.insert_RTDS_PASDATA		
	@rows omop_staging.RTDS_PASDATA_row readonly	
as										
begin									
										
insert into omop_staging.RTDS_PASDATA	
select *								
from @rows;							
										
end										