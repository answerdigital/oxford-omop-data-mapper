---
layout: default
title: measurement_concept_id
parent: Measurement
grand_parent: Transformation Documentation
has_toc: false
---
# measurement_concept_id
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

* `TumourLaterality` Identifies the side of the body for a Tumour relating to paired organs within a PATIENT. [TUMOUR LATERALITY](https://www.datadictionary.nhs.uk/data_elements/tumour_laterality.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/TumourLaterality/@code)[1]', 'varchar(max)') as TumourLaterality
	from CosdRecords
)
select distinct
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	TumourLaterality
from CO
where TumourLaterality is not null
and TumourLaterality in ('L','R','M','B');
	
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

* `TnmStageGroupingIntegrated` Is the code, using a TNM CODING EDITION, which classifies the combination of Tumour, node and metastases into stage groupings after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [TNM STAGE GROUPING (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping__integrated_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/TnmStageGroupingIntegrated)[1]', 'varchar(max)') as TnmStageGroupingIntegrated,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, DateOfPrimaryDiagnosisClinicallyAgreed)  as MeasurementDate,
	TnmStageGroupingIntegrated
from CO
where TnmStageGroupingIntegrated is not null;
	
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

* `TnmStageGroupingFinalPretreatment` Is the code, using a TNM CODING EDITION, which classifies the combination of Tumour, node and metastases into stage groupings before treatment during a Cancer Care Spell. [TNM STAGE GROUPING (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping__final_pretreatment_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/TnmStageGroupingFinalPretreatment)[1]', 'varchar(max)') as TnmStageGroupingFinalPretreatment,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateFinalPretreatmentStage, DateOfPrimaryDiagnosisClinicallyAgreed) as MeasurementDate,
	TnmStageGroupingFinalPretreatment
from CO
where TnmStageGroupingFinalPretreatment is not null;
	
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

* `TCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the size and extent of the primary Tumour after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [T CATEGORY (INTEGRATED STAGE)](https://www.datadictionary.nhs.uk/data_elements/t_category__integrated_stage_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/TCategoryIntegratedStage)[1]', 'varchar(max)') as TCategoryIntegratedStage,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, DateOfPrimaryDiagnosisClinicallyAgreed)  as MeasurementDate,
	TCategoryIntegratedStage
from CO
where TCategoryIntegratedStage is not null;
	
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

* `TcategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the size and extent of the primary Tumour before treatment during a Cancer Care Spell. [T CATEGORY (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/t_category__final_pretreatment_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/TCategoryFinalPretreatment)[1]', 'varchar(max)') as TcategoryFinalPreTreatment,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateFinalPretreatmentStage, DateOfPrimaryDiagnosisClinicallyAgreed) as MeasurementDate,
	TcategoryFinalPreTreatment
from CO
where TcategoryFinalPreTreatment is not null;
	
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

* `SynchronousTumourIndicator` An indication of whether there is a presence of synchronous tumours at a tumour site during a Cancer Care Spell. [SYNCHRONOUS TUMOUR INDICATOR](https://www.datadictionary.nhs.uk/data_elements/synchronous_tumour_indicator.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/DiagnosisColorectal/SynchronousTumourIndicator/@code)[1]', 'varchar(max)') as SynchronousTumourIndicator
	from CosdRecords
)
select distinct
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	SynchronousTumourIndicator
from CO
where SynchronousTumourIndicator is not null;
	
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
|07|35226309|Metastasis to the Unknown Site|
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

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			T.p.value('.', 'varchar(max)') as MetastaticSite
	from CosdRecords
	cross apply Node.nodes('ColorectalRecord/PrimaryPathway/Diagnosis/MetastaticTypeAndSiteDiagnosis/MetastaticSite/@code') as T(p)
)
select distinct
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	MetastaticSite
from CO
where MetastaticSite is not null
and MetastaticSite != 97
	
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
|07|35226309|Metastasis to the Unknown Site|
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

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/NonPrimaryPathway/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
			T.p.value('.', 'varchar(max)') as MetastaticSite
	from CosdRecords
	cross apply Node.nodes('ColorectalRecord/NonPrimaryPathway/Recurrence/MetastaticTypeAndSiteRecurrence/MetastaticSite/@code') as T(p)
)
select distinct
	NhsNumber,
	DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
	MetastaticSite
from CO
where MetastaticSite is not null
and MetastaticSite != 97
	
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
|07|35226309|Metastasis to the Unknown Site|
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

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/NonPrimaryPathway/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
			T.p.value('.', 'varchar(max)') as MetastaticSite
	from CosdRecords
	cross apply Node.nodes('ColorectalRecord/NonPrimaryPathway/Progression/MetastaticTypeAndSiteProgression/MetastaticSite/@code') as T(p)
)
select distinct
	NhsNumber,
	DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
	MetastaticSite
