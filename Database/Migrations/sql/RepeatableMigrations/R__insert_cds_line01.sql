if object_id ('omop_staging.insert_cds_line01') is not null
begin
	drop procedure omop_staging.insert_cds_line01;
end

go

create procedure omop_staging.insert_cds_line01		
	@rows omop_staging.cds_line01_row readonly	
as										
begin									
										
insert into omop_staging.cds_line01	
select *								
from @rows;							
										
end										