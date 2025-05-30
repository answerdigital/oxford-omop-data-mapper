---
layout: default
title: quantity
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# quantity
### SACT Drug Exposure
Source column  `Actual_Dose_Per_Administration`.
Converts text to floating-point numbers.

* `Actual_Dose_Per_Administration` The actual Systemic Anti-Cancer Therapy dose given in each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle. [SYSTEMIC ANTI-CANCER THERAPY ACTUAL DOSE](https://www.datadictionary.nhs.uk/data_elements/systemic_anti-cancer_therapy_actual_dose.html)

```sql
	select
		distinct
		replace(NHS_Number, ' ', '') as NHS_Number,
		Regimen,
		Drug_Name,
		Actual_Dose_Per_Administration,
		Administration_Measurement_Per_Actual_Dose,
		Administration_Date
	from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20quantity%20field%20SACT%20Drug%20Exposure%20mapping){: .btn }