from CO
where MetastaticSite is not null
and MetastaticSite != 97
	
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

* `NCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the absence or presence and extent of regional Lymph Node metastases after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [N CATEGORY (INTEGRATED STAGE)](https://www.datadictionary.nhs.uk/data_elements/n_category__integrated_stage_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/NCategoryIntegratedStage)[1]', 'varchar(max)') as NCategoryIntegratedStage,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, DateOfPrimaryDiagnosisClinicallyAgreed)  as MeasurementDate,
	NCategoryIntegratedStage
from CO
where NCategoryIntegratedStage is not null;
	
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

* `NcategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the absence or presence and extent of regional Lymph Node metastases before treatment during a Cancer Care Spell. [N CATEGORY (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/n_category__final_pretreatment_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/NCategoryFinalPretreatment)[1]', 'varchar(max)') as NcategoryFinalPreTreatment,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateFinalPretreatmentStage, DateOfPrimaryDiagnosisClinicallyAgreed) as MeasurementDate,
	NcategoryFinalPreTreatment
from CO
where NcategoryFinalPreTreatment is not null;
	
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

* `MCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the absence or presence of distant metastases after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [M CATEGORY (INTEGRATED STAGE)](https://www.datadictionary.nhs.uk/data_elements/m_category__integrated_stage_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/MCategoryIntegratedStage)[1]', 'varchar(max)') as MCategoryIntegratedStage,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, DateOfPrimaryDiagnosisClinicallyAgreed)  as MeasurementDate,
	MCategoryIntegratedStage
from CO
where MCategoryIntegratedStage is not null;
	
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

* `McategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the absence or presence of distant metastases before treatment during a Cancer Care Spell. [M CATEGORY (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/m_category__final_pretreatment_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/MCategoryFinalPretreatment)[1]', 'varchar(max)') as McategoryFinalPreTreatment,
			Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateFinalPretreatmentStage, DateOfPrimaryDiagnosisClinicallyAgreed) as MeasurementDate,
	McategoryFinalPreTreatment
from CO
where McategoryFinalPreTreatment is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V9%20Measurement%20M%20Category%20Final%20Pre%20Treatment%20Stage%20mapping){: .btn }
### COSD V9 Measurement Grade of Differentiation (At Diagnosis)
Source column  `GradeOfDifferentiationAtDiagnosis`.
Lookup GradeDifferentiation concepts.


|GradeOfDifferentiationAtDiagnosis|measurement_concept_id|notes|
|------|-----|-----|
|GX|4054711|GX grade|
|G1|36768162|Grade 1: Well differentiated|
|G2|36770626|Grade 2: Moderately differentiated|
|G3|36769666|Grade 3: Poorly differentiated|
|G4|36769737|Grade 4: Undifferentiated|

