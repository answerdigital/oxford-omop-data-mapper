---
layout: default
title: nhs_number
parent: ConditionOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# nhs_number
### SUS Outpatient Condition Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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
	order by
		d.DiagnosisICD,
		op.GeneratedRecordIdentifier,
		op.NHSNumber,
		op.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20SUS%20Outpatient%20Condition%20Occurrence%20mapping){: .btn }
### SUS Inpatient Condition Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### SUS Inpatient Condition Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### SACT Condition Occurrence
* Value copied from `NHS_Number`

* `NHS_Number` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
	select
		Primary_Diagnosis,
		replace(NHS_Number, ' ', '') as NHS_Number,
		min(Administration_Date) as Administration_Date
	from omop_staging.sact_staging
	group by
		Primary_Diagnosis,
		NHS_Number
	order by
		NHS_Number,
		Primary_Diagnosis,
		min(Administration_Date)
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20SACT%20Condition%20Occurrence%20mapping){: .btn }
### Rtds Condition Occurrence
* Value copied from `PatientId`

* `PatientId` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
with results as (
	select 
		distinct
			(select PatientId from omop_staging.rtds_1_demographics d where d.PatientSer = dc.PatientSer limit 1) as PatientId,
			dc.DiagnosisCode,
			dc.DateStamp as event_start_date,
			dc.DateStamp as event_end_date
	from omop_staging.RTDS_5_Diagnosis_Course dc
	where dc.DiagnosisTableName = 'ICD-10'
)
select
	PatientId,
	DiagnosisCode,
	event_start_date,
	event_end_date
from results
where
    PatientId is not null
    and regexp_matches(patientid, '\d{10}');
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20Rtds%20Condition%20Occurrence%20mapping){: .btn }
### Oxford Condition Occurrence
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20Oxford%20Condition%20Occurrence%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
with co as (
  select 
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as DiagnosisDate,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as NonPrimaryDiagnosisDate,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.MorphologyICDODiagnosis.@code' as CancerHistology,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.TopographyICDO.@code' as CancerTopography,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.BasisOfCancerDiagnosis.@code' as BasisOfDiagnosisCancer,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.PrimaryDiagnosis.@code' as CancerDiagnosis
  from omop_staging.cosd_staging_81 co
where co.Type = 'CO'
)
select 
	distinct
		NhsNumber,
		coalesce (DiagnosisDate, NonPrimaryDiagnosisDate) as DiagnosisDate,
		BasisOfDiagnosisCancer,
		CancerDiagnosis
from CO
where NhsNumber is not null and
	(
		DiagnosisDate is not null or 
		NonPrimaryDiagnosisDate is not null
	);
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis Histology Topography
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
with co as (
  select 
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as DiagnosisDate,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as NonPrimaryDiagnosisDate,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.MorphologyICDODiagnosis.@code' as CancerHistology,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.TopographyICDO.@code' as CancerTopography,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.BasisOfCancerDiagnosis.@code' as BasisOfDiagnosisCancer,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.PrimaryDiagnosis.@code' as CancerDiagnosis
  from omop_staging.cosd_staging_81 co
where co.Type = 'CO'
)
select 
	distinct
		NhsNumber,
		coalesce (DiagnosisDate, NonPrimaryDiagnosisDate) as DiagnosisDate,
		BasisOfDiagnosisCancer,
		CancerHistology,
		CancerTopography
from CO
where NhsNumber is not null and
	(
		DiagnosisDate is not null or 
		NonPrimaryDiagnosisDate is not null
	)
	and (CancerHistology is not null and CancerTopography is not null)
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
with CO as (
	select
		Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
		Record ->> '$.PrimaryPathway.Diagnosis.DiagnosisAdditionalItems.SecondaryDiagnosisIcd.@code' as SecondaryDiagnosis
	from omop_staging.cosd_staging_901
	where type = 'CO'
)
select
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	max(SecondaryDiagnosis) as SecondaryDiagnosis
from CO
where DateOfPrimaryDiagnosisClinicallyAgreed is not null
  and SecondaryDiagnosis is not null
group by NhsNumber, DateOfPrimaryDiagnosisClinicallyAgreed;

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select
    distinct
        Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
        Record ->> '$.NonPrimaryPathway.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
        Record ->> '$.NonPrimaryPathway.Recurrence.OriginalPrimaryDiagnosisIcd.@code' as NonPrimaryRecurrenceOriginalDiagnosis
from omop_staging.cosd_staging_901
where type = 'CO'
  and NonPrimaryRecurrenceOriginalDiagnosis is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Progression
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    Record ->> '$.NonPrimaryPathway.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as NonPrimaryDiagnosisDate,
    Record ->> '$.NonPrimaryPathway.Progression.ProgressionIcd.@code' as NonPrimaryProgressionOriginalDiagnosis
from omop_staging.cosd_staging_901
where type = 'CO'
  and NonPrimaryProgressionOriginalDiagnosis is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Progression%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
with co as (
	select
		Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
		Record ->> '$.PrimaryPathway.Diagnosis."MorphologyIcd-o-3"."@code"' as CancerHistology,
		Record ->> '$.PrimaryPathway.Diagnosis."TopographyIcd-o-3"."@code"' as CancerTopography,
		Record ->> '$.PrimaryPathway.Diagnosis.BasisOfDiagnosisCancer.@code' as BasisOfDiagnosisCancer,
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.PrimaryDiagnosisIcd.@code' as CancerDiagnosis
	from omop_staging.cosd_staging_901
	where type = 'CO'
)
select
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	max(BasisOfDiagnosisCancer) as BasisOfDiagnosisCancer,
	CancerDiagnosis
from co
where DateOfPrimaryDiagnosisClinicallyAgreed is not null
group by NhsNumber, DateOfPrimaryDiagnosisClinicallyAgreed, CancerDiagnosis;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis Histology Topography
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
    Record ->> '$.PrimaryPathway.Diagnosis.BasisOfDiagnosisCancer.@code' as BasisOfDiagnosisCancer,
    Record ->> '$.PrimaryPathway.Diagnosis."MorphologyIcd-o-3"."@code"' as CancerHistology,
    Record ->> '$.PrimaryPathway.Diagnosis."TopographyIcd-o-3"."@code"' as CancerTopography
from omop_staging.cosd_staging_901
where type = 'CO'
  and DateOfPrimaryDiagnosisClinicallyAgreed is not null
  and CancerHistology is not null
  and CancerTopography not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20nhs_number%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
