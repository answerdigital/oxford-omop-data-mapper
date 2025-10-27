---
layout: default
title: measurement_concept_id
parent: Measurement
grand_parent: Transformation Documentation
has_toc: false
---
# measurement_concept_id
### Sus OP  Measurement
Source column  `measurement_source_concept_id`.
Maps concepts to standard valid concepts in the `measurement` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20Sus%20OP%20%20Measurement%20mapping){: .btn }
### Sus CCMDS Measurement - Gestation Length at Delivery
* Constant value set to `4260747`. Length of gestation at birth

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20Sus%20CCMDS%20Measurement%20-%20Gestation%20Length%20at%20Delivery%20mapping){: .btn }
### Sus CCMDS Measurement - Person Weight
* Constant value set to `4099154`. Body Weight

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20Sus%20CCMDS%20Measurement%20-%20Person%20Weight%20mapping){: .btn }
### Sus APC  Measurement
Source column  `measurement_source_concept_id`.
Maps concepts to standard valid concepts in the `measurement` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20Sus%20APC%20%20Measurement%20mapping){: .btn }
### SACT Measurement Weight at Start of Regimen
* Constant value set to `4099154`. Body Weight

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20SACT%20Measurement%20Weight%20at%20Start%20of%20Regimen%20mapping){: .btn }
### SACT Measurement Weight at Start of Cycle
* Constant value set to `4099154`. Body Weight

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20SACT%20Measurement%20Weight%20at%20Start%20of%20Cycle%20mapping){: .btn }
### SACT  Measurement Height
* Constant value set to `607590`. Body Height

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20SACT%20%20Measurement%20Height%20mapping){: .btn }
### Oxford Lab Measurement
Source column  `measurement_source_concept_id`.
Maps concepts to standard valid concepts in the `measurement` domain.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20Oxford%20Lab%20Measurement%20mapping){: .btn }
### COSD V9 Measurement Tumour Laterality
Source column  `TumourLaterality`.
Lookup TumourLaterality concepts.


