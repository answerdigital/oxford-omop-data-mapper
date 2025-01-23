if object_id('omop_staging.insert_sus_AE_row') is not null
begin
    drop procedure omop_staging.insert_sus_AE_row;
end

go

create procedure omop_staging.insert_sus_AE_row
    @rows omop_staging.sus_AE_row readonly
as
begin

insert into omop_staging.sus_AE
select *
from @rows;

end