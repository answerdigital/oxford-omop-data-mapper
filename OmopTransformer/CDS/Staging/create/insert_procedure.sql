create procedure insert_cds_line01		
	@rows cds_line01_row readonly	
as										
begin									
										
insert into dbo.cds_line01	
select *								
from @rows;							
										
end										