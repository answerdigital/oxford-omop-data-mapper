---
layout: default
title: procedure_datetime
parent: ProcedureOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# procedure_datetime
### SUS Outpatient Procedure Occurrence
Source columns  `AppointmentDate`, `AppointmentTime`.
Combines a date with a time of day.

* `AppointmentDate` Appointment Date. [APPOINTMENT DATE](https://www.datadictionary.nhs.uk/data_elements/appointment_date.html)

* `AppointmentTime` Appointment Time. [APPOINTMENT TIME](https://www.datadictionary.nhs.uk/data_elements/appointment_time.html)

```sql
with results as
(
	select
		distinct
			op.GeneratedRecordIdentifier,
			op.NHSNumber,
			op.AppointmentDate,
			op.AppointmentTime,
			p.ProcedureOPCS as PrimaryProcedure
	from omop_staging.sus_OP op
		inner join omop_staging.sus_OP_OPCSProcedure p
		on op.MessageId = p.MessageId
	where NHSNumber is not null
		and AttendedorDidNotAttend in ('5','6')
)
select *
from results
order by 
	GeneratedRecordIdentifier,
	NHSNumber,
	AppointmentDate, 
	AppointmentTime,
	PrimaryProcedure
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20SUS%20Outpatient%20Procedure%20Occurrence%20mapping){: .btn }
### SUS CCMDS Procedure Occurrence
Source columns  `ProcedureOccurrenceStartDate`, `ProcedureOccurrenceStartTime`.
Combines a date with a time of day.

* `ProcedureOccurrenceStartDate` Start date of the Procedure [CRITICAL CARE START DATE](https://www.datadictionary.nhs.uk/data_elements/critical_care_start_date.html)

* `ProcedureOccurrenceStartTime` Start time of the Procedure, if exists, else midnight. [CRITICAL CARE START TIME](https://www.datadictionary.nhs.uk/data_elements/critical_care_start_time.html)

```sql
with results as
(
	select 
		distinct
			apc.NHSNumber,
			apc.GeneratedRecordIdentifier,
			cc.CriticalCareStartDate as ProcedureOccurrenceStartDate,
			coalesce(cc.CriticalCareStartTime, '00:00:00') as ProcedureOccurrenceStartTime,
			coalesce(cc.CriticalCarePeriodDischargeDate, cc.EventDate) as ProcedureOccurrenceEndDate,
			coalesce(cc.CriticalCarePeriodDischargeTime, '00:00:00') as ProcedureOccurrenceEndTime,
			d.CriticalCareActivityCode as ProcedureSourceValue
	from omop_staging.sus_CCMDS_CriticalCareActivityCode d
		inner join omop_staging.sus_CCMDS cc 
			on d.MessageId = cc.MessageId
		inner join omop_staging.sus_APC apc 
			on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
	where apc.NHSNumber is not null
		and d.CriticalCareActivityCode != '99'  -- No Defined Critical Care Activity
)
select *
from results
order by 
	NHSNumber,
	GeneratedRecordIdentifier,
	ProcedureOccurrenceStartDate, 
	ProcedureOccurrenceStartTime,
	ProcedureOccurrenceEndDate,
	ProcedureOccurrenceEndTime,
	ProcedureSourceValue

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20SUS%20CCMDS%20Procedure%20Occurrence%20mapping){: .btn }
### SUS APC Procedure Occurrence
Source column  `PrimaryProcedureDate`.
Converts text to dates.

* `PrimaryProcedureDate` Procedure Date. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
select
	distinct
		apc.GeneratedRecordIdentifier,
		apc.NHSNumber,
		p.ProcedureDateOPCS as PrimaryProcedureDate,
		p.ProcedureOPCS as PrimaryProcedure
from omop_staging.sus_APC apc
	inner join omop_staging.sus_OPCSProcedure p
		on apc.MessageId = p.MessageId
where NHSNumber is not null
order by
	apc.GeneratedRecordIdentifier,
	apc.NHSNumber,
	p.ProcedureDateOPCS,
	p.ProcedureOPCS
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20SUS%20APC%20Procedure%20Occurrence%20mapping){: .btn }
### SUS AE Procedure Occurrence
Source column  `PrimaryProcedureDate`.
Converts text to dates.

* `PrimaryProcedureDate` Procedure Date. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
		select
			distinct
				ae.GeneratedRecordIdentifier,
				ae.NHSNumber,
				ae.CDSActivityDate as PrimaryProcedureDate,
				p.AccidentAndEmergencyTreatment as PrimaryProcedure
		from omop_staging.sus_AE ae
			inner join omop_staging.sus_AE_treatment p
				on AE.MessageId = p.MessageId
		where NHSNumber is not null
		order by
			ae.GeneratedRecordIdentifier,
			ae.NHSNumber,
			ae.CDSActivityDate,
			p.AccidentAndEmergencyTreatment
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20SUS%20AE%20Procedure%20Occurrence%20mapping){: .btn }
### Oxford Procedure Occurrence
Source column  `EventDate`.
Converts text to dates.

