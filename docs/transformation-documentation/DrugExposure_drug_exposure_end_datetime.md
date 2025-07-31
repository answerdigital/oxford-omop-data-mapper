---
layout: default
title: drug_exposure_end_datetime
parent: DrugExposure
grand_parent: Transformation Documentation
has_toc: false
---
# drug_exposure_end_datetime
### Oxford Prescribing Drug Exposure
Source column  `end_dt_tm`.
Converts text to dates.

* `end_dt_tm` The end date of the Drug that was initially dispensed to the PATIENT. 

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
from omop_staging.oxford_prescribing
where concept_identifier is null
order by
	patient_identifier_Value,
	beg_dt_tm,
	end_dt_tm,
	catalog,
	order_mnemonic,
	order_detail_display_line,
	rxroute,
	strengthdoseunit,
	strengthdose,
	EVENT_ID
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20drug_exposure_end_datetime%20field%20Oxford%20Prescribing%20Drug%20Exposure%20mapping){: .btn }
### Oxford Prescribing Drug Exposure (with Snomed)
Source column  `end_dt_tm`.
Converts text to dates.

* `end_dt_tm` The end date of the Drug that was initially dispensed to the PATIENT. 

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
	concept_identifier
from omop_staging.oxford_prescribing
where concept_identifier is not null
order by
	patient_identifier_Value,
	beg_dt_tm,
	end_dt_tm,
	order_detail_display_line,
	order_mnemonic,
	rxroute,
	strengthdoseunit,
	strengthdose,
	concept_identifier
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20drug_exposure_end_datetime%20field%20Oxford%20Prescribing%20Drug%20Exposure%20(with%20Snomed)%20mapping){: .btn }
### Oxford GP Drug Exposure
Source column  `LastIssueDate`.
Converts text to dates.

* `LastIssueDate` Last Issue Date 

```sql
select
	distinct
		d.NHSNumber,
		e.LastIssueDate,
		e.SuppliedCode,
		e.Quantity,
		e.Units
	from omop_staging.oxford_gp_medication e
		inner join omop_staging.oxford_gp_demographic d
			on e.PatientIdentifier = d.PatientIdentifier
	order by
		d.NHSNumber,
		e.LastIssueDate,
		e.SuppliedCode,
		e.Quantity,
		e.Units
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20DrugExposure%20table%20drug_exposure_end_datetime%20field%20Oxford%20GP%20Drug%20Exposure%20mapping){: .btn }
