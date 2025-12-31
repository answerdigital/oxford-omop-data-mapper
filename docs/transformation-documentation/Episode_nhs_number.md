---
layout: default
title: nhs_number
parent: Episode
grand_parent: Transformation Documentation
has_toc: false
---
# nhs_number
### SACT Episode
* Value copied from `NHS_Number`

* `NHS_Number` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select 
	distinct
	    NHS_Number,
	    Start_Date_Of_Regimen,
	    Regimen,
from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Episode%20table%20nhs_number%20field%20SACT%20Episode%20mapping){: .btn }
