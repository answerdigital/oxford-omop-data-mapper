if object_id('omop_staging.insert_sus_CareLocation_row') is not null
begin
    drop procedure omop_staging.insert_sus_CareLocation_row;
end

go

create procedure omop_staging.insert_sus_CareLocation_row
    @rows omop_staging.sus_CareLocation_row readonly
as
begin

insert into omop_staging.sus_CareLocation
select *
from @rows r
where exists (select * from omop_staging.sus_APC where MessageId = r.MessageId)

end