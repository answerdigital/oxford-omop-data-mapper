if object_id('omop_staging.insert_sus_OP_ReadDiagnosis_row') is not null
begin
    drop procedure omop_staging.insert_sus_OP_ReadDiagnosis_row;
end

go

create procedure omop_staging.insert_sus_OP_ReadDiagnosis_row
    @rows omop_staging.sus_OP_ReadDiagnosis_row readonly
as
begin

insert into omop_staging.sus_OP_ReadDiagnosis
select *
from @rows;

end