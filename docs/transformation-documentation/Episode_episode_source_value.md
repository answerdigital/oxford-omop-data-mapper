---
layout: default
title: episode_source_value
parent: Episode
grand_parent: Transformation Documentation
has_toc: false
---
# episode_source_value
### SACT Episode
* Value copied from `Regimen`

* `Regimen` Cancer treatment regimen 

```sql
select 
	distinct
	    NHS_Number,
	    Start_Date_Of_Regimen,
	    Regimen,
from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Episode%20table%20episode_source_value%20field%20SACT%20Episode%20mapping){: .btn }
