---
layout: default
title: condition_source_concept_id
parent: ConditionOccurrence
grand_parent: Transformation Documentation
has_toc: false
---
# condition_source_concept_id
### SUS Outpatient Condition Occurrence
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
		inner join [omop_staging].[sus_OP] op
			on d.MessageId = op.MessageId
	where op.NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20SUS%20Outpatient%20Condition%20Occurrence%20mapping){: .btn }
### SUS Inpatient Condition Occurrence
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
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### SUS Inpatient Condition Occurrence
Source column  `AccidentAndEmergencyDiagnosis`.
Accident and Emergency Diagnosis to SNOMED


|AccidentAndEmergencyDiagnosis|condition_source_concept_id|notes|
|------|-----|-----|
|01 02|428088000|Laceration of Head|
|01 03|35933005|Laceration of Face|
|01 07|35933005|Laceration of Mouth, Jaw, Teeth|
|01 09|283364000|Laceration of Neck|
|01 10|283367007|Laceration of Shoulder|
|01 12|283369005|Laceration of Upper Arm|
|01 13|283370006|Laceration of Elbow|
|01 14|283371005|Laceration of Forearm|
|01 16|284549007|Laceration of Hand|
|01 17|35933005|Laceration of Digit|
|01 22|35933005|Laceration of Chest|
|01 24|283378004|Laceration of Abdomen|
|01 25|35933005|Laceration of Back/buttocks|
|01 26|35933005|Laceration of Ano/rectal|
|01 30|283385000|Laceration of Thigh|
|01 31|283386004|Laceration of Knee|
|01 32|283387008|Laceration of Lower leg|
|01 34|284551006|Laceration of Foot|
|01 35|284552004|Laceration of Toe|
|02 02|735645009|Contusion of Head|
|02 03|125668004|Contusion of Face|
|02 05|50228009|Contusion of Ear|
|02 06|60897004|Contusion of Nose|
|02 09|8513005|Contusion of Neck|
|02 10|125667009|Contusion of Shoulder|
|02 12|85636003|Contusion of Upper Arm|
|02 13|91613004|Contusion of Elbow|
|02 14|39812007|Contusion of Forearm|
|02 15|48123002|Contusion of Wrist|
|02 16|5662003|Contusion of Hand|
|02 17|125667009|Contusion of Digit|
|02 21|14992004|Contusion of Pelvis|
|02 22|10050004|Contusion of Chest|
|02 24|1873941000000104|Contusion of Abdomen|
|02 25|125667009|Contusion of Back/buttocks|
|02 26|125667009|Contusion of Ano/rectal|
|02 28|44801007|Contusion of Hip|
|02 30|84416003|Contusion of Thigh|
|02 31|22878006|Contusion of Knee|
|02 32|45613006|Contusion of Lower leg|
|02 33|55042009|Contusion of Ankle|
|02 34|74814004|Contusion of Foot|
|02 35|58075000|Contusion of Toe|
|02136|111721009|Contusion of Multiple Site|
|03|19660004|Soft tissue inflammation|
|03 10|19660004|Soft tissue inflammation of Shoulder|
|03 22|19660004|Soft tissue inflammation of Chest|
|03 24|19660004|Soft tissue inflammation of Abdomen|
|03 27|19660004|Soft tissue inflammation of Genitalia|
|03 28|19660004|Soft tissue inflammation of Hip|
|04 01|82271004|Head injury of Brain|
|04 02|82271004|Head injury of Head|
|04 03|82271004|Head injury of Face|
|04 04|82271004|Head injury of Eye|
|04 07|82271004|Head injury of Mouth, Jaw, Teeth|
|05 03|87642003|Dislocation of Face|
|05 12|87642003|Dislocation of Upper Arm|
|05 13|87642003|Dislocation of Elbow|
|05 16|87642003|Dislocation of Hand|
|05 17|87642003|Dislocation of Digit|
|05 19|87642003|Dislocation of Thoracic|
|05 21|87642003|Dislocation of Pelvis|
|05 24|87642003|Dislocation of Abdomen|
|05 31|87642003|Dislocation of Knee|
|05 32|87642003|Dislocation of Lower leg|
|05 34|210366009|Dislocation of Foot|
|05 35|204629008|Dislocation of Toe|
|05110|87642003|Dislocation of Shoulder|
|05113|87642003|Dislocation of Elbow|
|05115|833335001|Dislocation of Wrist|
|05116|87642003|Dislocation of Hand|
|05117|87642003|Dislocation of Digit|
|05118|209054005|Dislocation of Cervical spine|
|05128|87642003|Dislocation of Hip|
|05131|87642003|Dislocation of Knee|
|05133|87642003|Dislocation of Ankle|
|05135|204629008|Dislocation of Toe|
|05202|704013006|Open fracture of Head|
|05203|397181002|Open fracture of Face|
|05206|439987009|Open fracture of Nose|
|05210|397181002|Open fracture of Shoulder|
|05212|18336000|Open fracture of Upper Arm|
|05213|10820261000119101|Open fracture of Elbow|
|05214|91296001|Open fracture of Forearm|
|05216|704013006|Open fracture of Hand|
|05217|397181002|Open fracture of Digit|
|05218|269070003|Open fracture of Cervical spine|
|05221|15474008|Open fracture of Pelvis|
|05222|397181002|Open fracture of Chest|
|05225|397181002|Open fracture of Back/buttocks|
|05230|361118003|Open fracture of Thigh|
|05231|439987009|Open fracture of Knee|
|05232|414942001|Open fracture of Lower leg|
|05233|48187004|Open fracture of Ankle|
|05234|367527001|Open fracture of Foot|
|05235|439987009|Open fracture of Toe|
|05302|704005005|Closed fracture of Head|
|05303|69102005|Closed fracture of Face|
|05306|423125000|Closed fracture of Nose|
|05310|704210003|Closed fracture of Shoulder|
|05312|36991002|Closed fracture of Upper Arm|
|05313|10938001000119101|Closed fracture of Elbow|
|05314|91419009|Closed fracture of Forearm|
|05316|704005005|Closed fracture of Hand|
|05317|423125000|Closed fracture of Digit|
|05318|269062008|Closed fracture of Cervical spine|
|05319|423125000|Closed fracture of Thoracic|
|05320|423125000|Closed fracture of Lumbosacral spine|
|05321|91037003|Closed fracture of Pelvis|
|05322|423125000|Closed fracture of Chest|
|05325|423125000|Closed fracture of Back/buttocks|
|05328|359817006|Closed fracture of Hip|
|05330|359817006|Closed fracture of Thigh|
|05331|423125000|Closed fracture of Knee|
|05332|413876003|Closed fracture of Lower leg|
|05333|42188001|Closed fracture of Ankle|
|05334|342070009|Closed fracture of Foot|
|05335|423125000|Closed fracture of Toe|
|05505|81723002|Amputation of Ear|
|05507|81723002|Amputation of Mouth, Jaw, Teeth|
|05517|81723002|Amputation of Digit|
|06 10|3199001|Sprain of Shoulder|
|06 13|384709000|Sprain of Elbow|
|06 15|70704007|Sprain of Wrist|
|06 16|87778004|Sprain of Hand|
|06 17|384709000|Sprain of Digit|
|06 18|384709000|Sprain of Cervical spine|
|06 19|384709000|Sprain of Thoracic|
|06 28|17883008|Sprain of Hip|
|06 31|54888009|Sprain of Knee|
|06 33|44465007|Sprain of Ankle|
|06 34|49388007|Sprain of Foot|
|06 35|12531000132101|Sprain of Toe|
|07|312847008|Tendon injury|
|07 09|312847008|Tendon injury of Neck|
|07 10|312847008|Tendon injury of Shoulder|
|07 12|312847008|Tendon injury of Upper Arm|
|07 14|312847008|Tendon injury of Forearm|
|07 15|312847008|Tendon injury of Wrist|
|07 16|262971000|Tendon injury of Hand|
|07 17|312847008|Tendon injury of Digit|
|07 18|312847008|Tendon injury of Cervical spine|
|07 20|312847008|Tendon injury of Lumbosacral spine|
|07 30|312847008|Tendon injury of Thigh|
|07 31|312847008|Tendon injury of Knee|
|07 32|312847008|Tendon injury of Lower leg|
|07 33|312847008|Tendon injury of Ankle|
|07 34|312847008|Tendon injury of Foot|
|07 35|312847008|Tendon injury of Toe|
|09|57662003|Vascular injury|
|10|125666000|Burns|
|10 02|125666000|Burns of Head|
|10 03|262582004|Burns of Face|
|10 04|125666000|Burns of Eye|
|10 08|284207003|Burns of Throat|
|10 09|60713008|Burns of Neck|
|10 10|57143002|Burns of Shoulder|
|10 12|14261008|Burns of Upper Arm|
|10 14|80827001|Burns of Forearm|
|10 16|14893008|Burns of Hand|
|10 17|125666000|Burns of Digit|
|10 25|125666000|Burns of Back/buttocks|
|10 26|125666000|Burns of Ano/rectal|
|10 30|6132001|Burns of Thigh|
|10 31|19684007|Burns of Knee|
|10 32|37696000|Burns of Lower leg|
|10 34|11980003|Burns of Foot|
|10 35|88374002|Burns of Toe|
|12|125670008|Foreign body|
|12 05|125670008|Foreign body of Ear|
|12 06|74699008|Foreign body of Nose|
|12 08|125670008|Foreign body of Throat|
|12 17|125670008|Foreign body of Digit|
|12 26|125670008|Foreign body of Ano/rectal|
|12 27|125670008|Foreign body of Genitalia|
|12 36|125670008|Foreign body of Multiple Site|
|14|75478009|Poisoning|
|144|436585|Other, including alcohol|
|14436|436585|Other, including alcohol of Multiple Site|
|15|87970004|Near drowning|
|16|105612003|Visceral injury|
|16 22|105612003|Visceral injury of Chest|
|17|40733004|Infectious Disease|
|171|719951000000109|Notifiable disease|
|172|40733004|Non-notifiable disease|
|17208|40733004|Non-notifiable disease of Throat|
|17234|40733004|Non-notifiable disease of Foot|
|17236|40733004|Non-notifiable disease of Multiple Site|
|18|275393007|Local infection|
|18 23|76844004|Local infection of Breast|
|18 36|76844004|Local infection of Multiple Site|
|19|132797|Septicaemia|
|201|428196007|Myocardial ischaemia & infarction|
|202|441545004|Other non-ischaemia|
|20236|441545004|Other non-ischaemia of Multiple Site|
|21|230690007|Cerebro-vascular condition|
|21 02|230690007|Cerebro-vascular condition of Head|
|22|27550009|Other vascular condition|
|22 19|27550009|Other vascular condition of Thoracic|
|22 24|27550009|Other vascular condition of Abdomen|
|23|57407000|Haematological|
|24|87536007|Central Nervous System|
|241|84757009|Epilepsy|
|242|87536007|Other non-epilepsy|
|24236|87536007|Other non-epilepsy of Multiple Site|
|251|195967001|Bronchial asthma|
|252|50043002|Other non-asthma|
|25222|50043002|Other non-asthma of Chest|
|26|24813008|Gastrointestinal condition|
|26 08|24813008|Gastrointestinal condition of Throat|
|26 24|24813008|Gastrointestinal condition of Abdomen|
|261|74474003|Haemorrhage|
|262|116290004|Acute abdominal pain|
|26324|24813008|Other of Abdomen|
|27|251956004|Urological|
|27 27|251956004|Urological of Genitalia|
|28|1078831000000107|Obstetric|
|28 27|1078831000000107|Obstetric of Genitalia|
|29|1078831000000107|Gynaecological|
|29 21|1078831000000107|Gynaecological of Pelvis|
|29 29|1078831000000107|Gynaecological of Groin|
|30|309048008|Diabetes|
|301|73211009|Diabetic|
|302|309048008|Other non-diabetic|
|31|95320005|Dermatological|
|32|781474001|Allergy|
|33|128234004|Facio-maxillary|
|33 02|128234004|Facio-maxillary of Head|
|33 07|128234004|Facio-maxillary of Mouth, Jaw, Teeth|
|34|232208008|Ear, Nose & Throat|
|34 05|232208008|Ear, Nose & Throat of Ear|
|34 06|232208008|Ear, Nose & Throat of Nose|
|34 08|232208008|Ear, Nose & Throat of Throat|
|35|74732009|Mental disorder|
|36 04|371409005|Ophthalmological of Eye|
|37|162218007|Social problem|
|38|0|Diagnosis not classifiable|
|39|0|Nothing abnormal detected|

