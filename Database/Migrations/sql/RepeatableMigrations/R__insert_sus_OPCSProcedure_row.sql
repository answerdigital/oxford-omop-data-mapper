if object_id('omop_staging.insert_sus_OPCSProcedure_row') is not null
begin
    drop procedure omop_staging.insert_sus_OPCSProcedure_row;
end

go

create procedure omop_staging.insert_sus_OPCSProcedure_row
    @rows omop_staging.sus_OPCSProcedure_row readonly
as
begin

insert into omop_staging.sus_OPCSProcedure
select *
from @rows r
where exists (select * from omop_staging.sus_APC where MessageId = r.MessageId)

end