---
layout: default
title: care_site_name
parent: CareSite
grand_parent: Transformation Documentation
has_toc: false
---
# care_site_name
### SUS Inpatient Care Site
* Value copied from `SiteCodeOfTreatmentAtEpisodeStartDate`

* `SiteCodeOfTreatmentAtEpisodeStartDate` ORGANISATION SITE CODE  of the ORGANISATION where the PATIENT was treated [SITE CODE (OF TREATMENT)](https://www.datadictionary.nhs.uk/data_elements/site_code__of_treatment_.html)

```sql
	with 
	counts as ( 
		select 
		SiteCodeOfTreatmentAtEpisodeStartDate, 
		MainSpecialtyCode, 
		count(*) as cnt 
		from omop_staging.sus_APC 
		where SiteCodeOfTreatmentAtEpisodeStartDate is not null 
		and MainSpecialtyCode is not null 
		group by 
		SiteCodeOfTreatmentAtEpisodeStartDate, 
		MainSpecialtyCode 
	), 

	ranked as ( 
		select 
		SiteCodeOfTreatmentAtEpisodeStartDate, 
		MainSpecialtyCode, 
		cnt, 
		row_number() over ( 
		partition by SiteCodeOfTreatmentAtEpisodeStartDate 
		order by cnt desc, MainSpecialtyCode 
		) as rnk 
		from counts 
	)
	select 
		SiteCodeOfTreatmentAtEpisodeStartDate, 
		MainSpecialtyCode 
	from ranked 
	where rnk = 1;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20CareSite%20table%20care_site_name%20field%20SUS%20Inpatient%20Care%20Site%20mapping){: .btn }
