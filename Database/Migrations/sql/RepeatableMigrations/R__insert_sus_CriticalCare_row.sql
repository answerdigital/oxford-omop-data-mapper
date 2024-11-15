if object_id('omop_staging.insert_sus_CriticalCare_row') is not null
begin
    drop procedure omop_staging.insert_sus_CriticalCare_row;
end

go

create procedure omop_staging.insert_sus_CriticalCare_row
    @rows omop_staging.sus_CriticalCare_row readonly
as
begin

insert into omop_staging.sus_CriticalCare
select *
from @rows;

end