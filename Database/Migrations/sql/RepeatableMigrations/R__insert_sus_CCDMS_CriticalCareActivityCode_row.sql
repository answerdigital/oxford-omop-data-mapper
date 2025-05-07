if object_id('omop_staging.insert_sus_CCMDS_CriticalCareActivityCode_row') is not null
begin
    drop procedure omop_staging.insert_sus_CCMDS_CriticalCareActivityCode_row;
end

go

create procedure omop_staging.insert_sus_CCMDS_CriticalCareActivityCode_row
    @rows omop_staging.sus_CCMDS_CriticalCareActivityCode_row readonly
as
begin

insert into omop_staging.sus_CCMDS_CriticalCareActivityCode
select *
from @rows r
where exists (select * from omop_staging.sus_CCMDS where MessageId = r.MessageId)

end