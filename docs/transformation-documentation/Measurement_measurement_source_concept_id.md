---
layout: default
title: measurement_source_concept_id
parent: Measurement
grand_parent: Transformation Documentation
has_toc: false
---
# measurement_source_concept_id
### Sus OP  Measurement
Source column  `DiagnosisICD`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `DiagnosisICD` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_.html)

```sql
select
    distinct
        d.DiagnosisICD,
        op.GeneratedRecordIdentifier,
        op.NHSNumber,
        op.CDSActivityDate
from omop_staging.sus_OP_ICDDiagnosis d
    inner join omop_staging.sus_OP op
        on d.MessageId = op.MessageId
where op.NHSNumber is not null
	and AttendedorDidNotAttend in ('5','6')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20Sus%20OP%20%20Measurement%20mapping){: .btn }
### Sus APC  Measurement
Source column  `DiagnosisICD`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `DiagnosisICD` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_.html)

```sql
select
    distinct
        d.DiagnosisICD,
        apc.GeneratedRecordIdentifier,
        apc.NHSNumber,
        apc.CDSActivityDate
from omop_staging.sus_ICDDiagnosis d
    inner join omop_staging.sus_APC apc
        on d.MessageId = apc.MessageId
where apc.NHSNumber is not null
order by
	d.DiagnosisICD,
    apc.GeneratedRecordIdentifier,
    apc.NHSNumber,
    apc.CDSActivityDate
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20Sus%20APC%20%20Measurement%20mapping){: .btn }
### Oxford Lab Measurement
Source column  `EVENT`.
OXford Lab Test Lookup lookup