|TumourLaterality|measurement_concept_id|notes|
|------|-----|-----|
|L|36770232|Left|
|R|36770058|Right|
|M|36769853|Midline|
|B|36770109|Bilateral|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&conceptClass=Topography&page=1&pageSize=500&query=&boosts)
* [NHS - Tumour Laterality](https://www.datadictionary.nhs.uk/data_elements/tumour_laterality.html?hl=tumour%2Claterality)

* `TumourLaterality` Identifies the side of the body for a Tumour relating to paired organs within a PATIENT. [TUMOUR LATERALITY]()

```sql
select 
	distinct
	    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
	    Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
	    Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.TumourLaterality.@code' as TumourLaterality
from omop_staging.cosd_staging_901
where type = 'CO'
  and (Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.TumourLaterality.@code') in ('L','R','M','B');
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20Tumour%20Laterality%20mapping){: .btn }
### COSD V9 Measurement TNM Category Integrated Stage
Source column  `TnmStageGroupingIntegrated`.
Lookup TNMCategory concepts.


|TnmStageGroupingIntegrated|measurement_concept_id|notes|
|------|-----|-----|
|1|1635812|IRS-modified TNM stage 1|
|I|1635812|IRS-modified TNM stage 1|
|1a|1635812|IRS-modified TNM stage 1|
|IA|1635812|IRS-modified TNM stage 1|
|1b|1635812|IRS-modified TNM stage 1|
|IB|1635812|IRS-modified TNM stage 1|
|2|1635007|IRS-modified TNM stage 2|
|II|1635007|IRS-modified TNM stage 2|
|2a|1635007|IRS-modified TNM stage 2|
|IIA|1635007|IRS-modified TNM stage 2|
|2b|1635007|IRS-modified TNM stage 2|
|IIB|1635007|IRS-modified TNM stage 2|
|2c|1635007|IRS-modified TNM stage 2|
|IIC|1635007|IRS-modified TNM stage 2|
|3|1633995|IRS-modified TNM stage 3|
|III|1633995|IRS-modified TNM stage 3|
|3a|1633995|IRS-modified TNM stage 3|
|IIIA|1633995|IRS-modified TNM stage 3|
|3b|1633995|IRS-modified TNM stage 3|
|IIIB|1633995|IRS-modified TNM stage 3|
|3c|1633995|IRS-modified TNM stage 3|
|IIIC|1633995|IRS-modified TNM stage 3|
|4|1634737|IRS-modified TNM stage 4|
|IV|1634737|IRS-modified TNM stage 4|
|4a|1634737|IRS-modified TNM stage 4|
|IVA|1634737|IRS-modified TNM stage 4|
|4b|1634737|IRS-modified TNM stage 4|
|IVB|1634737|IRS-modified TNM stage 4|
|4c|1634737|IRS-modified TNM stage 4|
|IVC|1634737|IRS-modified TNM stage 4|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `TnmStageGroupingIntegrated` Is the code, using a TNM CODING EDITION, which classifies the combination of Tumour, node and metastases into stage groupings after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [TNM STAGE GROUPING (INTEGRATED)]()

```sql
select distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(
        Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage',
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed'
    ) as MeasurementDate,
    Record ->> '$.PrimaryPathway.Staging.TnmStageGroupingIntegrated' as TnmStageGroupingIntegrated
from omop_staging.cosd_staging_901
where type = 'CO'
  and TnmStageGroupingIntegrated is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20TNM%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement TNM Category Final Pre Treatment Stage
Source column  `TnmStageGroupingFinalPretreatment`.
Lookup TNMCategory concepts.


|TnmStageGroupingFinalPretreatment|measurement_concept_id|notes|
|------|-----|-----|
|1|1635812|IRS-modified TNM stage 1|
|I|1635812|IRS-modified TNM stage 1|
|1a|1635812|IRS-modified TNM stage 1|
|IA|1635812|IRS-modified TNM stage 1|
|1b|1635812|IRS-modified TNM stage 1|
|IB|1635812|IRS-modified TNM stage 1|
|2|1635007|IRS-modified TNM stage 2|
|II|1635007|IRS-modified TNM stage 2|
|2a|1635007|IRS-modified TNM stage 2|
|IIA|1635007|IRS-modified TNM stage 2|
|2b|1635007|IRS-modified TNM stage 2|
|IIB|1635007|IRS-modified TNM stage 2|
|2c|1635007|IRS-modified TNM stage 2|
|IIC|1635007|IRS-modified TNM stage 2|
|3|1633995|IRS-modified TNM stage 3|
|III|1633995|IRS-modified TNM stage 3|
|3a|1633995|IRS-modified TNM stage 3|
|IIIA|1633995|IRS-modified TNM stage 3|
|3b|1633995|IRS-modified TNM stage 3|
|IIIB|1633995|IRS-modified TNM stage 3|
|3c|1633995|IRS-modified TNM stage 3|
|IIIC|1633995|IRS-modified TNM stage 3|
|4|1634737|IRS-modified TNM stage 4|
|IV|1634737|IRS-modified TNM stage 4|
|4a|1634737|IRS-modified TNM stage 4|
|IVA|1634737|IRS-modified TNM stage 4|
|4b|1634737|IRS-modified TNM stage 4|
|IVB|1634737|IRS-modified TNM stage 4|
|4c|1634737|IRS-modified TNM stage 4|
|IVC|1634737|IRS-modified TNM stage 4|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `TnmStageGroupingFinalPretreatment` Is the code, using a TNM CODING EDITION, which classifies the combination of Tumour, node and metastases into stage groupings before treatment during a Cancer Care Spell. [TNM STAGE GROUPING (FINAL PRETREATMENT)]()

```sql
select 
  distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(
        Record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage',
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed'
    ) as MeasurementDate,
    Record ->> '$.PrimaryPathway.Staging.TnmStageGroupingFinalPretreatment' as TnmStageGroupingFinalPretreatment
from omop_staging.cosd_staging_901
where type = 'CO'
  and TnmStageGroupingFinalPretreatment is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20TNM%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement T Category Integrated Stage
Source column  `TCategoryIntegratedStage`.
Lookup TCategory concepts.


|TCategoryIntegratedStage|measurement_concept_id|notes|
|------|-----|-----|
|0|1634213|AJCC/UICC T0 Category|
|1|1635564|AJCC/UICC T1 Category|
|1a|1633880|AJCC/UICC T1a Category|
|1b|1633921|AJCC/UICC T1b Category|
|1c|1633529|AJCC/UICC T1c Category|
|1d|1634100|AJCC/UICC T1d Category|
|2|1635562|AJCC/UICC T2 Category|
|2a|1635327|AJCC/UICC T2a Category|
|2b|1633593|AJCC/UICC T2b Category|
|2c|1635270|AJCC/UICC T2c Category|
|2d|1633678|AJCC/UICC T2d Category|
|3|1634376|AJCC/UICC T3 Category|
|3a|1633771|AJCC/UICC T3a Category|
|3b|1634980|AJCC/UICC T3b Category|
|3c|1633360|AJCC/UICC T3c Category|
|3d|1635625|AJCC/UICC T3d Category|
|3e|1634730|AJCC/UICC T3e Category|
|4|1634654|AJCC/UICC T4 Category|
|4a|1635222|AJCC/UICC T4a Category|
|4b|1634436|AJCC/UICC T4b Category|
|4c|1635526|AJCC/UICC T4c Category|
|4d|1633909|AJCC/UICC T4d Category|
|4e|1634193|AJCC/UICC T4e Category|
|X|1635682|AJCC/UICC TX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `TCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the size and extent of the primary Tumour after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [T CATEGORY (INTEGRATED STAGE)]()

```sql
select 
  distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(
        Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage',
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed'
    ) as MeasurementDate,
    Record ->> '$.PrimaryPathway.Staging.TCategoryIntegratedStage' as TCategoryIntegratedStage
from omop_staging.cosd_staging_901
where type = 'CO'
  and TCategoryIntegratedStage is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20T%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement T Category Final Pre Treatment Stage
Source column  `TcategoryFinalPreTreatment`.
Lookup TCategory concepts.


|TcategoryFinalPreTreatment|measurement_concept_id|notes|
|------|-----|-----|
|0|1634213|AJCC/UICC T0 Category|
|1|1635564|AJCC/UICC T1 Category|
|1a|1633880|AJCC/UICC T1a Category|
|1b|1633921|AJCC/UICC T1b Category|
|1c|1633529|AJCC/UICC T1c Category|
|1d|1634100|AJCC/UICC T1d Category|
|2|1635562|AJCC/UICC T2 Category|
|2a|1635327|AJCC/UICC T2a Category|
|2b|1633593|AJCC/UICC T2b Category|
|2c|1635270|AJCC/UICC T2c Category|
|2d|1633678|AJCC/UICC T2d Category|
|3|1634376|AJCC/UICC T3 Category|
|3a|1633771|AJCC/UICC T3a Category|
|3b|1634980|AJCC/UICC T3b Category|
|3c|1633360|AJCC/UICC T3c Category|
|3d|1635625|AJCC/UICC T3d Category|
|3e|1634730|AJCC/UICC T3e Category|
|4|1634654|AJCC/UICC T4 Category|
|4a|1635222|AJCC/UICC T4a Category|
|4b|1634436|AJCC/UICC T4b Category|
|4c|1635526|AJCC/UICC T4c Category|
|4d|1633909|AJCC/UICC T4d Category|
|4e|1634193|AJCC/UICC T4e Category|
|X|1635682|AJCC/UICC TX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `TcategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the size and extent of the primary Tumour before treatment during a Cancer Care Spell. [T CATEGORY (FINAL PRETREATMENT)]()

```sql
select 
  distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(
        Record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage',
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed'
    ) as MeasurementDate,
    Record ->> '$.PrimaryPathway.Staging.TCategoryFinalPretreatment' as TcategoryFinalPreTreatment
from omop_staging.cosd_staging_901
where type = 'CO'
  and TcategoryFinalPreTreatment is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20T%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement Synchronous Tumour Indicator
Source column  `SynchronousTumourIndicator`.
Lookup SynchronousTumour concepts.


|SynchronousTumourIndicator|measurement_concept_id|notes|
|------|-----|-----|
|01|36768217|Cecum|
|02|36770601|Appendix|
|03|36768852|Ascending Colon|
|04|36768109|Hepatic Flexure|
|05|36770627|Transverse Colon|
|06|36769645|Splenic Flexure|
|07|36769819|Descending Colon|
|08|36770395|Sigmoid Colon|
|09|36768690|Rectosigmoid|
|10|36769244|Rectum|

Notes
* [OMOP Cancer Modifier Measurements](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&standardConcept=Standard&page=1&pageSize=500&query=&boosts)
* [NHS - Synchronous Tumour Colon location (at Diagnosis)](https://www.datadictionary.nhs.uk/data_elements/synchronous_tumour_colon_location__at_diagnosis_.html?hl=synchronous%2Ctumour%2Ccolon%2Clocation%2Cdiagnosis)

* `SynchronousTumourIndicator` An indication of whether there is a presence of synchronous tumours at a tumour site during a Cancer Care Spell. [SYNCHRONOUS TUMOUR INDICATOR]()

```sql
select 
	distinct
	    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
	    Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
	    Record ->> '$.PrimaryPathway.Diagnosis.DiagnosisColorectal.SynchronousTumourIndicator.@code' as SynchronousTumourIndicator
from omop_staging.cosd_staging_901
where type = 'CO'
  and SynchronousTumourIndicator is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20Synchronous%20Tumour%20Indicator%20mapping){: .btn }
