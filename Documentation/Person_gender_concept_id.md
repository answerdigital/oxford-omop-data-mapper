# `Person` `gender_concept_id`
### Rtds Demographics


|before|after|notes|
|------|-----|-----|
|Male|8507||
|1|8507||
|Female|8532||
|2|8532||
|9|8551||
|X|8551||
|Unknown|8551||
|Not Stated|8551||

Notes
* [NHS Gender](https://www.datadictionary.nhs.uk/data_elements/person_stated_gender_code.html)
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

### CDS Person


|before|after|notes|
|------|-----|-----|
|Male|8507||
|1|8507||
|Female|8532||
|2|8532||
|9|8551||
|X|8551||
|Unknown|8551||
|Not Stated|8551||

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