Notes
* [ACCIDENT and EMERGENCY CLINICAL CODES](https://v2.datadictionary.nhs.uk/web_site_content/pages/codes/administrative_codes/a_amp_e_diagnosis_tables.asp@shownav=1.html)
* [OMOP Conditions](https://athena.ohdsi.org/search-terms/terms?standardConcept=Standard&vocabulary=SNOMED&invalidReason=Valid&conceptClass=Clinical+Finding&conceptClass=Disorder&page=1&pageSize=15&query=)

* `AccidentAndEmergencyDiagnosis` 
				ACCIDENT AND EMERGENCY DIAGNOSIS is a six character code, comprising:
					Diagnosis Condition	n2
					Sub-Analysis	n1
					ACCIDENT AND EMERGENCY ANATOMICAL AREA	n2
					ACCIDENT AND EMERGENCY ANATOMICAL SIDE
			 [PRIMARY DIAGNOSIS]()

```sql
	select
		distinct
			d.AccidentAndEmergencyDiagnosis,
			ae.GeneratedRecordIdentifier,
			ae.NHSNumber,
			ae.CDSActivityDate
	from omop_staging.sus_AE_diagnosis d
		inner join omop_staging.sus_AE ae
			on d.MessageId = ae.MessageId
	where ae.NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20SUS%20Inpatient%20Condition%20Occurrence%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis
Source column  `CancerDiagnosis`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `CancerDiagnosis` PRIMARY DIAGNOSIS (ICD) is the International Classification of Diseases (ICD) code used to identify the PRIMARY DIAGNOSIS. [PRIMARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 
    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node -- Select the first inner element of the element that is not called Id.
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select 
        Id,
        Node,
        Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as DiagnosisDate,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as NonPrimaryDiagnosisDate,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/MorphologyICDODiagnosis/@code)[1]', 'varchar(max)') as CancerHistology,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/TopographyICDO/@code)[1]', 'varchar(max)') as CancerTopography,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/BasisOfCancerDiagnosis/@code)[1]', 'varchar(max)') as BasisOfDiagnosisCancer,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/PrimaryDiagnosis/@code)[1]', 'varchar(max)') as CancerDiagnosis
	from CosdRecords        
)
select 
	distinct
		NhsNumber,
		coalesce (DiagnosisDate, NonPrimaryDiagnosisDate) as DiagnosisDate,
		BasisOfDiagnosisCancer,
		CancerDiagnosis
from CO
where NhsNumber is not null and
	(
		DiagnosisDate is not null or 
		NonPrimaryDiagnosisDate is not null
	);
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### Cosd V8 Condition Occurrence Primary Diagnosis Histology Topography
Source columns  `CancerHistology`, `CancerTopography`.
Resolve ICD-o-3 codes to OMOP concepts.

* `CancerHistology` MORPHOLOGY (ICD-O CANCER TRANSFORMATION) is the morphology code of the Cancer Transformation using the ICD-O CODE. [MORPHOLOGY (ICD-O CANCER TRANSFORMATION)](https://www.datadictionary.nhs.uk/data_elements/morphology__icd-o_cancer_transformation_.html)

* `CancerTopography` TOPOGRAPHY (ICD-O) is the topographical site of the Tumour using the ICD-O CODE. [TOPOGRAPHY (ICD-O)](https://www.datadictionary.nhs.uk/data_elements/topography__icd-o_.html)

```sql
;with XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD),
    CosdRecords as ( 
    select
            T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
            T.staging.query('*[local-name() != "Id"][1]/*[1]') as Node -- Select the first inner element of the element that is not called Id.
    from omop_staging.cosd_staging
    cross apply content.nodes('COSD:COSD/*') as T(staging)
    where T.staging.exist('Id/@root') = 1
            and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
            and substring (FileName, 15, 2) = 'CO'
), CO as (
	select 
        Id,
        Node,
        Node.value('(ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as DiagnosisDate,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as NonPrimaryDiagnosisDate,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/MorphologyICDODiagnosis/@code)[1]', 'varchar(max)') as CancerHistology,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/TopographyICDO/@code)[1]', 'varchar(max)') as CancerTopography,
        Node.value('(ColorectalCore/ColorectalCoreDiagnosis/BasisOfCancerDiagnosis/@code)[1]', 'varchar(max)') as BasisOfDiagnosisCancer,
        Node.value('(ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/PrimaryDiagnosis/@code)[1]', 'varchar(max)') as CancerDiagnosis
	from CosdRecords        
)
select 
	distinct
		NhsNumber,
		coalesce (DiagnosisDate, NonPrimaryDiagnosisDate) as DiagnosisDate,
		BasisOfDiagnosisCancer,
		CancerHistology,
		CancerTopography
