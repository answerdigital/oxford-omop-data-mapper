if object_id('omop_staging.insert_sus_ReadDiagnosis_row') is not null
begin
    drop procedure omop_staging.insert_sus_ReadDiagnosis_row;
end

go

create procedure omop_staging.insert_sus_ReadDiagnosis_row
    @rows omop_staging.sus_ReadDiagnosis_row readonly
as
begin

insert into omop_staging.sus_ReadDiagnosis
select *
from @rows r
where exists (select * from omop_staging.sus_APC where MessageId = r.MessageId)

end