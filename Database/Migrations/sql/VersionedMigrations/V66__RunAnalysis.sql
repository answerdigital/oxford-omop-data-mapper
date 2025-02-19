if object_id('dbo.run_analysis') is null
begin

create table dbo.run_analysis
(
	run_id uniqueidentifier not null,
	datetime_utc datetime not null constraint DF_dbo_run_analysis_datetime_utc default getutcdate(),
	table_type varchar(100) not null,
	origin varchar(100) not null,
	valid_count int not null,
	invalid_count int not null,
	constraint PK_dbo_run_analysis_RunId_TableType_Origin primary key (run_id, table_type, origin)
);

end