|EVENT|measurement_source_concept_id|notes|
|------|-----|-----|
|Adjusted calcium level, blood|3048816|Calcium.ionized [Moles/volume] adjusted to pH 7.4 in Blood|
|Alanine aminotransferase level, blood|46235106|Alanine aminotransferase [Enzymatic activity/volume] in Blood|
|Albumin level, blood|3043798|Albumin [Presence] in Serum or Plasma|
|Alk phos level, blood|3003650|Alkaline phosphatase [Mass/volume] in Body fluid|
|APTT, blood|3013466|aPTT in Blood by Coagulation assay|
|Basophil count, blood|3006315|Basophils [#/volume] in Blood|
|BE Act (BG)|3005724|B Ag [Presence] on Red Blood Cells|
|BE Std (BG)|3025597|Deprecated Chlamydia trachomatis G+F+K Ab [Units/volume] in Serum|
|Bicarb (BG)|3005724|B Ag [Presence] on Red Blood Cells|
|Blood gases comment|44786790|Volatiles and gases [Presence] in Blood|
|Blood Glucose POC|3020491|Glucose [Moles/volume] in Blood|
|Blood Ketones, POC|3041426|Ketones [Moles/volume] in Blood|
|C-reactive protein level, blood|1091617|C reactive protein [Mass/volume] in Serum, Plasma or Blood|
|Ca+ + (BG)|3036426|Calcium.ionized [Mass/volume] in Blood|
|Calcium level, blood|3027495|Calcium [Presence] in Blood|
|Calculated LDL cholesterol level, blood|3028288|Cholesterol in LDL [Mass/volume] in Serum or Plasma by calculation|
|Cholesterol:HDL ratio, blood|3024723|Cholesterol/Triglyceride [Mass Ratio] in Serum or Plasma|
|Cl- (BG)|46235783|Chloride [Moles/volume] in Serum, Plasma or Blood|
|cLAC (BG)|3034564|CLA2 gene mutations found [Identifier] in Blood or Tissue by Molecular genetics method Nominal|
|Creat (BG)|3026159|Suberate [Presence] in Urine|
|Creatinine level, blood|3051825|Creatinine [Mass/volume] in Blood|
|Creatinine level, urine|3007081|Creatinine [Interpretation] in Urine|
|ctO2c (BG)|40763341|Ascorbate [Moles/volume] in Specimen|
|eGFR comment|40758890|EGFR gene c.2369C>T [Presence] in Blood or Tissue by Molecular genetics method|
|Eosinophil count, blood|3013115|Eosinophils [#/volume] in Blood|
|Estimated GFR, blood|3045262|Creatinine and Glomerular filtration rate.predicted panel - Serum, Plasma or Blood|
|Estimated Osmolality (BG)|3008295|Osmolality of Serum or Plasma|
|FCOHb (BG)|3033821|Fy sup(b) Ab [Presence] in Serum or Plasma from Blood product unit|
|Ferritin level, serum|3001122|Ferritin [Mass/volume] in Serum or Plasma|
|FIO2|3006455|Oxygen [Partial pressure] in Exhaled gas|
|Folate level, serum|3033201|Folate [Mass/volume] in Serum or Plasma|
|General biochemistry comment|3025981|Arginine+Argininosuccinate+Lysine+Serine+Taurine [Presence] in Urine|
|Glucose (BG)|3000483|Glucose [Mass/volume] in Blood|
|Glucose level, plasma|44816672|Glucose [Mass/volume] in Serum, Plasma or Blood|
|Glycated haemoglobin reference, blood|3005131|Glucose mean value [Mass/volume] in Blood Estimated from glycated hemoglobin|
|Haematocrit level, blood|3009542|Hematocrit [Volume Fraction] of Blood by calculation|
|Haematology comment|40762529|Hematologist review of results|
|Haemoglobin|3000963|Hemoglobin [Mass/volume] in Blood|
|Haemoglobin A1c DCCT aligned, blood|3005673|Hemoglobin A1c/Hemoglobin.total in Blood by HPLC|
|Hb (BG)|3041888|Hemoglobin H [Presence] in Blood|
|HBA1c comment|3005673|Hemoglobin A1c/Hemoglobin.total in Blood by HPLC|
|Hct (BG)|36203329|Bg sup(b) Ag [Presence] on Red Blood Cells|
|HDL cholesterol level, blood|3011884|Cholesterol in HDL [Presence] in Serum or Plasma|
|Immature Granulocytes count, blood|3040168|Immature granulocytes [#/volume] in Blood|
|Inorganic phosphate level, blood|3024232|Phosphate [Mass/volume] in Blood|
|Iron level, serum|3021862|Iron [Interpretation] in Serum or Plasma|
|K+ (BG)|21490733|Potassium [Mass/volume] in Blood|
|Lymphocyte count, blood|3019198|Lymphocytes [#/volume] in Blood|
|Magnesium level, blood|3006916|Magnesium [Presence] in Blood|
|Mean cell haemoglobin conc, blood|3000963|Hemoglobin [Mass/volume] in Blood|
|Mean cell haemoglobin level, blood|3000963|Hemoglobin [Mass/volume] in Blood|
|Mean cell volume, blood|3033607|Volume of Blood|
|Mean platelet volume, blood|3001123|Platelet [Entitic mean volume] in Blood|
|MetHb (BG)|3008524|Presence in Serum or Plasma|
|Miscellaneous Immunology comment|3029658|Other cells/Leukocytes in Body fluid|
|Monocyte count, blood|3001604|Monocytes [#/volume] in Blood|
|Na+ (BG)|3000285|Sodium [Moles/volume] in Blood|
|Neutrophil count, blood|3017732|Neutrophils [#/volume] in Blood|
|Non-HDL cholesterol, blood|3044491|Cholesterol non HDL [Mass/volume] in Serum or Plasma|
|NRBC count per 100 WBC, blood|3020036|Deprecated Nucleated Erythrocytes/100 leukocytes [Ratio] in Blood|
|Nucleated red blood cell count, blood|3001490|Nucleated erythrocytes [#/volume] in Blood|
|O2 Sat (BG)|3016502|Oxygen saturation in Arterial blood|
|O_Bone profile, blood|3016185|O group [Presence] on Red Blood Cells from Donor|
|O_C-reactive protein level, blood|3051387|C reactive protein [Mass/volume] in Capillary blood|
|O_Calcium level, blood|3027495|Calcium [Presence] in Blood|
|O_Clotting screen, blood|40770392|Thromboelastography panel - Blood|
|O_Full Blood Count|3033204|Hemoglobin O - Arab/Hemoglobin.total in Blood|
|O_Magnesium level, blood|3033836|Magnesium [Moles/volume] in Blood|
|O_Urea and electrolytes, blood|3004295|Urea nitrogen [Mass/volume] in Blood|
|p5Oc (BG)|3008617|O group [Presence] on Red Blood Cells from Blood product unit|
|pCO2 POC|3013290|Carbon dioxide [Partial pressure] in Blood|
|pCO2(T)c|3010140|Carbon dioxide, total [Moles/volume] in Venous blood|
|pH (BG)|3010421|pH of Blood|
|pH(T)c|1616438|pH of Central venous blood|
|Platelet count, blood|3007461|Platelets [#/volume] in Blood|
|pO2 (BG)|3003246|Oxygen [Partial pressure] in Exhaled gas|
|pO2(T)c|1616654|Oxygen [Partial pressure] in Central venous blood|
|Potassium level, blood|21490733|Potassium [Mass/volume] in Blood|
|Prothrombin time and INR, blood|3014391|Thrombin time [Interpretation] in Blood|
|Prothrombin time, blood|3034426|Prothrombin time (PT)|
|Red blood cell count, blood|3026361|Erythrocytes [#/volume] in Blood|
|Red Blood Cell Distribution Width|3002385|Erythrocyte [DistWidth] in Red Blood Cells|
|Sodium level, blood|3000285|Sodium [Moles/volume] in Blood|
|Specimen type (BG)|40769406|Specimen type|
|Temperature POCT|21492846|Environment temperature during transport|
|Thyroid stimulating hormone, blood|3011450|Thyrotropin [Presence] in Blood|
|Total bilirubin level, blood|3028833|Bilirubin.total [Mass/volume] in Blood|
|Total cholesterol level, blood|3012041|Choleglobin/Hemoglobin.total in Blood|
|Transferrin level, blood|3004789|Transferrin [Mass/volume] in Serum or Plasma|
|Transferrin Saturation|3007987|Deprecated Transferrin saturation in Serum or Plasma|
|Triglycerides level, blood|3022038|Triglyceride [Mass/volume] in Blood|
|Urea level, plasma|3034204|Urea [Mass/volume] in Serum or Plasma|
|Vitamin B12 level, serum|3031790|Cobalamin (Vitamin B12) [Mass/volume] in Serum|
|Vitamin D level, blood|36031904|25-hydroxyvitamin D3+25-hydroxyvitamin D2 [Mass/volume] in Capillary blood|
|Warfarin comment|3026207|Warfarin [Mass/volume] in Urine|
|Warfarin Dose|3024105|Warfarin [Mass] of Dose|
|White blood cell count, blood|3010813|Leukocytes [#/volume] in Blood|


* `EVENT` Lab test event []()

```sql
select
	NHS_NUMBER,
	EVENT,
	EVENT_START_DT_TM,
	RESULT_VALUE,
	RESULT_UNITS,
	NORMAL_LOW,
	NORMAL_HIGH
from ##duckdb_source##
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20Oxford%20Lab%20Measurement%20mapping){: .btn }
### COSD V9 Measurement TNM Category Integrated Stage
* Constant value set to `2000500013`. TNMCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20TNM%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement TNM Category Final Pre Treatment Stage
* Constant value set to `2000500017`. TNMCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20TNM%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement T Category Integrated Stage
* Constant value set to `2000500012`. TCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20T%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement T Category Final Pre Treatment Stage
* Constant value set to `2000500016`. TCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20T%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement Primary Pathway Metastasis
* Constant value set to `2000500007`. PrimaryPathwayMetastasis

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20Primary%20Pathway%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement Non Primary Pathway Recurrence Metastasis
* Constant value set to `2000500008`. NonPrimaryPathwayRecurrenceMetastasis

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20Non%20Primary%20Pathway%20Recurrence%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement Non Primary Pathway Progression Metastasis
* Constant value set to `2000500009`. NonPrimaryPathwayProgressionMetastasis

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20Non%20Primary%20Pathway%20Progression%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement N Category Integrated Stage
* Constant value set to `2000500011`. NCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20N%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement N Category Final Pre Treatment Stage
* Constant value set to `2000500015`. NCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20N%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement M Category Integrated Stage
* Constant value set to `2000500010`. MCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20M%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement M Category Final Pre Treatment Stage
* Constant value set to `2000500014`. MCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V9%20Measurement%20M%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement TNM Category Integrated Stage
* Constant value set to `2000500013`. TNMCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20TNM%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement TNM Category Final Pre Treatment Stage
* Constant value set to `2000500017`. TNMCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20TNM%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement T Category Integrated Stage
* Constant value set to `2000500012`. TCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20T%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement T Category Final Pre Treatment Stage
* Constant value set to `2000500016`. TCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20T%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement N Category Integrated Stage
* Constant value set to `2000500011`. NCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20N%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement N Category Final Pre Treatment Stage
* Constant value set to `2000500015`. NCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20N%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement M Category Integrated Stage
* Constant value set to `2000500010`. MCategoryIntegratedStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20M%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement M Category Final Pre Treatment Stage
* Constant value set to `2000500014`. MCategoryFinalPreTreatmentStage

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_source_concept_id%20field%20COSD%20V8%20Measurement%20M%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
