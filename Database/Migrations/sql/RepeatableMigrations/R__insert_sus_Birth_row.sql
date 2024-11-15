if object_id('omop_staging.insert_sus_Birth_row') is not null
begin
    drop procedure omop_staging.insert_sus_Birth_row;
end

go

create procedure omop_staging.insert_sus_Birth_row
    @rows omop_staging.sus_Birth_row readonly
as
begin

insert into omop_staging.sus_Birth
select *
from @rows;

end