if object_id('omop_staging.insert_sus_CCMDS_CriticalCareHighCostDrugs_row') is not null
begin
    drop procedure omop_staging.insert_sus_CCMDS_CriticalCareHighCostDrugs_row;
end

go

create procedure omop_staging.insert_sus_CCMDS_CriticalCareHighCostDrugs_row
    @rows omop_staging.sus_CCMDS_CriticalCareHighCostDrugs_row readonly
as
begin

insert into omop_staging.sus_CCMDS_CriticalCareHighCostDrugs
select *
from @rows r
where exists (select * from omop_staging.sus_CCMDS where MessageId = r.MessageId)

end