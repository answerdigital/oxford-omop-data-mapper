---
layout: default
title: sig
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# sig
### SACT Drug Exposure
* Value copied from `Regimen`

* `Regimen` Specific combination of drugs and their scheduled administration plan used to treat a patient's cancer [Regimen]()

```sql
	select
		distinct
		replace(NHS_Number, ' ', '') as NHS_Number,
		Regimen,
		lower(Drug_Name) as Drug_Name,
		Actual_Dose_Per_Administration,
		Administration_Measurement_Per_Actual_Dose,
		CASE
			-- yyyy-MM-dd format
			WHEN Administration_Date LIKE '____-__-__' 
				THEN CAST(strptime(Administration_Date, '%Y-%m-%d') AS TIMESTAMP)
			-- dd/MM/yyyy format, where day is between 1 and 31
			WHEN Administration_Date LIKE '__/__/____' AND CAST(substring(Administration_Date, 1, 2) AS INTEGER) BETWEEN 1 AND 31
				THEN CAST(strptime(Administration_Date, '%d/%m/%Y') AS TIMESTAMP)
			-- Otherwise assume MM/dd/yyyy format
			WHEN Administration_Date LIKE '__/__/____'
				THEN CAST(strptime(Administration_Date, '%m/%d/%Y') AS TIMESTAMP)
			ELSE NULL
		END AS Administration_Date
	from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20sig%20field%20SACT%20Drug%20Exposure%20mapping){: .btn }
### Oxford Prescribing Drug Exposure
* Value copied from `order_detail_display_line`

* `order_detail_display_line` All the prescribed drug item details as shown in the order screen as selected by the clinician 

```sql
select
	patient_identifier_Value,
	beg_dt_tm,
	end_dt_tm,
	lower(replace(catalog, 'zzz', '')) as catalog,
	lower(order_mnemonic) as order_mnemonic,
	order_detail_display_line,
	lower(rxroute) as rxroute,
	strengthdoseunit,
	strengthdose,
	EVENT_ID
from ##duckdb_source##
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20sig%20field%20Oxford%20Prescribing%20Drug%20Exposure%20mapping){: .btn }
### Oxford Prescribing Drug Exposure (with Snomed)
* Value copied from `order_detail_display_line`

* `order_detail_display_line` All the prescribed drug item details as shown in the order screen as selected by the clinician 

```sql
select
	patient_identifier_Value,
	beg_dt_tm,
	end_dt_tm,
	order_detail_display_line,
	order_mnemonic,
	lower(rxroute) as rxroute,
	strengthdoseunit,
	strengthdose,
	concept_identifier,
	EVENT_ID
from ##duckdb_source##
where concept_identifier is not null
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20sig%20field%20Oxford%20Prescribing%20Drug%20Exposure%20(with%20Snomed)%20mapping){: .btn }
