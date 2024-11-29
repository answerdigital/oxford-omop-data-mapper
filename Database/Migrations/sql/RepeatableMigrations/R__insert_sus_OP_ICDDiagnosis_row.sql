if object_id('omop_staging.insert_sus_OP_ICDDiagnosis_row') is not null
begin
    drop procedure omop_staging.insert_sus_OP_ICDDiagnosis_row;
end

go

create procedure omop_staging.insert_sus_OP_ICDDiagnosis_row
    @rows omop_staging.sus_OP_ICDDiagnosis_row readonly
as
begin

insert into omop_staging.sus_OP_ICDDiagnosis
select *
from @rows;

end