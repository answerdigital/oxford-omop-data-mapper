---
layout: default
title: nhs_number
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# nhs_number
### SACT Drug Exposure
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
	select
		NHS_Number,
		Regimen,
		Drug_Name,
		Actual_Dose_Per_Administration,
		Administration_Measurement_Per_Actual_Dose,
		Administration_Date
	from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20nhs_number%20field%20SACT%20Drug%20Exposure%20mapping){: .btn }