### COSD V9 Measurement Primary Pathway Metastasis
Source column  `MetastaticSite`.
Lookup MetastasisSite concepts.


|MetastaticSite|measurement_concept_id|notes|
|------|-----|-----|
|02|36768862|Metastasis to brain|
|03|36770544|Metastasis to liver|
|04|36770283|Metastasis to lung|
|07|36769180|Metastasis to the Unknown Site|
|08|35225673|Metastasis to skin|
|09|36769243|Distant spread to lymph node|
|10|36769301|Metastasis to bone|
|11|35226074|Metastasis to bone marrow|
|12|36769269|Regional spread to lymph node|
|98|36769180|Metastasis|
|99|36769180|Metastasis|

Notes
* [OMOP Metastasis](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=metastasis&boosts)
* [NHS - Metastasis](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html?hl=metastatic%2Csite%2Cdiagnosis)

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)]()

```sql
with CO as (
    select distinct
        Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
        unnest(
            [
                [ Record ->> '$.PrimaryPathway.Diagnosis.MetastaticTypeAndSiteDiagnosis.MetastaticSite.@code' ],
                Record ->> '$.PrimaryPathway.Diagnosis.MetastaticTypeAndSiteDiagnosis[*].MetastaticSite.@code'
            ],
            recursive := true
        ) as MetastaticSite
    from omop_staging.cosd_staging_901
    where type = 'CO'
)
select distinct
    NhsNumber,
    DateOfPrimaryDiagnosisClinicallyAgreed,
    MetastaticSite
from CO
where MetastaticSite is not null
  and MetastaticSite != '97';
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20Primary%20Pathway%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement Non Primary Pathway Recurrence Metastasis
Source column  `MetastaticSite`.
Lookup MetastasisSite concepts.


|MetastaticSite|measurement_concept_id|notes|
|------|-----|-----|
|02|36768862|Metastasis to brain|
|03|36770544|Metastasis to liver|
|04|36770283|Metastasis to lung|
|07|36769180|Metastasis to the Unknown Site|
|08|35225673|Metastasis to skin|
|09|36769243|Distant spread to lymph node|
|10|36769301|Metastasis to bone|
|11|35226074|Metastasis to bone marrow|
|12|36769269|Regional spread to lymph node|
|98|36769180|Metastasis|
|99|36769180|Metastasis|

Notes
* [OMOP Metastasis](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=metastasis&boosts)
* [NHS - Metastasis](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html?hl=metastatic%2Csite%2Cdiagnosis)

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)]()

```sql
with CO as (
    select distinct
        Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
        Record ->> '$.NonPrimaryPathway.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
        unnest(
            [
                [ Record ->> '$.NonPrimaryPathway.Recurrence.MetastaticTypeAndSiteRecurrence.MetastaticSite.@code' ],
                Record ->> '$.NonPrimaryPathway.Recurrence.MetastaticTypeAndSiteRecurrence[*].MetastaticSite.@code'
            ],
            recursive := true
        ) as MetastaticSite
    from omop_staging.cosd_staging_901
    where type = 'CO'
)
select distinct
    NhsNumber,
    DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
    MetastaticSite
from CO
where MetastaticSite is not null
  and MetastaticSite != '97';
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20Non%20Primary%20Pathway%20Recurrence%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement Non Primary Pathway Progression Metastasis
Source column  `MetastaticSite`.
Lookup MetastasisSite concepts.


|MetastaticSite|measurement_concept_id|notes|
|------|-----|-----|
|02|36768862|Metastasis to brain|
|03|36770544|Metastasis to liver|
|04|36770283|Metastasis to lung|
|07|36769180|Metastasis to the Unknown Site|
|08|35225673|Metastasis to skin|
|09|36769243|Distant spread to lymph node|
|10|36769301|Metastasis to bone|
|11|35226074|Metastasis to bone marrow|
|12|36769269|Regional spread to lymph node|
|98|36769180|Metastasis|
|99|36769180|Metastasis|

Notes
* [OMOP Metastasis](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=metastasis&boosts)
* [NHS - Metastasis](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html?hl=metastatic%2Csite%2Cdiagnosis)

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)]()

