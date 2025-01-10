---
layout: default
title: gender_concept_id
parent: Person
grand_parent: Transformation Documentation
has_toc: false
---
# gender_concept_id
### SUS Outpatient Person
Source column  `PersonCurrentGenderCode`.
Lookup gender concept.


|PersonCurrentGenderCode|gender_concept_id|notes|
|------|-----|-----|
|1|8507|Male|
|2|8532|Female|
|9|0|Indeterminate (unable to be classified as either male or female)|
|X|0|Not known|

Notes
* [NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)
* [OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)

* `PersonCurrentGenderCode` Patient PersonCurrentGenderCode [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
	select
		NHSNumber,
		max(DateofBirth) as DateOfBirth,
		max(EthnicCategory) as EthnicCategory,
		max(Sex) as PersonCurrentGenderCode
	from [omop_staging].[sus_OP]
	where NHSNumber is not null
	group by NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_concept_id%20field%20SUS%20Outpatient%20Person%20mapping){: .btn }
### SUS Inpatient Person
Source column  `PersonCurrentGenderCode`.
Lookup gender concept.


|PersonCurrentGenderCode|gender_concept_id|notes|
|------|-----|-----|
|1|8507|Male|
|2|8532|Female|
|9|0|Indeterminate (unable to be classified as either male or female)|
|X|0|Not known|

Notes
* [NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)
* [OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_concept_id%20field%20SUS%20Inpatient%20Person%20mapping){: .btn }
### SACT
Source column  `Person_Stated_Gender_Code`.
Lookup gender concept.


|Person_Stated_Gender_Code|gender_concept_id|notes|
|------|-----|-----|
|1|8507|Male|
|2|8532|Female|
|9|0|Indeterminate (unable to be classified as either male or female)|
|X|0|Not known|

Notes
* [NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)
* [OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)

* `Person_Stated_Gender_Code` The patient's Sex [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
select
	NHS_Number,
	max (Patient_Postcode) as Patient_Postcode,
	max (Date_Of_Birth) as Date_Of_Birth,
	max (Person_Stated_Gender_Code) as Person_Stated_Gender_Code
from omop_staging.sact_staging
group by NHS_Number
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_concept_id%20field%20SACT%20mapping){: .btn }
### Rtds Demographics
Source column  `Sex`.
Lookup gender concept.


|Sex|gender_concept_id|notes|
|------|-----|-----|
|Male|8507||
|Female|8532||
|Unknown|8551||
|Not Stated|8551||

Notes
* [OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)

* `Sex` The patient's Sex [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
select
	PatientId,
	max (DateOfBirth) as DateOfBirth,
	max (Sex) as Sex
from omop_staging.RTDS_1_Demographics d
where PatientId is not null
group by PatientId
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_concept_id%20field%20Rtds%20Demographics%20mapping){: .btn }
### CDS Person
Source column  `PersonCurrentGenderCode`.
Lookup gender concept.


|PersonCurrentGenderCode|gender_concept_id|notes|
|------|-----|-----|
|1|8507|Male|
|2|8532|Female|
|9|0|Indeterminate (unable to be classified as either male or female)|
|X|0|Not known|

Notes
* [NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)
* [OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)

* `PersonCurrentGenderCode` Patient PersonCurrentGenderCode [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
select
	NHSNumber,
	max(DateofBirth) as DateOfBirth,
	max(EthnicCategory) as EthnicCategory,
	max(PersonCurrentGenderCode) as PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null
group by NHSNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_concept_id%20field%20CDS%20Person%20mapping){: .btn }
