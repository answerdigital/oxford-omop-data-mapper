---
layout: default
title: value_as_concept_id
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# value_as_concept_id
### SACT Adjunctive Therapy Type
Source column  `Adjunctive_Therapy`.
The Adjunctive Therapy Type of the DRUG used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle.


|Adjunctive_Therapy|value_as_concept_id|notes|
|------|-----|-----|
|1|4191637|Adjuvant - intent|
|2|4161587|Neoadjuvant intent|
|3||Not Applicable (Primary Treatment)|
|9||Not Known (Not Recorded)|

Notes
* [SACT ADJUNCTIVE THERAPY TYPE](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/data_elements/adjunctive_therapy_type.html)
* [OMOP](https://athena.ohdsi.org/search-terms/terms/4194400)

* `Adjunctive_Therapy` The type of Adjunctive Therapy  given to a PATIENT  during a Cancer Care Spell. [ADJUNCTIVE THERAPY TYPE](https://www.datadictionary.nhs.uk/data_elements/adjunctive_therapy_type.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_concept_id%20field%20SACT%20Adjunctive%20Therapy%20Type%20mapping){: .btn }
### SACT Administration Route
Source column  `Administration_Route`.
The ADMINISTRATION ROUTE of the DRUG used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle.


|Administration_Route|value_as_concept_id|notes|
|------|-----|-----|
|1|40492287|Intravascular|
|2|4186839|Oromucosal|
|3|4302788|Intraspinal|
|4|4302612|Intramuscular|
|5|4142048|Subcutaneous|
|6|40492287|Intravascular|
|7|4304882|Intraabdominal|
|8|4157757|Intracavernous|
|9|40492302|Intracorporus cavernosum of penis route|
|11|4263689|Topical|
|12|4156706|Intradermal|
|13|40491322|Intratumor|
|14|4157758|Intralesional|
|98|||

Notes
* [SACT Drug Route of Administration](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/data_elements/systemic_anti-cancer_therapy_drug_route_of_administration.html)
* [OMOP](https://athena.ohdsi.org/search-terms/terms/4106215)

* `Administration_Route` The prescribed route of administration for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle. [SYSTEMIC ANTI-CANCER THERAPY DRUG ROUTE OF ADMINISTRATION](https://www.datadictionary.nhs.uk/data_elements/systemic_anti-cancer_therapy_drug_route_of_administration.html)

```sql
		select
		distinct
  			replace(NHS_Number, ' ', '') as NHSNumber,
      		SACT_Administration_Route as Administration_Route,
		  	Administration_Date
	from omop_staging.sact_staging
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_concept_id%20field%20SACT%20Administration%20Route%20mapping){: .btn }
### SACT Treatment Intent
Source column  `Intent_Of_Treatment`.
The Regimen Treatment Intent of the DRUG used for each Systemic Anti-Cancer Therapy Drug Administration in a Systemic Anti-Cancer Therapy Drug Cycle.


|Intent_Of_Treatment|value_as_concept_id|notes|
|------|-----|-----|
|1|4162591|Curative|
|2|4179711|Palliative|
|3|4179711|Palliative|
|4|4179711|Palliative|
|5|4179711|Palliative|
|98||Other (not listed)|
|99||Other (not listed)|

Notes
* [SACT Drug Regimen Treatment Intent](https://archive.datadictionary.nhs.uk/DD%20Release%20May%202024/attributes/systemic_anti-cancer_therapy_drug_regimen_treatment_intent.html)
* [OMOP](https://athena.ohdsi.org/search-terms/terms/4194400)

* `Intent_Of_Treatment` The intent of the Systemic Anti-Cancer Therapy Drug Regimen. [SYSTEMIC ANTI-CANCER THERAPY DRUG REGIMEN TREATMENT INTENT](https://www.datadictionary.nhs.uk/data_elements/systemic_anti-cancer_therapy_drug_regimen_treatment_intent.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_concept_id%20field%20SACT%20Treatment%20Intent%20mapping){: .btn }
### RTDS Treatment Anatomical Site
* Value copied from `AnatomicalSiteConceptId`

* `AnatomicalSiteConceptId` CONCEPT ID OF ANATOMIC SITE OF RADIOTHERAPY PROCEDURE 

```sql
		select distinct
			(select PatientId from omop_staging.rtds_1_demographics d where d.PatientSer = dc.PatientSer limit 1) as NhsNumber,
			AttributeValue,
			(select concept_id from cdm.concept where domain_id = 'Spec Anatomic Site'
				and concept_code = CASE WHEN length(code) > 3 THEN substr(code, 1, 3) || '.' || substr(code, 4) ELSE code END) as AnatomicalSiteConceptId,
			DueDateTime
		from omop_staging.RTDS_2b_Plan dc,
		LATERAL (SELECT regexp_extract(AttributeValue, '^([A-Z][0-9A-Z]+)', 1) AS code) AS t
		where Description = 'Anatomical Site' 
		and AttributeValue is not null 
		and AttributeValue != 'None'
		and NhsNumber is not null
		and regexp_matches(NhsNumber, '\d{10}');
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_concept_id%20field%20RTDS%20Treatment%20Anatomical%20Site%20mapping){: .btn }
