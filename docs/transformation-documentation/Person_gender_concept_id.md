---
layout: default
title: gender_concept_id
parent: Person
grand_parent: Transformation Documentation
has_toc: false
---
# gender_concept_id
### SACT
Source column  `Person_Stated_Gender_Code`.
Lookup gender concept.


|Person_Stated_Gender_Code|gender_concept_id|notes|
|------|-----|-----|
|1|8507|Male|
|2|8532|Female|
|9|8551|Indeterminate (unable to be classified as either male or female)|
|X|8551|Not known|

Notes
* [NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)
* [OMOP Gender](https://athena.ohdsi.org/search-terms/terms?conceptClass=Gender&invalidReason=Valid&vocabulary=Gender&page=1&pageSize=50&query=)

* `Person_Stated_Gender_Code` The patient's Sex [PERSON GENDER CODE CURRENT](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)

```sql
select
	distinct
		Patient_Postcode,
		NHS_Number,
		Date_Of_Birth,
		Person_Stated_Gender_Code
from omop_staging.sact_staging
	
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
	distinct 
		d.PatientId,
		d.DateOfBirth,
		d.Sex
from omop_staging.RTDS_1_Demographics d
where d.PatientId not like '%[^0-9]%'
	and len(d.PatientId) = 10
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_concept_id%20field%20Rtds%20Demographics%20mapping){: .btn }
### CDS Person
Source column  `PersonCurrentGenderCode`.
Lookup gender concept.


|PersonCurrentGenderCode|gender_concept_id|notes|
|------|-----|-----|
|1|8507|Male|
|2|8532|Female|
|9|8551|Indeterminate (unable to be classified as either male or female)|
|X|8551|Not known|

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