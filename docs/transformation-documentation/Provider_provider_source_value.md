---
layout: default
title: provider_source_value
parent: Provider
grand_parent: Transformation Documentation
has_toc: false
---
# provider_source_value
### SUS Inpatient Provider
* Value copied from `ConsultantCode`

* `ConsultantCode` A unique code identifying a care professional [CONSULTANT CODE](https://www.datadictionary.nhs.uk/data_elements/consultant_code.html)

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
	from [OMOP_QA].[omop_staging].[sus_APC]
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Provider%20table%20provider_source_value%20field%20SUS%20Inpatient%20Provider%20mapping){: .btn }