from CO
where NhsNumber is not null and
	(
		DiagnosisDate is not null or 
		NonPrimaryDiagnosisDate is not null
	)
	and (CancerHistology is not null and CancerTopography is not null)
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20Cosd%20V8%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
Source column  `SecondaryDiagnosis`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `SecondaryDiagnosis` SECONDARY DIAGNOSIS (ICD) is the International Classification of Diseases (ICD) code used to identify the secondary PATIENT DIAGNOSIS. [SECONDARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/secondary_diagnosis__icd_.html)

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
		Node,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/DiagnosisAdditionalItems/SecondaryDiagnosisIcd/@code)[1]', 'varchar(max)') as SecondaryDiagnosis
	from CosdRecords
)
select
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	max (SecondaryDiagnosis) as SecondaryDiagnosis
from CO
where DateOfPrimaryDiagnosisClinicallyAgreed is not null
	and SecondaryDiagnosis is not null
group by NhsNumber, DateOfPrimaryDiagnosisClinicallyAgreed;

	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Recurrence
Source column  `NonPrimaryRecurrenceOriginalDiagnosis`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `NonPrimaryRecurrenceOriginalDiagnosis` PRIMARY DIAGNOSIS (ICD ORIGINAL) is the International Classification of Diseases (ICD) code used to identify the original PRIMARY DIAGNOSIS. [PRIMARY DIAGNOSIS (ICD ORIGINAL)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_original_.html)

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
		Node,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/NonPrimaryPathway/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/NonPrimaryPathway/Recurrence/OriginalPrimaryDiagnosisIcd/@code)[1]', 'varchar(max)') as NonPrimaryRecurrenceOriginalDiagnosis
	from CosdRecords
)
select 
	distinct 
        NhsNumber,
        DateOfNonPrimaryCancerDiagnosisClinicallyAgreed,
		NonPrimaryRecurrenceOriginalDiagnosis
