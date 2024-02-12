# `Person` `gender_concept_id`
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
* `Sex` The patient's Sex.
<details>
<summary>SQL</summary>

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
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_concept_id%20field%20Rtds%20Demographics%20mapping)
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
* `PersonCurrentGenderCode` Patient PersonCurrentGenderCode [Data Dictionary](https://www.datadictionary.nhs.uk/data_elements/person_gender_code_current.html)
<details>
<summary>SQL</summary>

```sql
select
	distinct
		NHSNumber,
		DateofBirth as DateOfBirth,
		EthnicCategory,
		PersonCurrentGenderCode
from omop_staging.cds_line01
where NHSNumber is not null;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Person%20table%20gender_concept_id%20field%20CDS%20Person%20mapping)
