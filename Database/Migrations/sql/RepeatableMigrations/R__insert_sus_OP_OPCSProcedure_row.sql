if object_id('omop_staging.insert_sus_OP_OPCSProcedure_row') is not null
begin
    drop procedure omop_staging.insert_sus_OP_OPCSProcedure_row;
end

go

create procedure omop_staging.insert_sus_OP_OPCSProcedure_row
    @rows omop_staging.sus_OP_OPCSProcedure_row readonly
as
begin

insert into omop_staging.sus_OP_OPCSProcedure
select *
from @rows;

end