Notes
* [OMOP Grade Differentiation](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&conceptClass=Histopattern&page=1&pageSize=500&query=grade&boosts)
* [NHS - Grade of Differentiation (At Diagnosis)](https://www.datadictionary.nhs.uk/data_elements/grade_of_differentiation__at_diagnosis_.html?hl=grade%2Cdifferentiation)

* `GradeOfDifferentiationAtDiagnosis` The definitive grade of the Tumour at the time of PATIENT DIAGNOSIS. [GRADE OF DIFFERENTIATION (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/grade_of_differentiation__at_diagnosis_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1' AS COSD901),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('.') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD901:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v9-0-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
			Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/GradeOfDifferentiationAtDiagnosis/@code)[1]', 'varchar(max)') as GradeOfDifferentiationAtDiagnosis
	from CosdRecords
)
select distinct
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	GradeOfDifferentiationAtDiagnosis
from CO
where GradeOfDifferentiationAtDiagnosis is not null;
	
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

* `TumourLaterality` Identifies the side of the body for a Tumour relating to paired organs within a PATIENT. [TUMOUR LATERALITY](https://www.datadictionary.nhs.uk/data_elements/tumour_laterality.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)')  as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/TumourLaterality/@code)[1]', 'varchar(max)') as TumourLaterality
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(ClinicalDateCancerDiagnosis, DateOfNonPrimaryCancerDiagnosisClinicallyAgreed) as MeasurementDate,
	TumourLaterality
from CO
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

* `TnmStageGroupingIntegrated` Is the code, using a TNM CODING EDITION, which classifies the combination of Tumour, node and metastases into stage groupings after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [TNM STAGE GROUPING (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping__integrated_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGrouping)[1]', 'varchar(max)') as TnmStageGroupingIntegrated,
			Node.value('(ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as StageDateIntegratedStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
	TnmStageGroupingIntegrated
from CO
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

* `TnmStageGroupingFinalPretreatment` Is the code, using a TNM CODING EDITION, which classifies the combination of Tumour, node and metastases into stage groupings before treatment during a Cancer Care Spell. [TNM STAGE GROUPING (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping__final_pretreatment_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGrouping)[1]', 'varchar(max)') as TnmStageGroupingFinalPretreatment,
			Node.value('(ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateFinalPretreatmentStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
	TnmStageGroupingFinalPretreatment
from CO
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

* `TCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the size and extent of the primary Tumour after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [T CATEGORY (INTEGRATED STAGE)](https://www.datadictionary.nhs.uk/data_elements/t_category__integrated_stage_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreStaging/IntegratedStageTCategory)[1]', 'varchar(max)') as TCategoryIntegratedStage,
			Node.value('(ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as StageDateIntegratedStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
	TCategoryIntegratedStage
from CO
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

* `TcategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the size and extent of the primary Tumour before treatment during a Cancer Care Spell. [T CATEGORY (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/t_category__final_pretreatment_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTCategory)[1]', 'varchar(max)') as TcategoryFinalPreTreatment,
			Node.value('(ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateFinalPretreatmentStage, ClinicalDateCancerDiagnosis) as MeasurementDate,
	TcategoryFinalPreTreatment
from CO
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

* `SynchronousTumourIndicator` An indication of whether there is a presence of synchronous tumours at a tumour site during a Cancer Care Spell. [SYNCHRONOUS TUMOUR INDICATOR](https://www.datadictionary.nhs.uk/data_elements/synchronous_tumour_indicator.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreDiagnosis/ColorectalDiagnosis/SynchronousTumourColonLocation/@code)[1]', 'varchar(max)') as SynchronousTumourIndicator
	from CosdRecords
)
select distinct
	NhsNumber,
	ClinicalDateCancerDiagnosis,
	SynchronousTumourIndicator
from CO
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
|07|35226309|Metastasis to the Unknown Site|
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

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			T.p.value('.', 'varchar(max)') as MetastaticSite
	from CosdRecords
	cross apply Node.nodes('ColorectalCore/ColorectalCoreDiagnosis/MetastaticSite/@code') as T(p)
)
select distinct
	NhsNumber,
	ClinicalDateCancerDiagnosis,
	MetastaticSite
from CO
where MetastaticSite is not null
and MetastaticSite != 97
	
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
|07|35226309|Metastasis to the Unknown Site|
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

* `MetastaticSite` Is the site of the metastatic disease at PATIENT DIAGNOSIS [METASTATIC SITE (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/metastatic_site__at_diagnosis_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)')  as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
			T.p.value('.', 'varchar(max)') as MetastaticSite
	from CosdRecords
	cross apply Node.nodes('ColorectalCore/ColorectalCoreNonPrimaryCancerPathwayRoute/MetastaticSite/@code') as T(p)
)
select distinct
	NhsNumber,
	DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
	MetastaticSite
from CO
where MetastaticSite is not null
and MetastaticSite != 97
	
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

* `NCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the absence or presence and extent of regional Lymph Node metastases after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [N CATEGORY (INTEGRATED STAGE)](https://www.datadictionary.nhs.uk/data_elements/n_category__integrated_stage_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreStaging/IntegratedStageNCategory)[1]', 'varchar(max)') as NCategoryIntegratedStage,
			Node.value('(ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as StageDateIntegratedStage
	from CosdRecords
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

* `NcategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the absence or presence and extent of regional Lymph Node metastases before treatment during a Cancer Care Spell. [N CATEGORY (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/n_category__final_pretreatment_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentNCategory)[1]', 'varchar(max)') as NcategoryFinalPreTreatment,
			Node.value('(ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage
	from CosdRecords
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

* `MCategoryIntegratedStage` Is the code, using a TNM CODING EDITION, which classifies the absence or presence of distant metastases after treatment and/or after all available evidence has been collected during a Cancer Care Spell. [M CATEGORY (INTEGRATED STAGE)](https://www.datadictionary.nhs.uk/data_elements/m_category__integrated_stage_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreStaging/IntegratedStageMCategory)[1]', 'varchar(max)') as MCategoryIntegratedStage,
			Node.value('(ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as StageDateIntegratedStage
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(StageDateIntegratedStage, ClinicalDateCancerDiagnosis)  as MeasurementDate,
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

* `McategoryFinalPreTreatment` Is the code, using a TNM CODING EDITION, which classifies the absence or presence of distant metastases before treatment during a Cancer Care Spell. [M CATEGORY (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/m_category__final_pretreatment_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentMCategory)[1]', 'varchar(max)') as McategoryFinalPreTreatment,
			Node.value('(ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage
	from CosdRecords
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
|GX|4054711|GX grade|
|G1|36768162|Grade 1: Well differentiated|
|G2|36770626|Grade 2: Moderately differentiated|
|G3|36769666|Grade 3: Poorly differentiated|
|G4|36769737|Grade 4: Undifferentiated|

Notes
* [OMOP Grade Differentiation](https://athena.ohdsi.org/search-terms/terms?vocabulary=Cancer+Modifier&conceptClass=Histopattern&page=1&pageSize=500&query=grade&boosts)
* [NHS - Grade of Differentiation (At Diagnosis)](https://www.datadictionary.nhs.uk/data_elements/grade_of_differentiation__at_diagnosis_.html?hl=grade%2Cdifferentiation)

* `GradeOfDifferentiationAtDiagnosis` The definitive grade of the Tumour at the time of PATIENT DIAGNOSIS. [GRADE OF DIFFERENTIATION (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/grade_of_differentiation__at_diagnosis_.html)

```sql
;with 
    XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 

    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
			Id,
			Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
			Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)')  as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
			Node.value('(ColorectalCore/ColorectalCoreDiagnosis/DiagnosisGradeOfDifferentiation/@code)[1]', 'varchar(max)') as GradeOfDifferentiationAtDiagnosis
	from CosdRecords
)
select distinct
	NhsNumber,
	coalesce(ClinicalDateCancerDiagnosis, DateOfNonPrimaryCancerDiagnosisClinicallyAgreed) as MeasurementDate,
	GradeOfDifferentiationAtDiagnosis
from CO
where GradeOfDifferentiationAtDiagnosis is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Measurement%20table%20measurement_concept_id%20field%20COSD%20V8%20Measurement%20Grade%20of%20Differentiation%20(At%20Diagnosis)%20mapping){: .btn }
