if object_id ('omop_staging.insert_sact_rows') is not null
begin
	drop procedure omop_staging.insert_sact_rows;
end

go

create procedure omop_staging.insert_sact_rows			
	@SactRows omop_staging.sact_staging_row readonly		
as												
begin											
												
insert into omop_staging.sact_staging					
select *										
from @SactRows;								
												
end											