from CO
where NonPrimaryRecurrenceOriginalDiagnosis is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Recurrence%20mapping){: .btn }
### COSD V9 Condition Occurrence Progression
Source column  `NonPrimaryProgressionOriginalDiagnosis`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `NonPrimaryProgressionOriginalDiagnosis` CANCER PROGRESSION (ICD ORIGINAL) is the International Classification of Diseases (ICD) code of the original PATIENT DIAGNOSIS of the Cancer Progression. [CANCER PROGRESSION (ICD ORIGINAL)](https://www.datadictionary.nhs.uk/data_elements/cancer_progression__icd_original_.html)

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
		Node,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/NonPrimaryPathway/DateOfNonPrimaryCancerDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as NonPrimaryDiagnosisDate,
		Node.value('(ColorectalRecord/NonPrimaryPathway/Progression/ProgressionIcd/@code)[1]', 'varchar(max)') as NonPrimaryProgressionOriginalDiagnosis
	from CosdRecords
)
select 
	distinct 
        NhsNumber,
        NonPrimaryDiagnosisDate,
		NonPrimaryProgressionOriginalDiagnosis
from CO
where NonPrimaryProgressionOriginalDiagnosis is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Progression%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis
Source column  `CancerDiagnosis`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `CancerDiagnosis` The basis of how a PATIENT DIAGNOSIS relating to cancer was identified. [BASIS OF DIAGNOSIS (CANCER)](https://www.datadictionary.nhs.uk/data_elements/basis_of_diagnosis__cancer_.html)

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
		Node,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/MorphologyIcd-o-3/@code)[1]', 'varchar(max)') as CancerHistology,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/TopographyIcd-o-3/@code)[1]', 'varchar(max)') as CancerTopography,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/BasisOfDiagnosisCancer/@code)[1]', 'varchar(max)') as BasisOfDiagnosisCancer,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/PrimaryDiagnosisIcd/@code)[1]', 'varchar(max)') as CancerDiagnosis
	from CosdRecords
)
select
	NhsNumber,
	DateOfPrimaryDiagnosisClinicallyAgreed,
	max(BasisOfDiagnosisCancer) as BasisOfDiagnosisCancer,
	CancerDiagnosis
