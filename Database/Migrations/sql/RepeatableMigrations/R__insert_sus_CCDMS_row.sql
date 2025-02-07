if object_id('omop_staging.insert_sus_CCMDS_row') is not null
begin
    drop procedure omop_staging.insert_sus_CCMDS_row;
end

go

create procedure omop_staging.insert_sus_CCMDS_row
    @rows omop_staging.sus_CCMDS_row readonly
as
begin

insert into omop_staging.sus_CCMDS
select *
from @rows;

end