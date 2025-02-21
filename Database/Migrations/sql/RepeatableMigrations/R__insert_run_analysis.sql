if object_id('dbo.insert_RunAnalysis') is not null
begin
    drop procedure dbo.insert_RunAnalysis;
end

go

create procedure dbo.insert_RunAnalysis
	@RunId uniqueidentifier,
	@TableType varchar(100),
	@Origin varchar(100),
	@ValidCount int,
	@InvalidCount int
as

begin

insert into dbo.run_analysis
(
	run_id,
	table_type,
	origin,
	valid_count,
	invalid_count
)
values
(
	@RunId,
	@TableType,
	@Origin,
	@ValidCount,
	@InvalidCount
);

end