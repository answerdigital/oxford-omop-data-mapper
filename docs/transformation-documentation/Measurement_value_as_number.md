---
layout: default
title: value_as_number
parent: Measurement
grand_parent: Transformation Documentation
has_toc: false
---
# value_as_number
### Sus CCMDS Measurement - Gestation Length at Delivery
Source column  `ValueAsNumber`.
Converts text to number.

* `ValueAsNumber` Value of the Length of Gestation at Delivery [GESTATION LENGTH (AT DELIVERY)](https://www.datadictionary.nhs.uk/data_elements/gestation_length__at_delivery_.html)

```sql
		select distinct
				apc.NHSNumber,
				apc.GeneratedRecordIdentifier,
				cc.CriticalCareStartDate as MeasurementDate,
				coalesce(cc.CriticalCareStartTime, '00:00:00') as MeasurementDateTime,
				cc.GestationLengthAtDelivery as ValueAsNumber
		from omop_staging.sus_CCMDS cc 
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
		and cc.GestationLengthAtDelivery is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20Sus%20CCMDS%20Measurement%20-%20Gestation%20Length%20at%20Delivery%20mapping){: .btn }
### Sus CCMDS Measurement - Person Weight
Source column  `ValueAsNumber`.
Converts text to number.

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20Sus%20CCMDS%20Measurement%20-%20Person%20Weight%20mapping){: .btn }
### SACT Measurement Weight at Start of Regimen
Source column  `Weight_At_Start_Of_Regimen`.
Converts text to number.

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20SACT%20Measurement%20Weight%20at%20Start%20of%20Regimen%20mapping){: .btn }
### SACT Measurement Weight at Start of Cycle
Source column  `Weight_At_Start_Of_Cycle`.
Converts text to number.

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20SACT%20Measurement%20Weight%20at%20Start%20of%20Cycle%20mapping){: .btn }
### SACT  Measurement Height
Source column  `Height_At_Start_Of_Regimen`.
Converts text to number.

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20SACT%20%20Measurement%20Height%20mapping){: .btn }
### COSD V8 Measurement Tumour Height Above Anal Verge
Source column  `TumourHeightAboveAnalVerge`.
Converts text to number.

* `TumourHeightAboveAnalVerge` Is the approximate height of the lower limit of the Tumour above the anal verge (as measured by a rigid sigmoidoscopy) during a Colorectal Cancer Care Spell, where the UNIT OF MEASUREMENT is 'Centimetres (cm)' [TUMOUR HEIGHT ABOVE ANAL VERGE](https://www.datadictionary.nhs.uk/data_elements/tumour_height_above_anal_verge.html)

```sql
with co as (
    select
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.ColorectalDiagnosis.TumourHeightAboveAnalVerge.@value' as TumourHeightAboveAnalVerge
    from omop_staging.cosd_staging_81
    where Type = 'CO'
)
select distinct
    NhsNumber,
    ClinicalDateCancerDiagnosis,
    TumourHeightAboveAnalVerge
from co
where TumourHeightAboveAnalVerge is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20value_as_number%20field%20COSD%20V8%20Measurement%20Tumour%20Height%20Above%20Anal%20Verge%20mapping){: .btn }