```sql
with CO as (
    select distinct
        Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
        Record ->> '$.NonPrimaryPathway.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
        unnest(
            [
                [ Record ->> '$.NonPrimaryPathway.Progression.MetastaticTypeAndSiteProgression.MetastaticSite.@code' ],
                Record ->> '$.NonPrimaryPathway.Progression.MetastaticTypeAndSiteProgression[*].MetastaticSite.@code'
            ],
            recursive := true
        ) as MetastaticSite
    from omop_staging.cosd_staging_901
    where type = 'CO'
)
select
    distinct
    NhsNumber,
    DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
    MetastaticSite
from CO
where MetastaticSite is not null
  and MetastaticSite != '97';
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20Non%20Primary%20Pathway%20Progression%20Metastasis%20mapping){: .btn }
### COSD V9 Measurement N Category Integrated Stage
Source column  `NCategoryIntegratedStage`.
Lookup NCategory concepts.


|NCategoryIntegratedStage|measurement_concept_id|notes|
|------|-----|-----|
|0|1633440|AJCC/UICC N0 Category|
|0a|1633621|AJCC/UICC N0a Category|
|0b|1635244|AJCC/UICC N0b Category|
|1|1634434|AJCC/UICC N1 Category|
|1a|1633735|AJCC/UICC N1a Category|
|1b|1635130|AJCC/UICC N1b Category|
|1c|1634620|AJCC/UICC N1c Category|
|2|1634119|AJCC/UICC N2 Category|
|2a|1635644|AJCC/UICC N2a Category|
|2b|1634134|AJCC/UICC N2b Category|
|2c|1634080|AJCC/UICC N2c Category|
|3|1635320|AJCC/UICC N3 Category|
|3a|1635590|AJCC/UICC N3a Category|
|3b|1633422|AJCC/UICC N3b Category|
|3c|1634735|AJCC/UICC N3c Category|
|4|1635445|AJCC/UICC N4 Category|
|X|1633885|AJCC/UICC NX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `NCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the absence or presence and extent of regional Lymph Node metastases after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [N CATEGORY (INTEGRATED STAGE)]()

```sql
select 
  distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(
        Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage',
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed'
    ) as MeasurementDate,
    Record ->> '$.PrimaryPathway.Staging.NCategoryIntegratedStage' as NCategoryIntegratedStage
from omop_staging.cosd_staging_901
where type = 'CO'
  and NCategoryIntegratedStage is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20N%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement N Category Final Pre Treatment Stage
Source column  `NcategoryFinalPreTreatment`.
Lookup NCategory concepts.


|NcategoryFinalPreTreatment|measurement_concept_id|notes|
|------|-----|-----|
|0|1633440|AJCC/UICC N0 Category|
|0a|1633621|AJCC/UICC N0a Category|
|0b|1635244|AJCC/UICC N0b Category|
|1|1634434|AJCC/UICC N1 Category|
|1a|1633735|AJCC/UICC N1a Category|
|1b|1635130|AJCC/UICC N1b Category|
|1c|1634620|AJCC/UICC N1c Category|
|2|1634119|AJCC/UICC N2 Category|
|2a|1635644|AJCC/UICC N2a Category|
|2b|1634134|AJCC/UICC N2b Category|
|2c|1634080|AJCC/UICC N2c Category|
|3|1635320|AJCC/UICC N3 Category|
|3a|1635590|AJCC/UICC N3a Category|
|3b|1633422|AJCC/UICC N3b Category|
|3c|1634735|AJCC/UICC N3c Category|
|4|1635445|AJCC/UICC N4 Category|
|X|1633885|AJCC/UICC NX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `NcategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the absence or presence and extent of regional Lymph Node metastases before treatment during a Cancer Care Spell. [N CATEGORY (FINAL PRETREATMENT)]()

```sql
select distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(
        Record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage',
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed'
    ) as MeasurementDate,
    Record ->> '$.PrimaryPathway.Staging.NCategoryFinalPretreatment' as NcategoryFinalPreTreatment
from omop_staging.cosd_staging_901
where type = 'CO'
  and NcategoryFinalPreTreatment is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20N%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement M Category Integrated Stage
Source column  `MCategoryIntegratedStage`.
Lookup  concepts.


|MCategoryIntegratedStage|measurement_concept_id|notes|
|------|-----|-----|
|0|1635624|AJCC/UICC M0 Category|
|1|1635142|AJCC/UICC M1 Category|
|1a|1635100|AJCC/UICC M1a Category|
|1b|1634463|AJCC/UICC M1b Category|
|1c|1635519|AJCC/UICC M1c Category|
|1d|1634064|AJCC/UICC M1d Category|
|X  |1633547|AJCC/UICC MX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `MCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the absence or presence of distant metastases after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [M CATEGORY (INTEGRATED STAGE)]()

```sql
select 
  distinct
    Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(
        Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage',
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed'
    ) as MeasurementDate,
    Record ->> '$.PrimaryPathway.Staging.MCategoryIntegratedStage' as MCategoryIntegratedStage
from omop_staging.cosd_staging_901
where Type = 'CO'
  and MCategoryIntegratedStage is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20M%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V9 Measurement M Category Final Pre Treatment Stage
Source column  `McategoryFinalPreTreatment`.
Lookup  concepts.


|McategoryFinalPreTreatment|measurement_concept_id|notes|
|------|-----|-----|
|0|1635624|AJCC/UICC M0 Category|
|1|1635142|AJCC/UICC M1 Category|
|1a|1635100|AJCC/UICC M1a Category|
|1b|1634463|AJCC/UICC M1b Category|
|1c|1635519|AJCC/UICC M1c Category|
|1d|1634064|AJCC/UICC M1d Category|
|X  |1633547|AJCC/UICC MX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `McategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the absence or presence of distant metastases before treatment during a Cancer Care Spell. [M CATEGORY (FINAL PRETREATMENT)]()

