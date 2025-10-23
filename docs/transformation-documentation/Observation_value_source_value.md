---
layout: default
title: value_source_value
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# value_source_value
### SACT Adjunctive Therapy Type
* Value copied from `Source_value`

* `Source_value` Source value of the type of Adjunctive Therapy  given to a PATIENT  during a Cancer Care Spell. [ADJUNCTIVE THERAPY TYPE]()

```sql
		select distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
			Adjunctive_Therapy,
			Case 
				When Adjunctive_Therapy = 1 then concat(Adjunctive_Therapy, ' - Adjuvant Therapy')
				When Adjunctive_Therapy = 2 then concat(Adjunctive_Therapy, ' - Neoadjuvant Therapy')
				When Intent_Of_Treatment = 3 then concat(Adjunctive_Therapy, ' - Not Applicable (Primary Treatment)')
				When Intent_Of_Treatment = 9 then concat(Adjunctive_Therapy, ' - Not Known (Not Recorded)')
			else '' end as Source_value,
		  	Administration_Date
		from omop_staging.sact_staging
  		where Adjunctive_Therapy != ''
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20SACT%20Adjunctive%20Therapy%20Type%20mapping){: .btn }
### SACT Administration Route
* Value copied from `Administration_Route`

* `Administration_Route` The prescribed route of administration for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle. [SYSTEMIC ANTI-CANCER THERAPY DRUG ROUTE OF ADMINISTRATION]()

```sql
		select
		distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
      		SACT_Administration_Route as Administration_Route,
		  	Administration_Date
	from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20SACT%20Administration%20Route%20mapping){: .btn }
### SACT Treatment Intent
* Value copied from `Source_value`

* `Source_value` Source value of the intent of the Systemic Anti-Cancer Therapy Drug Regimen. [SYSTEMIC ANTI-CANCER THERAPY DRUG REGIMEN TREATMENT INTENT]()

```sql
		select distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
			Intent_Of_Treatment,
			Case 
				When Intent_Of_Treatment = 1 then concat(Intent_Of_Treatment, ' - Curative(aiming to permanently eradicate disease)')
				When Intent_Of_Treatment = 2 then concat(Intent_Of_Treatment, ' - Palliative(aiming to extend life expectancy)')
				When Intent_Of_Treatment = 3 then concat(Intent_Of_Treatment, ' - Palliative(aiming to relieve and/or control malignancy related symptoms)')
				When Intent_Of_Treatment = 4 then concat(Intent_Of_Treatment, ' - Palliative(aiming to achieve remission)')
				When Intent_Of_Treatment = 5 then concat(Intent_Of_Treatment, ' - Palliative(aiming to permanently eradicate disease)')
			else '' end as Source_value,
		  	Administration_Date
		from omop_staging.sact_staging
        where Intent_Of_Treatment != ''
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_source_value%20field%20SACT%20Treatment%20Intent%20mapping){: .btn }
