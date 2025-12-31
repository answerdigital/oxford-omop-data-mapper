---
layout: default
title: episode_start_date
parent: Episode
grand_parent: Transformation Documentation
has_toc: false
---
# episode_start_date
### SACT Episode
Source column  `Start_Date_Of_Regimen`.
Converts text to dates.

* `Start_Date_Of_Regimen` Regimen StartDate 

```sql
select 
	distinct
	    NHS_Number,
	    Start_Date_Of_Regimen,
	    Regimen,
from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Episode%20table%20episode_start_date%20field%20SACT%20Episode%20mapping){: .btn }
