if object_id('omop_staging.insert_sus_OP_row') is not null
begin
    drop procedure omop_staging.insert_sus_OP_row;
end

go

create procedure omop_staging.insert_sus_OP_row
    @rows omop_staging.sus_OP_row readonly
as
begin

insert into omop_staging.sus_OP
select *
from @rows;

end