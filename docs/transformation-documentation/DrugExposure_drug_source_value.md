---
layout: default
title: drug_source_value
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# drug_source_value
### SACT Drug Exposure
* Value copied from `Drug_Name`

* `Drug_Name` The name of the Systemic Anti-Cancer Therapy drug given to a PATIENT during an Systemic Anti-Cancer Therapy Drug Regimen. [SYSTEMIC ANTI-CANCER THERAPY DRUG NAME](https://www.datadictionary.nhs.uk/data_elements/systemic_anti-cancer_therapy_drug_name.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20drug_source_value%20field%20SACT%20Drug%20Exposure%20mapping){: .btn }
