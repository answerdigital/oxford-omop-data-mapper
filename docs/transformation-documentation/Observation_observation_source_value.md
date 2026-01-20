---
layout: default
title: observation_source_value
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# observation_source_value
### SUS Outpatient Procedure Observation
* Value copied from `PrimaryProcedure`

* `PrimaryProcedure` OPCS-4 Procedure code. [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20SUS%20Outpatient%20Procedure%20Observation%20mapping){: .btn }
### Sus OP ICDDiagnosis table
* Value copied from `DiagnosisICD`

* `DiagnosisICD` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_.html)

```sql
select
    distinct
        d.DiagnosisICD,
        op.GeneratedRecordIdentifier,
        op.NHSNumber,
        op.CDSActivityDate
from omop_staging.sus_OP_ICDDiagnosis d
    inner join omop_staging.sus_OP op
        on d.MessageId = op.MessageId
where op.NHSNumber is not null
	and AttendedorDidNotAttend in ('5','6')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20Sus%20OP%20ICDDiagnosis%20table%20mapping){: .btn }
### Sus CCMDS High Cost Drugs
* Value copied from `ObservationSourceValue`

* `ObservationSourceValue` High cost drugs. [HIGH COST DRUGS (OPCS)](https://www.datadictionary.nhs.uk/data_elements/high_cost_drugs__opcs_.html)

```sql
		select distinct
			apc.NHSNumber,
			apc.HospitalProviderSpellNumber,
			cc.CriticalCareStartDate as ObservationDate,
			coalesce(cc.CriticalCareStartTime, '00:00:00') as ObservationDateTime,
			d.CriticalCareHighCostDrugs as ObservationSourceValue
		from omop_staging.sus_CCMDS_CriticalCareHighCostDrugs d
		inner join omop_staging.sus_CCMDS cc on d.MessageId = cc.MessageId
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20Sus%20CCMDS%20High%20Cost%20Drugs%20mapping){: .btn }
### SUS APC Procedure Occurrence
* Value copied from `PrimaryProcedure`

* `PrimaryProcedure` OPCS-4 Procedure code. [PROCEDURE (OPCS)](https://www.datadictionary.nhs.uk/data_elements/procedure__opcs_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20SUS%20APC%20Procedure%20Occurrence%20mapping){: .btn }
### Sus APC Diagnosis Table
* Value copied from `DiagnosisICD`

* `DiagnosisICD` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20Sus%20APC%20Diagnosis%20Table%20mapping){: .btn }
### SACT Clinical Trial
* Value copied from `Source_value`

* `Source_value` Source value for the Systemic Anti-Cancer Therapy Data Set, CLINICAL TRIAL INDICATOR identifies if a PATIENT  is currently in an active Systemic Anti-Cancer Therapy CLINICAL TRIAL [CLINICAL TRIAL INDICATOR](https://www.datadictionary.nhs.uk/data_elements/clinical_trial_indicator.html)

```sql
		select
			distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
      		Clinical_Trial,
			Case 
				When Clinical_Trial = 1 then concat(Clinical_Trial, ' - PATIENT is taking part in a CLINICAL TRIAL')
			else '' end as Source_Value,
		  	Administration_Date
		from omop_staging.sact_staging
  		where Clinical_Trial = '1'
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20SACT%20Clinical%20Trial%20mapping){: .btn }
### Oxford Lab General Comment Observation
* Value copied from `EVENT`

* `EVENT` Lab test event [EVENT]()

```sql
select
    NHS_NUMBER,
    EVENT,
    EVENT_START_DT_TM,
    RESULT_VALUE
from ##duckdb_source##
where lower(EVENT) like '%comment%'
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_source_value%20field%20Oxford%20Lab%20General%20Comment%20Observation%20mapping){: .btn }