```sql
select 
  distinct
    record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
    coalesce(
        record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage',
        record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed'
    ) as MeasurementDate,
    record ->> '$.PrimaryPathway.Staging.MCategoryFinalPretreatment' as McategoryFinalPreTreatment
from omop_staging.cosd_staging_901
where type = 'CO'
  and McategoryFinalPreTreatment is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20M%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement Grade of Differentiation (At Diagnosis)
Source column  `GradeOfDifferentiationAtDiagnosis`.
Lookup GradeDifferentiation concepts.


|GradeOfDifferentiationAtDiagnosis|measurement_concept_id|notes|
|------|-----|-----|
|GX||GX grade|
|G1|36768162|Grade 1: Well differentiated|
|G2|36770626|Grade 2: Moderately differentiated|
|G3|36769666|Grade 3: Poorly differentiated|
|G4|36769737|Grade 4: Undifferentiated|

Notes
* [OMOP Grade Differentiation](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&conceptClass=Histopattern&page=1&pageSize=500&query=grade&boosts)
* [NHS - Grade of Differentiation (At Diagnosis)](https://www.datadictionary.nhs.uk/data_elements/grade_of_differentiation__at_diagnosis_.html?hl=grade%2Cdifferentiation)

* `GradeOfDifferentiationAtDiagnosis` The definitive grade of the Tumour at the time of PATIENT DIAGNOSIS. [GRADE OF DIFFERENTIATION (AT DIAGNOSIS)]()

```sql
select
    distinct
        Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber,
        Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
        Record ->> '$.PrimaryPathway.Diagnosis.GradeOfDifferentiationAtDiagnosis.@code' as GradeOfDifferentiationAtDiagnosis,
from omop_staging.cosd_staging_901
where Type = 'CO'
  and GradeOfDifferentiationAtDiagnosis is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20Grade%20of%20Differentiation%20(At%20Diagnosis)%20mapping){: .btn }
### COSD V8 Measurement Tumour Laterality
Source column  `TumourLaterality`.
Lookup TumourLaterality concepts.


