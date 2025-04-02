---
layout: default
title: RecordConnectionIdentifier
parent: ProcedureOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# RecordConnectionIdentifier
### SUS Outpatient Procedure Occurrence
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

```sql
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
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20RecordConnectionIdentifier%20field%20SUS%20Outpatient%20Procedure%20Occurrence%20mapping){: .btn }
### SUS CCMDS Procedure Occurrence
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

```sql
		select distinct
				apc.NHSNumber,
				apc.GeneratedRecordIdentifier,
				cc.CriticalCareStartDate as ProcedureOccurrenceStartDate,
				coalesce(cc.CriticalCareStartTime, '00:00:00') as ProcedureOccurrenceStartTime,
				coalesce(cc.CriticalCarePeriodDischargeDate, cc.EventDate) as ProcedureOccurrenceEndDate,
				coalesce(cc.CriticalCarePeriodDischargeTime, '00:00:00') as ProcedureOccurrenceEndTime,
				d.CriticalCareActivityCode as ProcedureSourceValue
		from omop_staging.sus_CCMDS_CriticalCareActivityCode d
		inner join omop_staging.sus_CCMDS cc on d.MessageId = cc.MessageId
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
		and d.CriticalCareActivityCode != '99'  -- No Defined Critical Care Activity

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20RecordConnectionIdentifier%20field%20SUS%20CCMDS%20Procedure%20Occurrence%20mapping){: .btn }
### SUS APC Procedure Occurrence
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20RecordConnectionIdentifier%20field%20SUS%20APC%20Procedure%20Occurrence%20mapping){: .btn }
### SUS AE Procedure Occurrence
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20RecordConnectionIdentifier%20field%20SUS%20AE%20Procedure%20Occurrence%20mapping){: .btn }
### CDS Procedure Occurrence
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

```sql
select
	distinct
		l1.RecordConnectionIdentifier,
		l1.NHSNumber,
		p.PrimaryProcedureDate,
		p.PrimaryProcedure
from omop_staging.cds_line01 l1
	inner join omop_staging.cds_procedure p
		on l1.MessageId = p.MessageId
where l1.NHSNumber is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ProcedureOccurrence%20table%20RecordConnectionIdentifier%20field%20CDS%20Procedure%20Occurrence%20mapping){: .btn }
