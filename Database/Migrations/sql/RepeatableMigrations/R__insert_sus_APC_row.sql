if object_id('omop_staging.insert_sus_APC_row') is not null
begin
    drop procedure omop_staging.insert_sus_APC_row;
end

go

create procedure omop_staging.insert_sus_APC_row
    @rows omop_staging.sus_APC_row readonly
as
begin

insert into omop_staging.sus_APC
select *
from @rows r

end