|TumourLaterality|measurement_concept_id|notes|
|------|-----|-----|
|L|36770232|Left|
|R|36770058|Right|
|M|36769853|Midline|
|B|36770109|Bilateral|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&conceptClass=Topography&page=1&pageSize=500&query=&boosts)
* [NHS - Tumour Laterality](https://www.datadictionary.nhs.uk/data_elements/tumour_laterality.html?hl=tumour%2Claterality)

* `TumourLaterality` Identifies the side of the body for a Tumour relating to paired organs within a PATIENT. [TUMOUR LATERALITY]()

```sql
with co as (
    select
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.TumourLaterality.@code' as TumourLaterality
    from omop_staging.cosd_staging_81
    where Type = 'CO'
)
select distinct
    NhsNumber,
    coalesce(ClinicalDateCancerDiagnosis, DateOfNonPrimaryCancerDiagnosisClinicallyAgreed) as MeasurementDate,
    TumourLaterality
from co
where TumourLaterality is not null
  and TumourLaterality in ('L','R','M','B');
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20Tumour%20Laterality%20mapping){: .btn }
### COSD V8 Measurement Tumour Height Above Anal Verge
* Constant value set to `3029142`. `Distance from anal verge`

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20Tumour%20Height%20Above%20Anal%20Verge%20mapping){: .btn }
### COSD V8 Measurement TNM Category Integrated Stage
Source column  `TnmStageGroupingIntegrated`.
Lookup TNMCategory concepts.


|TnmStageGroupingIntegrated|measurement_concept_id|notes|
|------|-----|-----|
|1|1635812|IRS-modified TNM stage 1|
|I|1635812|IRS-modified TNM stage 1|
|1a|1635812|IRS-modified TNM stage 1|
|IA|1635812|IRS-modified TNM stage 1|
|1b|1635812|IRS-modified TNM stage 1|
|IB|1635812|IRS-modified TNM stage 1|
|2|1635007|IRS-modified TNM stage 2|
|II|1635007|IRS-modified TNM stage 2|
|2a|1635007|IRS-modified TNM stage 2|
|IIA|1635007|IRS-modified TNM stage 2|
|2b|1635007|IRS-modified TNM stage 2|
|IIB|1635007|IRS-modified TNM stage 2|
|2c|1635007|IRS-modified TNM stage 2|
|IIC|1635007|IRS-modified TNM stage 2|
|3|1633995|IRS-modified TNM stage 3|
|III|1633995|IRS-modified TNM stage 3|
|3a|1633995|IRS-modified TNM stage 3|
|IIIA|1633995|IRS-modified TNM stage 3|
|3b|1633995|IRS-modified TNM stage 3|
|IIIB|1633995|IRS-modified TNM stage 3|
|3c|1633995|IRS-modified TNM stage 3|
|IIIC|1633995|IRS-modified TNM stage 3|
|4|1634737|IRS-modified TNM stage 4|
|IV|1634737|IRS-modified TNM stage 4|
|4a|1634737|IRS-modified TNM stage 4|
|IVA|1634737|IRS-modified TNM stage 4|
|4b|1634737|IRS-modified TNM stage 4|
|IVB|1634737|IRS-modified TNM stage 4|
|4c|1634737|IRS-modified TNM stage 4|
|IVC|1634737|IRS-modified TNM stage 4|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `TnmStageGroupingIntegrated` Is the code, using a TNM CODING EDITION, which classifies the combination of Tumour, node and metastases into stage groupings after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [TNM STAGE GROUPING (INTEGRATED)]()

```sql
with co as (
    select
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTNMStageGrouping' as TnmStageGroupingIntegrated,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTNMStageGroupingDate' as StageDateIntegratedStage
    from omop_staging.cosd_staging_81
    where Type = 'CO'
)
select distinct
    NhsNumber,
    coalesce(StageDateIntegratedStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
    TnmStageGroupingIntegrated
from co
where TnmStageGroupingIntegrated is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20TNM%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement TNM Category Final Pre Treatment Stage
Source column  `TnmStageGroupingFinalPretreatment`.
Lookup TNMCategory concepts.


|TnmStageGroupingFinalPretreatment|measurement_concept_id|notes|
|------|-----|-----|
|1|1635812|IRS-modified TNM stage 1|
|I|1635812|IRS-modified TNM stage 1|
|1a|1635812|IRS-modified TNM stage 1|
|IA|1635812|IRS-modified TNM stage 1|
|1b|1635812|IRS-modified TNM stage 1|
|IB|1635812|IRS-modified TNM stage 1|
|2|1635007|IRS-modified TNM stage 2|
|II|1635007|IRS-modified TNM stage 2|
|2a|1635007|IRS-modified TNM stage 2|
|IIA|1635007|IRS-modified TNM stage 2|
|2b|1635007|IRS-modified TNM stage 2|
|IIB|1635007|IRS-modified TNM stage 2|
|2c|1635007|IRS-modified TNM stage 2|
|IIC|1635007|IRS-modified TNM stage 2|
|3|1633995|IRS-modified TNM stage 3|
|III|1633995|IRS-modified TNM stage 3|
|3a|1633995|IRS-modified TNM stage 3|
|IIIA|1633995|IRS-modified TNM stage 3|
|3b|1633995|IRS-modified TNM stage 3|
|IIIB|1633995|IRS-modified TNM stage 3|
|3c|1633995|IRS-modified TNM stage 3|
|IIIC|1633995|IRS-modified TNM stage 3|
|4|1634737|IRS-modified TNM stage 4|
|IV|1634737|IRS-modified TNM stage 4|
|4a|1634737|IRS-modified TNM stage 4|
|IVA|1634737|IRS-modified TNM stage 4|
|4b|1634737|IRS-modified TNM stage 4|
|IVB|1634737|IRS-modified TNM stage 4|
|4c|1634737|IRS-modified TNM stage 4|
|IVC|1634737|IRS-modified TNM stage 4|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `TnmStageGroupingFinalPretreatment` Is the code, using a TNM CODING EDITION, which classifies the combination of Tumour, node and metastases into stage groupings before treatment during a Cancer Care Spell. [TNM STAGE GROUPING (FINAL PRETREATMENT)]()

```sql
with co as (
    select
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTNMStageGrouping' as TnmStageGroupingFinalPretreatment,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTNMStageGroupingDate' as StageDateFinalPretreatmentStage
    from omop_staging.cosd_staging_81
    where Type = 'CO'
)
select distinct
    NhsNumber,
    coalesce(StageDateFinalPretreatmentStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
    TnmStageGroupingFinalPretreatment
from co
where TnmStageGroupingFinalPretreatment is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20TNM%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement T Category Integrated Stage
Source column  `TCategoryIntegratedStage`.
Lookup TCategory concepts.


|TCategoryIntegratedStage|measurement_concept_id|notes|
|------|-----|-----|
|0|1634213|AJCC/UICC T0 Category|
|1|1635564|AJCC/UICC T1 Category|
|1a|1633880|AJCC/UICC T1a Category|
|1b|1633921|AJCC/UICC T1b Category|
|1c|1633529|AJCC/UICC T1c Category|
|1d|1634100|AJCC/UICC T1d Category|
|2|1635562|AJCC/UICC T2 Category|
|2a|1635327|AJCC/UICC T2a Category|
|2b|1633593|AJCC/UICC T2b Category|
|2c|1635270|AJCC/UICC T2c Category|
|2d|1633678|AJCC/UICC T2d Category|
|3|1634376|AJCC/UICC T3 Category|
|3a|1633771|AJCC/UICC T3a Category|
|3b|1634980|AJCC/UICC T3b Category|
|3c|1633360|AJCC/UICC T3c Category|
|3d|1635625|AJCC/UICC T3d Category|
|3e|1634730|AJCC/UICC T3e Category|
|4|1634654|AJCC/UICC T4 Category|
|4a|1635222|AJCC/UICC T4a Category|
|4b|1634436|AJCC/UICC T4b Category|
|4c|1635526|AJCC/UICC T4c Category|
|4d|1633909|AJCC/UICC T4d Category|
|4e|1634193|AJCC/UICC T4e Category|
|X|1635682|AJCC/UICC TX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `TCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the size and extent of the primary Tumour after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [T CATEGORY (INTEGRATED STAGE)]()

```sql
with co as (
    select
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTCategory' as TCategoryIntegratedStage,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTNMStageGroupingDate' as StageDateIntegratedStage
    from omop_staging.cosd_staging_81
    where Type = 'CO'
)
select distinct
    NhsNumber,
    coalesce(StageDateIntegratedStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
    TCategoryIntegratedStage
from co
where TCategoryIntegratedStage is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20T%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement T Category Final Pre Treatment Stage
Source column  `TcategoryFinalPreTreatment`.
Lookup TCategory concepts.


|TcategoryFinalPreTreatment|measurement_concept_id|notes|
|------|-----|-----|
|0|1634213|AJCC/UICC T0 Category|
|1|1635564|AJCC/UICC T1 Category|
|1a|1633880|AJCC/UICC T1a Category|
|1b|1633921|AJCC/UICC T1b Category|
|1c|1633529|AJCC/UICC T1c Category|
|1d|1634100|AJCC/UICC T1d Category|
|2|1635562|AJCC/UICC T2 Category|
|2a|1635327|AJCC/UICC T2a Category|
|2b|1633593|AJCC/UICC T2b Category|
|2c|1635270|AJCC/UICC T2c Category|
|2d|1633678|AJCC/UICC T2d Category|
|3|1634376|AJCC/UICC T3 Category|
|3a|1633771|AJCC/UICC T3a Category|
|3b|1634980|AJCC/UICC T3b Category|
|3c|1633360|AJCC/UICC T3c Category|
|3d|1635625|AJCC/UICC T3d Category|
|3e|1634730|AJCC/UICC T3e Category|
|4|1634654|AJCC/UICC T4 Category|
|4a|1635222|AJCC/UICC T4a Category|
|4b|1634436|AJCC/UICC T4b Category|
|4c|1635526|AJCC/UICC T4c Category|
|4d|1633909|AJCC/UICC T4d Category|
|4e|1634193|AJCC/UICC T4e Category|
|X|1635682|AJCC/UICC TX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `TcategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the size and extent of the primary Tumour before treatment during a Cancer Care Spell. [T CATEGORY (FINAL PRETREATMENT)]()

```sql
with co as (
    select
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTCategory' as TcategoryFinalPreTreatment,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTNMStageGroupingDate' as StageDateFinalPretreatmentStage
    from omop_staging.cosd_staging_81
    where Type = 'CO'
)
select distinct
    NhsNumber,
    coalesce(StageDateFinalPretreatmentStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
    TcategoryFinalPreTreatment
from co
where TcategoryFinalPreTreatment is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20T%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement Synchronous Tumour Indicator
Source column  `SynchronousTumourIndicator`.
Lookup SynchronousTumour concepts.


|SynchronousTumourIndicator|measurement_concept_id|notes|
|------|-----|-----|
|01|36768217|Cecum|
|02|36770601|Appendix|
|03|36768852|Ascending Colon|
|04|36768109|Hepatic Flexure|
|05|36770627|Transverse Colon|
|06|36769645|Splenic Flexure|
|07|36769819|Descending Colon|
|08|36770395|Sigmoid Colon|
|09|36768690|Rectosigmoid|
|10|36769244|Rectum|

Notes
* [OMOP Cancer Modifier Measurements](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&standardConcept=Standard&page=1&pageSize=500&query=&boosts)
* [NHS - Synchronous Tumour Colon location (at Diagnosis)](https://www.datadictionary.nhs.uk/data_elements/synchronous_tumour_colon_location__at_diagnosis_.html?hl=synchronous%2Ctumour%2Ccolon%2Clocation%2Cdiagnosis)

* `SynchronousTumourIndicator` An indication of whether there is a presence of synchronous tumours at a tumour site during a Cancer Care Spell. [SYNCHRONOUS TUMOUR INDICATOR]()

```sql
with co as (
    select
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.ColorectalDiagnosis.SynchronousTumourColonLocation.@code' as SynchronousTumourIndicator
    from omop_staging.cosd_staging_81
    where Type = 'CO'
)
select distinct
    NhsNumber,
    ClinicalDateCancerDiagnosis,
    SynchronousTumourIndicator
from co
where SynchronousTumourIndicator is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20Synchronous%20Tumour%20Indicator%20mapping){: .btn }
### COSD V8 Measurement Primary Pathway Metastasis
Source column  `MetastaticSite`.
Lookup MetastasisSite concepts.


|MetastaticSite|measurement_concept_id|notes|
|------|-----|-----|
|02|36768862|Metastasis to brain|
|03|36770544|Metastasis to liver|
|04|36770283|Metastasis to lung|
|07|36769180|Metastasis to the Unknown Site|
|08|35225673|Metastasis to skin|
|09|36769243|Distant spread to lymph node|
|10|36769301|Metastasis to bone|
|11|35226074|Metastasis to bone marrow|
|12|36769269|Regional spread to lymph node|
|98|36769180|Metastasis|
|99|36769180|Metastasis|

Notes
* [OMOP Metastasis](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=metastasis&boosts)
* [NHS - Metastasis](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html?hl=metastatic%2Csite%2Cdiagnosis)

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)]()

