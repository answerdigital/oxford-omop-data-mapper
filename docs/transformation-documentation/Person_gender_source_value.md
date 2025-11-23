---
layout: default
title: gender_source_value
parent: Person
grand_parent: Transformation Documentation
has_toc: false
---
# gender_source_value
### SUS Outpatient Person
* Value copied from `PersonCurrentGenderCode`

* `PersonCurrentGenderCode` Patient PersonCurrentGenderCode [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
	select
		NHSNumber,
		max(DateofBirth) as DateOfBirth,
		max(EthnicCategory) as EthnicCategory,
		max(Sex) as PersonCurrentGenderCode
	from omop_staging.sus_OP
	where NHSNumber is not null
	group by NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_source_value%20field%20SUS%20Outpatient%20Person%20mapping){: .btn }
### SUS Inpatient Person
* Value copied from `PersonCurrentGenderCode`

* `PersonCurrentGenderCode` Patient PersonCurrentGenderCode [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
	select
		NHSNumber,
		max(DateofBirth) as DateOfBirth,
		max(EthnicGroup) as EthnicCategory,
		max(Sex) as PersonCurrentGenderCode
	from omop_staging.sus_APC
	where NHSNumber is not null
	group by NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_source_value%20field%20SUS%20Inpatient%20Person%20mapping){: .btn }
### SUS A&E Person
* Value copied from `PersonCurrentGenderCode`

* `PersonCurrentGenderCode` Patient PersonCurrentGenderCode [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
	select
		NHSNumber,
		max(DateofBirth) as DateOfBirth,
		max(EthnicCategory) as EthnicCategory,
		max(Sex) as PersonCurrentGenderCode
	from omop_staging.sus_AE
	where NHSNumber is not null
	group by NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_source_value%20field%20SUS%20A&E%20Person%20mapping){: .btn }
### SACT Person
* Value copied from `Person_Stated_Gender_Code`

* `Person_Stated_Gender_Code` The patient's Sex [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
	select
		NHS_Number,
		CASE
            -- Check for yyyy-MM-dd format (contains dash and year first)
            WHEN max(Date_Of_Birth) LIKE '____-__-__' 
                THEN CAST(strptime(max(Date_Of_Birth), '%Y-%m-%d') AS TIMESTAMP)
            -- dd/MM/yyyy format, where day is between 1 and 31
            WHEN max(Date_Of_Birth) LIKE '__/__/____' AND CAST(substring(max(Date_Of_Birth), 1, 2) AS INTEGER) BETWEEN 1 AND 31
                THEN CAST(strptime(max(Date_Of_Birth), '%d/%m/%Y') AS TIMESTAMP)
            -- Otherwise assume MM/dd/yyyy format
            WHEN max(Date_Of_Birth) LIKE '__/__/____'
                THEN CAST(strptime(max(Date_Of_Birth), '%m/%d/%Y') AS TIMESTAMP)
            ELSE NULL
        END AS Date_Of_Birth,
		max (Person_Stated_Gender_Code) as Person_Stated_Gender_Code
	from omop_staging.sact_staging
	group by NHS_Number
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_source_value%20field%20SACT%20Person%20mapping){: .btn }