from CO
where DateOfPrimaryDiagnosisClinicallyAgreed is not null
group by NhsNumber, DateOfPrimaryDiagnosisClinicallyAgreed, CancerDiagnosis;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20mapping){: .btn }
### COSD V9 Condition Occurrence Primary Diagnosis Histology Topography
Source columns  `CancerHistology`, `CancerTopography`.
Resolve ICD-o-3 codes to OMOP concepts.

* `CancerHistology` MORPHOLOGY (ICD-O CANCER TRANSFORMATION) is the morphology code of the Cancer Transformation using the ICD-O CODE. [MORPHOLOGY (ICD-O CANCER TRANSFORMATION)](https://www.datadictionary.nhs.uk/data_elements/morphology__icd-o_cancer_transformation_.html)

* `CancerTopography` TOPOGRAPHY (ICD-O) is the topographical site of the Tumour using the ICD-O CODE. [TOPOGRAPHY (ICD-O)](https://www.datadictionary.nhs.uk/data_elements/topography__icd-o_.html)

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
		Node,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/MorphologyIcd-o-3/@code)[1]', 'varchar(max)') as CancerHistology,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/TopographyIcd-o-3/@code)[1]', 'varchar(max)') as CancerTopography,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/BasisOfDiagnosisCancer/@code)[1]', 'varchar(max)') as BasisOfDiagnosisCancer,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/PrimaryDiagnosisIcd/@code)[1]', 'varchar(max)') as CancerDiagnosis
	from CosdRecords
)
select
	distinct
		NhsNumber,
		DateOfPrimaryDiagnosisClinicallyAgreed,
		BasisOfDiagnosisCancer,
		CancerHistology,
		CancerTopography
from CO
where DateOfPrimaryDiagnosisClinicallyAgreed is not null
	and CancerHistology is not null
	and CancerTopography is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20COSD%20V9%20Condition%20Occurrence%20Primary%20Diagnosis%20Histology%20Topography%20mapping){: .btn }
### CDS Condition Occurrence
Source column  `DiagnosisCode`.
Resolve ICD10 codes to standard or non standard OMOP concepts. If code cannot be mapped, map using the parent code.

* `DiagnosisCode` ICD10 diagnosis code [PRIMARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/primary_diagnosis__icd_.html), [SECONDARY DIAGNOSIS (ICD)](https://www.datadictionary.nhs.uk/data_elements/secondary_diagnosis__icd_.html)

```sql
select
	distinct
		d.DiagnosisCode,
		line01.RecordConnectionIdentifier,
		line01.NHSNumber,
		line01.CDSActivityDate
from omop_staging.cds_diagnosis d
	inner join omop_staging.cds_line01 line01
		on d.MessageId = line01.MessageId
where line01.NHSNumber is not null;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20ConditionOccurrence%20table%20condition_source_concept_id%20field%20CDS%20Condition%20Occurrence%20mapping){: .btn }