```sql
with co as (
select 
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
    Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
    unnest(
      [
        [
          Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.MetastaticSite.@code'
        ], 
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.MetastaticSite[*].@code'
      ], recursive := true
    ) as MetastaticSite
from omop_staging.cosd_staging_81
where Type = 'CO'
)
select distinct
    NhsNumber,
    ClinicalDateCancerDiagnosis,
    MetastaticSite
from co
where MetastaticSite is not null
  and MetastaticSite != 97;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20Primary%20Pathway%20Metastasis%20mapping){: .btn }
### COSD V8 Measurement Non Primary Pathway Metastasis
Source column  `MetastaticSite`.
Lookup MetastasisSite concepts.


|MetastaticSite|measurement_concept_id|notes|
|------|-----|-----|
|02|36768862|Metastasis to brain|
|03|36770544|Metastasis to liver|
|04|36770283|Metastasis to lung|
|07|36769180|Metastasis to the Unknown Site|
|08|35225673|Metastasis to skin|
|09|36769243|Distant spread to lymph node|
|10|36769301|Metastasis to bone|
|11|35226074|Metastasis to bone marrow|
|12|36769269|Regional spread to lymph node|
|98|36769180|Metastasis|
|99|36769180|Metastasis|

Notes
* [OMOP Metastasis](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=metastasis&boosts)
* [NHS - Metastasis](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html?hl=metastatic%2Csite%2Cdiagnosis)

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)]()

```sql
with co as (
    select distinct
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
        Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
        unnest(
            [
                [ Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreNonPrimaryCancerPathwayRoute.MetastaticSite.@code' ],
                Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreNonPrimaryCancerPathwayRoute.MetastaticSite[*].@code'
            ],
            recursive := true
        ) as MetastaticSite
    from omop_staging.cosd_staging_81
    where type = 'CO'
)
select distinct
    NhsNumber,
    DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
    MetastaticSite
from co
where MetastaticSite is not null
  and MetastaticSite != '97';
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20Non%20Primary%20Pathway%20Metastasis%20mapping){: .btn }
### COSD V8 Measurement N Category Integrated Stage
Source column  `NCategoryIntegratedStage`.
Lookup NCategory concepts.


