---
layout: default
title: value_source_value
parent: Measurement
grand_parent: Transformation Documentation
has_toc: false
---
# value_source_value
### Sus OP  Measurement
Source column  `DiagnosisICD`.
Resolve Measurement domain ICD10 codes to `Maps To Value` concepts.

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_source_value%20field%20Sus%20OP%20%20Measurement%20mapping){: .btn }
### Sus CCMDS Measurement - Person Weight
* Value copied from `ValueAsNumber`

* `ValueAsNumber` Value of the Person weight [PERSON WEIGHT](https://www.datadictionary.nhs.uk/data_elements/person_weight.html)

```sql
		select distinct
				apc.NHSNumber,
				apc.GeneratedRecordIdentifier,
				cc.CriticalCareStartDate as MeasurementDate,
				coalesce(cc.CriticalCareStartTime, '00:00:00') as MeasurementDateTime,
				cc.PersonWeight as ValueAsNumber
		from omop_staging.sus_CCMDS cc 
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
		and cc.PersonWeight is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_source_value%20field%20Sus%20CCMDS%20Measurement%20-%20Person%20Weight%20mapping){: .btn }
### Sus APC Measurement
Source column  `DiagnosisICD`.
Resolve Measurement domain ICD10 codes to `Maps To Value` concepts.

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_source_value%20field%20Sus%20APC%20Measurement%20mapping){: .btn }
### SACT Measurement Weight at Start of Regimen
* Value copied from `Weight_At_Start_Of_Regimen`

* `Weight_At_Start_Of_Regimen` Weight when the Regimen started [WEIGHT AT START OF REGIMEN]()

```sql
		select distinct 
			NHS_Number,
			Weight_At_Start_Of_Regimen,
			CASE
				-- Check for yyyy-MM-dd format (contains dash and year first)
				WHEN Start_Date_Of_Regimen LIKE '____-__-__' 
					THEN CAST(strptime(Start_Date_Of_Regimen, '%Y-%m-%d') AS TIMESTAMP)
				-- dd/MM/yyyy format, where day is between 1 and 31
			    WHEN Start_Date_Of_Regimen LIKE '__/__/____' AND CAST(substring(Start_Date_Of_Regimen, 1, 2) AS INTEGER) BETWEEN 1 AND 31
				    THEN CAST(strptime(Start_Date_Of_Regimen, '%d/%m/%Y') AS TIMESTAMP)
				-- Otherwise assume MM/dd/yyyy format
				WHEN Start_Date_Of_Regimen LIKE '__/__/____'
					THEN CAST(strptime(Start_Date_Of_Regimen, '%m/%d/%Y') AS TIMESTAMP)
				ELSE NULL
			END AS Start_Date_Of_Regimen
		from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_source_value%20field%20SACT%20Measurement%20Weight%20at%20Start%20of%20Regimen%20mapping){: .btn }
### SACT Measurement Weight at Start of Cycle
* Value copied from `Weight_At_Start_Of_Cycle`

* `Weight_At_Start_Of_Cycle` Weight when the cycle started [WEIGHT AT START OF CYCLE]()

```sql
		select distinct 
			NHS_Number,
			Weight_At_Start_Of_Cycle,
			CASE
				-- Check for yyyy-MM-dd format (contains dash and year first)
				WHEN Start_Date_Of_Cycle LIKE '____-__-__' 
					THEN CAST(strptime(Start_Date_Of_Cycle, '%Y-%m-%d') AS TIMESTAMP)
				-- dd/MM/yyyy format, where day is between 1 and 31
			    WHEN Start_Date_Of_Cycle LIKE '__/__/____' AND CAST(substring(Start_Date_Of_Cycle, 1, 2) AS INTEGER) BETWEEN 1 AND 31
				    THEN CAST(strptime(Start_Date_Of_Cycle, '%d/%m/%Y') AS TIMESTAMP)
				-- Otherwise assume MM/dd/yyyy format
				WHEN Start_Date_Of_Cycle LIKE '__/__/____'
					THEN CAST(strptime(Start_Date_Of_Cycle, '%m/%d/%Y') AS TIMESTAMP)
				ELSE NULL
			END AS Start_Date_Of_Cycle
		from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_source_value%20field%20SACT%20Measurement%20Weight%20at%20Start%20of%20Cycle%20mapping){: .btn }
### SACT  Measurement Height
* Value copied from `Height_At_Start_Of_Regimen`

* `Height_At_Start_Of_Regimen` Height when the treatment started [HEIGHT AT START OF TREATMENT]()

```sql
		select distinct 
			NHS_Number,
			Height_At_Start_Of_Regimen,
			CASE
				-- Check for yyyy-MM-dd format (contains dash and year first)
				WHEN Start_Date_Of_Regimen LIKE '____-__-__' 
					THEN CAST(strptime(Start_Date_Of_Regimen, '%Y-%m-%d') AS TIMESTAMP)
				-- dd/MM/yyyy format, where day is between 1 and 31
			    WHEN Start_Date_Of_Regimen LIKE '__/__/____' AND CAST(substring(Start_Date_Of_Regimen, 1, 2) AS INTEGER) BETWEEN 1 AND 31
				    THEN CAST(strptime(Start_Date_Of_Regimen, '%d/%m/%Y') AS TIMESTAMP)
				-- Otherwise assume MM/dd/yyyy format
				WHEN Start_Date_Of_Regimen LIKE '__/__/____'
					THEN CAST(strptime(Start_Date_Of_Regimen, '%m/%d/%Y') AS TIMESTAMP)
				ELSE NULL
			END AS Start_Date_Of_Regimen
		from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_source_value%20field%20SACT%20%20Measurement%20Height%20mapping){: .btn }
