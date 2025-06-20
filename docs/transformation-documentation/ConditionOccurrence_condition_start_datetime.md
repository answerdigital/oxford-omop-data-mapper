---
layout: default
title: condition_start_datetime
parent: ConditionOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# condition_start_datetime
### SUS Outpatient Condition Occurrence
Source column  `CDSActivityDate`.
Converts text to dates.

* `CDSActivityDate` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html)

```sql
	select
		distinct
			d.DiagnosisICD,
			op.GeneratedRecordIdentifier,
			op.NHSNumber,
			op.CDSActivityDate
	from omop_staging.sus_OP_ICDDiagnosis d
		inner join [omop_staging].[sus_OP] op
			on d.MessageId = op.MessageId
	where op.NHSNumber is not null
		and AttendedorDidNotAttend in ('5','6')
	order by
		d.DiagnosisICD,
		op.GeneratedRecordIdentifier,
		op.NHSNumber,
		op.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_start_datetime%20field%20SUS%20Outpatient%20Condition%20Occurrence%20mapping){: .btn }
### SUS Inpatient Condition Occurrence
Source column  `CDSActivityDate`.
Converts text to dates.

* `CDSActivityDate` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html)

```sql
		select
			distinct
				d.DiagnosisICD,
				apc.GeneratedRecordIdentifier,
				apc.NHSNumber,
				apc.CDSActivityDate
		from omop_staging.sus_ICDDiagnosis d
			inner join omop_staging.sus_APC apc
				on d.MessageId = apc.MessageId
		where apc.NHSNumber is not null
		order by 
			d.DiagnosisICD, 
			apc.GeneratedRecordIdentifier,
			apc.NHSNumber,
			apc.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_start_datetime%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### SUS Inpatient Condition Occurrence
Source column  `CDSActivityDate`.
Converts text to dates.

* `CDSActivityDate` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html)

```sql
	select
		distinct
			d.AccidentAndEmergencyDiagnosis,
			ae.GeneratedRecordIdentifier,
			ae.NHSNumber,
			ae.CDSActivityDate
	from omop_staging.sus_AE_diagnosis d
		inner join omop_staging.sus_AE ae
			on d.MessageId = ae.MessageId
	where ae.NHSNumber is not null
	order by
		d.AccidentAndEmergencyDiagnosis,
		ae.GeneratedRecordIdentifier,
		ae.NHSNumber,
		ae.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_start_datetime%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### Oxford Condition Occurrence
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_start_datetime%20field%20Oxford%20Condition%20Occurrence%20mapping){: .btn }
