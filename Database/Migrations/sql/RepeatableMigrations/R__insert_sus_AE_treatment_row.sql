if object_id('omop_staging.insert_sus_AE_treatment_row') is not null
begin
    drop procedure omop_staging.insert_sus_AE_treatment_row;
end

go

create procedure omop_staging.insert_sus_AE_treatment_row
    @rows omop_staging.sus_AE_treatment_row readonly
as
begin

insert into omop_staging.sus_AE_treatment
select *
from @rows r
where exists (select * from omop_staging.sus_AE where MessageId = r.MessageId)

end