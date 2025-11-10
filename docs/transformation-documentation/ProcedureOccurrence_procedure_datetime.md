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
### Rtds Procedure Occurrence
Source column  `event_start_date`.
Converts text to dates.

* `event_start_date` Appointment Start Time [TREATMENT START DATE (RADIOTHERAPY TREATMENT EPISODE)]()

```sql
with records as (
	select
		PatientSer,
		ProcedureCode,
		ActualStartDateTime_s as Start_date,
		ActualEndDateTime_s as End_date
	from omop_staging.rtds_2a_attendances

	union

	select 
		PatientSer,
		ProcedureCode,
		Start_date,
		End_date
	from omop_staging.rtds_2b_plan
), records_with_patient as (
	select
		(select PatientId from omop_staging.rtds_1_demographics d where d.PatientSer = r.PatientSer limit 1) as PatientId,
		r.*
	from records r
)
select
	PatientId,
	ProcedureCode,
	Start_date as event_start_date,
	End_date as event_end_date
from records_with_patient
where PatientId is not null
	and regexp_matches(patientid, '\d{10}');
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Rtds%20Procedure%20Occurrence%20mapping){: .btn }
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
with CO as (
    select distinct
        Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
        coalesce(Record ->> '$.Treatment[0].Surgery.ProcedureDate', Record ->> '$.Treatment.Surgery.ProcedureDate') as ProcedureDate,
        unnest(
            [
                [ Record ->> '$.Treatment.Surgery.ProcedureOpcs.@code' ],
                Record ->> '$.Treatment.Surgery.ProcedureOpcs[*].@code'
            ],
            recursive := true
        ) as ProcedureOpcsCode
    from omop_staging.cosd_staging_901
    where type = 'CO'
)
select distinct
    NhsNumber,
    ProcedureDate,
    ProcedureOpcsCode
from CO
where ProcedureOpcsCode is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Cosd%20V9%20Procedure%20Occurrence%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V9 Procedure Occurrence Primary Procedure Opcs
Source column  `ProcedureDate`.
Converts text to dates.

* `ProcedureDate` The date, month, year and century, or any combination of these elements, that is of relevance to an ACTIVITY. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
select 
  distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(Record ->> '$.Treatment[0].Surgery.ProcedureDate', Record ->> '$.Treatment.Surgery.ProcedureDate') as ProcedureDate,
    coalesce(Record ->> '$.Treatment[0].Surgery.PrimaryProcedureOpcs.@code', Record ->> '$.Treatment.Surgery.PrimaryProcedureOpcs.@code') as PrimaryProcedureOpcs
from omop_staging.cosd_staging_901
where type = 'CO'
  and ProcedureDate is not null
  and PrimaryProcedureOpcs is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Cosd%20V9%20Procedure%20Occurrence%20Primary%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V8 Procedure Occurrence Procedure Opcs
Source column  `ProcedureDate`.
Converts text to dates.

* `ProcedureDate` The date, month, year and century, or any combination of these elements, that is of relevance to an ACTIVITY. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
with co as (
  select 
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.ColorectalCoreSurgeryAndOtherProcedures.ProcedureDate' as ProcedureDate,
    unnest(
      [
        [
          Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.ColorectalCoreSurgeryAndOtherProcedures.ProcedureOPCS.@code'
        ], 
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.ColorectalCoreSurgeryAndOtherProcedures.ProcedureOPCS[*].@code',
      ], recursive := true
    ) as ProcedureOpcsCode
    from omop_staging.cosd_staging_81
    where Type = 'CO'
)
select
  distinct
		NhsNumber,
		ProcedureDate,
		ProcedureOpcsCode
from co
where co.ProcedureOpcsCode is not null;
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Cosd%20V8%20Procedure%20Occurrence%20Procedure%20Opcs%20mapping){: .btn }
### Cosd V8 Procedure Occurrence Primary Procedure Opcs
Source column  `ProcedureDate`.
Converts text to dates.

* `ProcedureDate` The date, month, year and century, or any combination of these elements, that is of relevance to an ACTIVITY. [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

```sql
with CO as (
  select 
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.ColorectalCoreSurgeryAndOtherProcedures.ProcedureDate' as ProcedureDate,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.ColorectalCoreSurgeryAndOtherProcedures.PrimaryProcedureOPCS.@code' as PrimaryProcedureOpcs
  from omop_staging.cosd_staging_81
  where Type = 'CO'
)
select
      distinct
          ProcedureDate,
          NhsNumber,
          PrimaryProcedureOpcs
from CO o
where o.ProcedureDate is not null and o.PrimaryProcedureOpcs is not null;
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20procedure_datetime%20field%20Cosd%20V8%20Procedure%20Occurrence%20Primary%20Procedure%20Opcs%20mapping){: .btn }
