---
layout: default
title: dose_unit_source_value
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# dose_unit_source_value
### SACT Drug Exposure
Source column  `Administration_Measurement_Per_Actual_Dose`.
The UNIT OF MEASUREMENT used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle.


|Administration_Measurement_Per_Actual_Dose|dose_unit_source_value|notes|
|------|-----|-----|
|01|Milligrams (mg)||
|02|Micrograms (Mcg)||
|03|Grams (g)||
|04|Units||
|05|Cells||
|06|Plaque Forming Units (PFU) (one million) (x10^6)||
|07|Plaque Forming Units (PFU) (one hundred million) (x10^8)||


* `Administration_Measurement_Per_Actual_Dose` The UNIT OF MEASUREMENT used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle. [UNIT OF MEASUREMENT (SYSTEMIC ANTI-CANCER THERAPY)](https://www.datadictionary.nhs.uk/data_elements/unit_of_measurement__systemic_anti-cancer_therapy_.html)

```sql
	select
		replace(NHS_Number, ' ', '') as NHS_Number,
		Regimen,
		Drug_Name,
		Actual_Dose_Per_Administration,
		Administration_Measurement_Per_Actual_Dose,
		Administration_Date
	from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20dose_unit_source_value%20field%20SACT%20Drug%20Exposure%20mapping){: .btn }