|NCategoryIntegratedStage|measurement_concept_id|notes|
|------|-----|-----|
|0|1633440|AJCC/UICC N0 Category|
|0a|1633621|AJCC/UICC N0a Category|
|0b|1635244|AJCC/UICC N0b Category|
|1|1634434|AJCC/UICC N1 Category|
|1a|1633735|AJCC/UICC N1a Category|
|1b|1635130|AJCC/UICC N1b Category|
|1c|1634620|AJCC/UICC N1c Category|
|2|1634119|AJCC/UICC N2 Category|
|2a|1635644|AJCC/UICC N2a Category|
|2b|1634134|AJCC/UICC N2b Category|
|2c|1634080|AJCC/UICC N2c Category|
|3|1635320|AJCC/UICC N3 Category|
|3a|1635590|AJCC/UICC N3a Category|
|3b|1633422|AJCC/UICC N3b Category|
|3c|1634735|AJCC/UICC N3c Category|
|4|1635445|AJCC/UICC N4 Category|
|X|1633885|AJCC/UICC NX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `NCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the absence or presence and extent of regional Lymph Node metastases after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [N CATEGORY (INTEGRATED STAGE)]()

```sql
with CO as (
	select 
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageNCategory' as NCategoryIntegratedStage,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTNMStageGroupingDate' as StageDateIntegratedStage
	from omop_staging.cosd_staging_81
	where Type = 'CO'
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
	NCategoryIntegratedStage
from CO
where NCategoryIntegratedStage is not null;

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20N%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement N Category Final Pre Treatment Stage
Source column  `NcategoryFinalPreTreatment`.
Lookup NCategory concepts.


|NcategoryFinalPreTreatment|measurement_concept_id|notes|
|------|-----|-----|
|0|1633440|AJCC/UICC N0 Category|
|0a|1633621|AJCC/UICC N0a Category|
|0b|1635244|AJCC/UICC N0b Category|
|1|1634434|AJCC/UICC N1 Category|
|1a|1633735|AJCC/UICC N1a Category|
|1b|1635130|AJCC/UICC N1b Category|
|1c|1634620|AJCC/UICC N1c Category|
|2|1634119|AJCC/UICC N2 Category|
|2a|1635644|AJCC/UICC N2a Category|
|2b|1634134|AJCC/UICC N2b Category|
|2c|1634080|AJCC/UICC N2c Category|
|3|1635320|AJCC/UICC N3 Category|
|3a|1635590|AJCC/UICC N3a Category|
|3b|1633422|AJCC/UICC N3b Category|
|3c|1634735|AJCC/UICC N3c Category|
|4|1635445|AJCC/UICC N4 Category|
|X|1633885|AJCC/UICC NX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `NcategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the absence or presence and extent of regional Lymph Node metastases before treatment during a Cancer Care Spell. [N CATEGORY (FINAL PRETREATMENT)]()

```sql
with CO as (
	select 
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentNCategory' as NcategoryFinalPreTreatment,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTNMStageGroupingDate' as StageDateFinalPretreatmentStage
	from omop_staging.cosd_staging_81
	where Type = 'CO'
)
select distinct
	NhsNumber,
	coalesce(StageDateFinalPretreatmentStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
	NcategoryFinalPreTreatment
from CO
where NcategoryFinalPreTreatment is not null;

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20N%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement M Category Integrated Stage
Source column  `MCategoryIntegratedStage`.
Lookup  concepts.


|MCategoryIntegratedStage|measurement_concept_id|notes|
|------|-----|-----|
|0|1635624|AJCC/UICC M0 Category|
|1|1635142|AJCC/UICC M1 Category|
|1a|1635100|AJCC/UICC M1a Category|
|1b|1634463|AJCC/UICC M1b Category|
|1c|1635519|AJCC/UICC M1c Category|
|1d|1634064|AJCC/UICC M1d Category|
|X  |1633547|AJCC/UICC MX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `MCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the absence or presence of distant metastases after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [M CATEGORY (INTEGRATED STAGE)]()

```sql
with CO as (
	select 
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageMCategory' as MCategoryIntegratedStage,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTNMStageGroupingDate' as StageDateIntegratedStage
	from omop_staging.cosd_staging_81
	where Type = 'CO'
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
	MCategoryIntegratedStage
from CO
where MCategoryIntegratedStage is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20M%20Category%20Integrated%20Stage%20mapping){: .btn }
### COSD V8 Measurement M Category Final Pre Treatment Stage
Source column  `McategoryFinalPreTreatment`.
Lookup  concepts.


|McategoryFinalPreTreatment|measurement_concept_id|notes|
|------|-----|-----|
|0|1635624|AJCC/UICC M0 Category|
|1|1635142|AJCC/UICC M1 Category|
|1a|1635100|AJCC/UICC M1a Category|
|1b|1634463|AJCC/UICC M1b Category|
|1c|1635519|AJCC/UICC M1c Category|
|1d|1634064|AJCC/UICC M1d Category|
|X  |1633547|AJCC/UICC MX Category|

Notes
* [OMOP Laterality](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&page=1&pageSize=500&query=tnm&boosts)

* `McategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the absence or presence of distant metastases before treatment during a Cancer Care Spell. [M CATEGORY (FINAL PRETREATMENT)]()

```sql
with CO as (
	select 
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentMCategory' as McategoryFinalPreTreatment,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTNMStageGroupingDate' as StageDateFinalPretreatmentStage
	from omop_staging.cosd_staging_81
	where Type = 'CO'
)
select distinct
	NhsNumber,
	coalesce(StageDateFinalPretreatmentStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
	McategoryFinalPreTreatment
from CO
where McategoryFinalPreTreatment is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20M%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V8 Measurement Grade of Differentiation (At Diagnosis)
Source column  `GradeOfDifferentiationAtDiagnosis`.
Lookup GradeDifferentiation concepts.


|GradeOfDifferentiationAtDiagnosis|measurement_concept_id|notes|
|------|-----|-----|
|GX||GX grade|
|G1|36768162|Grade 1: Well differentiated|
|G2|36770626|Grade 2: Moderately differentiated|
|G3|36769666|Grade 3: Poorly differentiated|
|G4|36769737|Grade 4: Undifferentiated|

Notes
* [OMOP Grade Differentiation](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&conceptClass=Histopattern&page=1&pageSize=500&query=grade&boosts)
* [NHS - Grade of Differentiation (At Diagnosis)](https://www.datadictionary.nhs.uk/data_elements/grade_of_differentiation__at_diagnosis_.html?hl=grade%2Cdifferentiation)

* `GradeOfDifferentiationAtDiagnosis` The definitive grade of the Tumour at the time of PATIENT DIAGNOSIS. [GRADE OF DIFFERENTIATION (AT DIAGNOSIS)]()

```sql
with CO as (
	select 
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.DateOfNonPrimaryCancerDiagnosisClinicallyAgreed' as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.DiagnosisGradeOfDifferentiation.@code' as GradeOfDifferentiationAtDiagnosis
	from omop_staging.cosd_staging_81
	where Type = 'CO'
)
select distinct
	NhsNumber,
	coalesce(ClinicalDateCancerDiagnosis, DateOfNonPrimaryCancerDiagnosisClinicallyAgreed) as MeasurementDate,
	GradeOfDifferentiationAtDiagnosis
from CO
where GradeOfDifferentiationAtDiagnosis is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20Grade%20of%20Differentiation%20(At%20Diagnosis)%20mapping){: .btn }
