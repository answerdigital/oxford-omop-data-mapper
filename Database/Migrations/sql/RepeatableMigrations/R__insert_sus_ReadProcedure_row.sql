if object_id('omop_staging.insert_sus_ReadProcedure_row') is not null
begin
    drop procedure omop_staging.insert_sus_ReadProcedure_row;
end

go

create procedure omop_staging.insert_sus_ReadProcedure_row
    @rows omop_staging.sus_ReadProcedure_row readonly
as
begin

insert into omop_staging.sus_ReadProcedure
select *
from @rows;

end