* `EventDate` Event date 

```sql
select
	distinct
		d.NHSNumber,
		e.EventDate,
		e.SuppliedCode
from omop_staging.oxford_gp_event e
	inner join omop_staging.oxford_gp_demographic d
		on e.PatientIdentifier = d.PatientIdentifier
order by
	d.NHSNumber,
	e.EventDate,
	e.SuppliedCode
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Oxford%20Procedure%20Occurrence%20mapping){: .btn }
### Cosd V9 Procedure Occurrence Procedure Opcs
Source column  `ProcedureDate`.
Converts text to dates.

* `ProcedureDate` The date, month, year and century, or any combination of these elements, that is of relevance to an ACTIVITY. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),								
CosdRecords as (				
	select								
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,								
		T.staging.query('.') as Node								
		from omop_staging.cosd_staging								
	cross apply content.nodes('COSD901:COSD/*') as T(staging)								
	where T.staging.exist('Id/@root') = 1								
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'								
		and substring (FileName, 15, 2) = 'CO'								
), ProcedureOpcs as (				
	select								
		Id,								
		T.p.value('.', 'varchar(max)') as ProcedureOpcsCode															
	from CosdRecords								
	cross apply Node.nodes('ColorectalRecord/Treatment/Surgery/ProcedureOpcs/@code') as T(p)
), COSD as (
	select
		Id,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate
	from CosdRecords
)
select
	distinct
		c.NhsNumber,
		c.ProcedureDate,
		p.ProcedureOpcsCode
from COSD c
	inner join ProcedureOpcs p
		on c.Id = p.Id;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Cosd%20V9%20Procedure%20Occurrence%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V9 Procedure Occurrence Primary Procedure Opcs
Source column  `ProcedureDate`.
Converts text to dates.

* `ProcedureDate` The date, month, year and century, or any combination of these elements, that is of relevance to an ACTIVITY. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),								
CosdRecords as (				
	select								
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,								
		T.staging.query('.') as Node								
		from omop_staging.cosd_staging								
	cross apply content.nodes('COSD901:COSD/*') as T(staging)								
	where T.staging.exist('Id/@root') = 1								
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'								
		and substring (FileName, 15, 2) = 'CO'								
), COSD as (
	select
		Id,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/Treatment/Surgery/PrimaryProcedureOpcs/@code)[1]', 'varchar(max)') as PrimaryProcedureOpcs
	from CosdRecords
)
select
	distinct
		NhsNumber,
		ProcedureDate,
		PrimaryProcedureOpcs
from COSD c
where ProcedureDate is not null and PrimaryProcedureOpcs is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Cosd%20V9%20Procedure%20Occurrence%20Primary%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V8 Procedure Occurrence Procedure Opcs
Source column  `ProcedureDate`.
Converts text to dates.

* `ProcedureDate` The date, month, year and century, or any combination of these elements, that is of relevance to an ACTIVITY. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 
    select
        T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
        T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node -- Select the first inner element of the element that is not called Id.
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select 
        Id,
        Node,
        Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/PrimaryProcedureOPCS/@code)[1]', 'varchar(max)') as PrimaryProcedureOpcs
	from CosdRecords        
), ProcedureOpcs as (				
	select								
		Id,								
		T.p.value('.', 'varchar(max)') as ProcedureOpcsCode															
	from CosdRecords								
	cross apply Node.nodes('ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureOPCS/@code') as T(p)
)
select
	distinct
		c.NhsNumber,
		c.ProcedureDate,
		p.ProcedureOpcsCode
from CO c
	inner join ProcedureOpcs p
		on c.Id = p.Id;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Cosd%20V8%20Procedure%20Occurrence%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V8 Procedure Occurrence Primary Procedure Opcs
Source column  `ProcedureDate`.
Converts text to dates.

* `ProcedureDate` The date, month, year and century, or any combination of these elements, that is of relevance to an ACTIVITY. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 
    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node -- Select the first inner element of the element that is not called Id.
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select 
        Id,
        Node,
        Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/PrimaryProcedureOPCS/@code)[1]', 'varchar(max)') as PrimaryProcedureOpcs
	from CosdRecords        
)
select
	distinct
		NhsNumber,
		ProcedureDate,
		PrimaryProcedureOpcs
from CO c
where ProcedureDate is not null and PrimaryProcedureOpcs is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Cosd%20V8%20Procedure%20Occurrence%20Primary%20Procedure%20Opcs%20mapping){: .btn }
