---
layout: default
title: specialty_source_value
parent: Provider
grand_parent: Transformation Documentation
has_toc: false
---
# specialty_source_value
### SUS Inpatient Provider
* Value copied from `MainSpecialtyCode`

* `MainSpecialtyCode` A unique code identifying each MAIN SPECIALTY designated by Royal Colleges. [MAIN SPECIALTY CODE]()

```sql
with counts as (
	select 
	ConsultantCode,
	MainSpecialtyCode,
	count(*) as SpecialtyFrequency,
	row_number() over (
	partition by ConsultantCode 
	order by count(*) desc, MainSpecialtyCode
) rnk
from (
	select
	ConsultantCode,
	MainSpecialtyCode
	from [omop_staging].[sus_APC]
	where MainSpecialtyCode is not null
	and ConsultantCode is not null
) grouped
	group by ConsultantCode, MainSpecialtyCode
)
select 
	ConsultantCode,
	MainSpecialtyCode
	from counts
	where rnk = 1;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Provider%20table%20specialty_source_value%20field%20SUS%20Inpatient%20Provider%20mapping){: .btn }
