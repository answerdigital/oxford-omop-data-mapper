if object_id('procedure omop_staging.insert_sus_OP_OPCSProcedure_row') is not NULL
begin
    drop procedure omop_staging.insert_sus_OP_OPCSProcedure_row;
end

go

alter table omop_staging.sus_OP_OPCSProcedure
	drop column ProcedureDateOPCS;

go

drop type omop_staging.sus_OP_OPCSProcedure_row;

go

create type omop_staging.sus_OP_OPCSProcedure_row as table
(
    MessageId uniqueidentifier not null,
    ProcedureOPCS varchar(500) null,
    MainOperatingHealthcareProfessionalCodeOpcs varchar(500) null,
    ProfessionalRegistrationIssuerCodeOpcs varchar(500) null,
    ResponsibleAnaesthetistCodeOpcs varchar(500) null,
    ResponsibleAnaesthetistRegBodyOpcs varchar(500) null,
    IsPrimaryProcedure bit not null
)