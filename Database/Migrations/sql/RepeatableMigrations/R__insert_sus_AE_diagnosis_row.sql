if object_id('omop_staging.insert_sus_AE_diagnosis_row') is not null
begin
    drop procedure omop_staging.insert_sus_AE_diagnosis_row;
end

go

create procedure omop_staging.insert_sus_AE_diagnosis_row
    @rows omop_staging.sus_AE_diagnosis_row readonly
as
begin

insert into omop_staging.sus_AE_diagnosis
select *
from @rows r
where exists (select * from omop_staging.sus_AE where MessageId = r.MessageId)

end