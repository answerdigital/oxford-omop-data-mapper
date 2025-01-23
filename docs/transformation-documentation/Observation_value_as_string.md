---
layout: default
title: value_as_string
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# value_as_string
### SUS OP Source Of Referral For Outpatients
* Value copied from `ReferrerCode`

* `ReferrerCode` Referrer code is the code of the person making the referral request. [REFERRER CODE](https://www.datadictionary.nhs.uk/data_elements/referrer_code.html)

```sql
select
	NHSNumber,
	GeneratedRecordIdentifier,
	AppointmentDate,
	AppointmentTime,
	ReferrerCode   -- Referrer code is the code of the person making the referral request
from [omop_staging].[sus_OP]
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20SUS%20OP%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS Outpatient Carer Support Indicator Observation
* Value copied from `CarerSupportIndicator`

* `CarerSupportIndicator` An indication of whether Carer support is available to the PATIENT at their normal residence. [CARER SUPPORT INDICATOR](https://www.datadictionary.nhs.uk/data_elements/carer_support_indicator.html)

```sql
select 
	op.NHSNumber, 
	max(op.CDSActivityDate) as CDSActivityDate, 
	op.CarerSupportIndicator,
	op.GeneratedRecordIdentifier
from omop_staging.sus_OP op
where op.CarerSupportIndicator is not null
	and op.NHSNumber is not null
group by
	op.NHSNumber, 
	op.CarerSupportIndicator,
	op.GeneratedRecordIdentifier;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20SUS%20Outpatient%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### SUS Inpatient Total Previous Pregnancies Observation
* Value copied from `TotalPreviousPregnancies`

* `TotalPreviousPregnancies` PREGNANCY TOTAL PREVIOUS PREGNANCIES is the number of previous pregnancies resulting in one or more REGISTRABLE BIRTHS. [PREGNANCY TOTAL PREVIOUS PREGNANCIES](https://www.datadictionary.nhs.uk/data_elements/pregnancy_total_previous_pregnancies.html)

```sql
select 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
	max(apc.CDSActivityDate) as observation_date,
	apc.PregnancyTotalPreviousPregnancies
from [omop_staging].[sus_APC] apc
where apc.NHSNumber is not null
	and apc.PregnancyTotalPreviousPregnancies is not null
	and apc.CDSActivityDate is not null
	and apc.CdsType in ('140', '120')
group by 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier, 
    apc.HospitalProviderSpellNumber,
	apc.PregnancyTotalPreviousPregnancies;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20SUS%20Inpatient%20Total%20Previous%20Pregnancies%20Observation%20mapping){: .btn }
### SUS APC Source Of Referral For Outpatients
* Value copied from `ReferrerCode`

* `ReferrerCode` Referrer code is the code of the person making the referral request. [REFERRER CODE](https://www.datadictionary.nhs.uk/data_elements/referrer_code.html)

```sql
select	
	NHSNumber,
	GeneratedRecordIdentifier,
	StartDateHospitalProviderSpell,
	StartTimeHospitalProviderSpell,
	ReferrerCode   -- Referrer code is the code of the person making the referral request
FROM [omop_staging].[sus_APC]
where NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20SUS%20APC%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS Inpatient Carer Support Indicator Observation
* Value copied from `CarerSupportIndicator`

* `CarerSupportIndicator` An indication of whether Carer support is available to the PATIENT at their normal residence. [CARER SUPPORT INDICATOR](https://www.datadictionary.nhs.uk/data_elements/carer_support_indicator.html)

```sql
select 
	apc.NHSNumber, 
	max(apc.CDSActivityDate) as CDSActivityDate, 
	apc.CarerSupportIndicator,
	apc.HospitalProviderSpellNumber,
	apc.GeneratedRecordIdentifier
from omop_staging.sus_APC apc
where apc.CarerSupportIndicator is not null
	and apc.NHSNumber is not null
group by
	apc.NHSNumber, 
	apc.CarerSupportIndicator,
	apc.HospitalProviderSpellNumber,
	apc.GeneratedRecordIdentifier;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20SUS%20Inpatient%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### Sus APC Birth Weight Observation
* Value copied from `BirthWeight`

* `BirthWeight` BIRTH WEIGHT is the result of the Clinical Investigation which measures the Birth Weight, where the UNIT OF MEASUREMENT is Grams (g). [BIRTH WEIGHT](https://www.datadictionary.nhs.uk/data_elements/birth_weight.html)

```sql
select 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
	coalesce(max(apc.DeliveryDate), max(apc.CDSActivityDate)) as observation_date, 
	b.BirthWeightBaby as BirthWeight
from [omop_staging].[sus_APC] apc
	inner join [omop_staging].[sus_Birth] as b
		on apc.MessageId = b.MessageId
where b.BirthWeightBaby is not null
  and apc.NHSNumber is not null
  and apc.CdsType in ('140', '120')
group by 
	apc.NHSNumber,
	apc.GeneratedRecordIdentifier,
    apc.HospitalProviderSpellNumber,
	apc.DeliveryDate,
	b.BirthWeightBaby;
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Sus%20APC%20Birth%20Weight%20Observation%20mapping){: .btn }
### SUS APC Anaesthetic Given Post Labour Delivery Observation
* Value copied from `AnaestheticGivenPostLabourDelivery`

* `AnaestheticGivenPostLabourDelivery` Records whether anaesthetic was given after Delivery, and the type used. [ANAESTHETIC GIVEN POST LABOUR OR DELIVERY CODE](https://www.datadictionary.nhs.uk/data_elements/anaesthetic_given_post_labour_or_delivery_code.html)

```sql
select
    apc.NHSNumber, 
    apc.GeneratedRecordIdentifier, 
	apc.HospitalProviderSpellNumber,
    coalesce(max(apc.DeliveryDate), max(apc.CDSActivityDate)) as observation_date, 
    apc.AnaestheticGivenPostDelivery
from omop_staging.sus_APC as apc
where apc.AnaestheticGivenPostDelivery is not null
  and apc.NHSNumber is not null
  and apc.CdsType in ('140', '120')
group by 
    apc.NHSNumber, 
    apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
    apc.DeliveryDate,
    apc.AnaestheticGivenPostDelivery;
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20SUS%20APC%20Anaesthetic%20Given%20Post%20Labour%20Delivery%20Observation%20mapping){: .btn }
### SUS APC Anaesthetic During Labour Delivery Observation
* Value copied from `AnaestheticDuringLabourDelivery`

* `AnaestheticDuringLabourDelivery` Records whether anaesthetic was given during Labour/ Delivery, and the type used. [ANAESTHETIC GIVEN DURING LABOUR OR DELIVERY CODE](https://www.datadictionary.nhs.uk/data_elements/anaesthetic_given_during_labour_or_delivery_code.html)

```sql
select
    apc.NHSNumber, 
    apc.GeneratedRecordIdentifier, 
    coalesce(max(apc.DeliveryDate), max(apc.CDSActivityDate)) as observation_date,
	apc.HospitalProviderSpellNumber,
    apc.AnaestheticGivenDuringLabourDelivery
from omop_staging.sus_APC as apc
where apc.AnaestheticGivenDuringLabourDelivery is not null
  and apc.NHSNumber is not null
  and apc.CdsType in ('140', '120')
group by 
    apc.NHSNumber, 
    apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
    apc.DeliveryDate, 
    apc.AnaestheticGivenDuringLabourDelivery;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20SUS%20APC%20Anaesthetic%20During%20Labour%20Delivery%20Observation%20mapping){: .btn }
### CosdV9SourceOfReferralForOutpatients
* Value copied from `SourceOfReferralForOutpatients`

* `SourceOfReferralForOutpatients` For specific National Code usage, see SOURCE OF REFERRAL FOR OUT-PATIENTS. [SOURCE OF REFERRAL FOR OUT-PATIENTS](https://www.datadictionary.nhs.uk/data_elements/source_of_referral_for_out-patients.html)

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
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeenCancerSpecialist)[1]', 'varchar(max)') as DateFirstSeenCancerSpecialist,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage,
		Node.value('(ColorectalRecord/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)') as TreatmentStartDateCancer,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/SourceOfReferralForOut-patients/@code)[1]', 'varchar(max)') as SourceOfReferralForOutpatients,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          SourceOfReferralForOutpatients,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (DateFirstSeenCancerSpecialist),
                (DateOfPrimaryDiagnosisClinicallyAgreed),
                (StageDateFinalPretreatmentStage),
                (StageDateIntegratedStage),
                (TreatmentStartDateCancer),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.SourceOfReferralForOutpatients is not null
  and not (
		DateFirstSeen is null and
		DateFirstSeenCancerSpecialist is null and
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		StageDateFinalPretreatmentStage is null and
		StageDateIntegratedStage is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV9SourceOfReferralForOutpatients%20mapping){: .btn }
### CosdV9SourceOfReferralForNonPrimaryCancerPathway
* Value copied from `SourceOfReferralForNonPrimaryCancerPathway`

* `SourceOfReferralForNonPrimaryCancerPathway` SOURCE OF REFERRAL FOR OUT-PATIENTS (NON PRIMARY CANCER PATHWAY) identifies the source of referral for a Non Primary Cancer Pathway. [SOURCE OF REFERRAL FOR OUT-PATIENTS (NON PRIMARY CANCER PATHWAY)](https://www.datadictionary.nhs.uk/data_elements/source_of_referral_for_out-patients__non_primary_cancer_pathway_.html)

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
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeenCancerSpecialist)[1]', 'varchar(max)') as DateFirstSeenCancerSpecialist,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage,
		Node.value('(ColorectalRecord/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)') as TreatmentStartDateCancer,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/NonPrimaryPathway/NonPrimaryCancerPathwayReferral/SourceOfReferralForNonPrimaryCancerPathway/@code)[1]', 'varchar(max)') as SourceOfReferralForNonPrimaryCancerPathway,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          SourceOfReferralForNonPrimaryCancerPathway,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (DateFirstSeenCancerSpecialist),
                (DateOfPrimaryDiagnosisClinicallyAgreed),
                (StageDateFinalPretreatmentStage),
                (StageDateIntegratedStage),
                (TreatmentStartDateCancer),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.SourceOfReferralForNonPrimaryCancerPathway is not null
  and not (
		DateFirstSeen is null and
		DateFirstSeenCancerSpecialist is null and
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		StageDateFinalPretreatmentStage is null and
		StageDateIntegratedStage is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV9SourceOfReferralForNonPrimaryCancerPathway%20mapping){: .btn }
### CosdV9PersonSexualOrientationCodeAtDiagnosis
* Value copied from `PersonSexualOrientationCodeAtDiagnosis`

* `PersonSexualOrientationCodeAtDiagnosis` PERSON STATED SEXUAL ORIENTATION CODE (AT DIAGNOSIS) is the PERSON STATED SEXUAL ORIENTATION CODE at the time of the PATIENT DIAGNOSIS. [PERSON STATED SEXUAL ORIENTATION CODE (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/person_stated_sexual_orientation_code__at_diagnosis_.html)

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
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)') as TreatmentStartDateCancer,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/Demographics/PersonSexualOrientationCodeAtDiagnosis/@code)[1]', 'varchar(max)') as PersonSexualOrientationCodeAtDiagnosis,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          PersonSexualOrientationCodeAtDiagnosis,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateOfPrimaryDiagnosisClinicallyAgreed),
                (TreatmentStartDateCancer),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.PersonSexualOrientationCodeAtDiagnosis is not null
  and not (
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV9PersonSexualOrientationCodeAtDiagnosis%20mapping){: .btn }
### CosdV9HistoryOfAlcoholPast
* Value copied from `HistoryOfAlcoholPast`

* `HistoryOfAlcoholPast` The past history of alcohol consumption for the PATIENT during a Cancer Care Spell. [ALCOHOL HISTORY (CANCER BEFORE LAST THREE MONTHS)](https://www.datadictionary.nhs.uk/data_elements/alcohol_history__cancer_before_last_three_months_.html)

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
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeenCancerSpecialist)[1]', 'varchar(max)') as DateFirstSeenCancerSpecialist,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage,
		Node.value('(ColorectalRecord/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)') as TreatmentStartDateCancer,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/ClinicalNurseSpecialistAndRiskFactorAssessments/HistoryOfAlcoholPast/@code)[1]', 'varchar(max)') as HistoryOfAlcoholPast,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          HistoryOfAlcoholPast,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (DateFirstSeenCancerSpecialist),
                (DateOfPrimaryDiagnosisClinicallyAgreed),
                (StageDateFinalPretreatmentStage),
                (StageDateIntegratedStage),
                (TreatmentStartDateCancer),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.HistoryOfAlcoholPast is not null
  and not (
		DateFirstSeen is null and
		DateFirstSeenCancerSpecialist is null and
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		StageDateFinalPretreatmentStage is null and
		StageDateIntegratedStage is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV9HistoryOfAlcoholPast%20mapping){: .btn }
### CosdV9HistoryOfAlcoholCurrent
* Value copied from `HistoryOfAlcoholCurrent`

* `HistoryOfAlcoholCurrent` The current history of alcohol consumption for the PATIENT during a Cancer Care Spell. [ALCOHOL HISTORY (CANCER IN LAST THREE MONTHS)](https://www.datadictionary.nhs.uk/data_elements/alcohol_history__cancer_in_last_three_months_.html)

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
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeenCancerSpecialist)[1]', 'varchar(max)') as DateFirstSeenCancerSpecialist,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage,
		Node.value('(ColorectalRecord/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)') as TreatmentStartDateCancer,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/ClinicalNurseSpecialistAndRiskFactorAssessments/HistoryOfAlcoholCurrent/@code)[1]', 'varchar(max)') as HistoryOfAlcoholCurrent,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          HistoryOfAlcoholCurrent,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (DateFirstSeenCancerSpecialist),
                (DateOfPrimaryDiagnosisClinicallyAgreed),
                (StageDateFinalPretreatmentStage),
                (StageDateIntegratedStage),
                (TreatmentStartDateCancer),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.HistoryOfAlcoholCurrent is not null
  and not (
		DateFirstSeen is null and
		DateFirstSeenCancerSpecialist is null and
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		StageDateFinalPretreatmentStage is null and
		StageDateIntegratedStage is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV9HistoryOfAlcoholCurrent%20mapping){: .btn }
### CosdV9FamilialCancerSyndrome
* Value copied from `FamilialCancerSyndrome`

* `FamilialCancerSyndrome` An indication of whether there is a possible or confirmed familial cancer syndrome during a Cancer Care Spell. [FAMILIAL CANCER SYNDROME INDICATOR](https://www.datadictionary.nhs.uk/data_elements/familial_cancer_syndrome_indicator.html)

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
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeenCancerSpecialist)[1]', 'varchar(max)') as DateFirstSeenCancerSpecialist,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage,
		Node.value('(ColorectalRecord/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)') as TreatmentStartDateCancer,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/DiagnosisAdditionalItems/FamilialCancerSyndrome/@code)[1]', 'varchar(max)') as FamilialCancerSyndrome,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          FamilialCancerSyndrome,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (DateFirstSeenCancerSpecialist),
                (DateOfPrimaryDiagnosisClinicallyAgreed),
                (StageDateFinalPretreatmentStage),
                (StageDateIntegratedStage),
                (TreatmentStartDateCancer),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.FamilialCancerSyndrome is not null
  and not (
		DateFirstSeen is null and
		DateFirstSeenCancerSpecialist is null and
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		StageDateFinalPretreatmentStage is null and
		StageDateIntegratedStage is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV9FamilialCancerSyndrome%20mapping){: .btn }
### CosdV9FamilialCancerSyndromeSubsidiaryComment
* Value copied from `FamilialCancerSyndromeSubsidiaryComment`

* `FamilialCancerSyndromeSubsidiaryComment` FAMILIAL CANCER SYNDROME COMMENT is free text further information recorded where the FAMILIAL CANCER SYNDROME INDICATOR is National Code 'Y - Yes' or 'P - Possible', to identify distinct syndromes which may have different treatment decisions or outcomes that cannot be coded separately during a Cancer Care Spell. [FAMILIAL CANCER SYNDROME COMMENT](https://www.datadictionary.nhs.uk/data_elements/familial_cancer_syndrome_comment.html)

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
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(ColorectalRecord/PrimaryPathway/ReferralAndFirstStageOfPatientPathway/DateFirstSeenCancerSpecialist)[1]', 'varchar(max)') as DateFirstSeenCancerSpecialist,
		Node.value('(ColorectalRecord/PrimaryPathway/LinkageDiagnosticDetails/DateOfPrimaryDiagnosisClinicallyAgreed)[1]', 'varchar(max)') as DateOfPrimaryDiagnosisClinicallyAgreed,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateFinalPretreatmentStage)[1]', 'varchar(max)') as StageDateFinalPretreatmentStage,
		Node.value('(ColorectalRecord/PrimaryPathway/Staging/StageDateIntegratedStage)[1]', 'varchar(max)') as StageDateIntegratedStage,
		Node.value('(ColorectalRecord/Treatment/TreatmentStartDateCancer)[1]', 'varchar(max)') as TreatmentStartDateCancer,
		Node.value('(ColorectalRecord/Treatment/Surgery/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/DiagnosisAdditionalItems/FamilialCancerSyndromeSubsidiaryComment)[1]', 'varchar(max)') as FamilialCancerSyndromeSubsidiaryComment,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          FamilialCancerSyndromeSubsidiaryComment,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (DateFirstSeenCancerSpecialist),
                (DateOfPrimaryDiagnosisClinicallyAgreed),
                (StageDateFinalPretreatmentStage),
                (StageDateIntegratedStage),
                (TreatmentStartDateCancer),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.FamilialCancerSyndromeSubsidiaryComment is not null
  and not (
		DateFirstSeen is null and
		DateFirstSeenCancerSpecialist is null and
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		StageDateFinalPretreatmentStage is null and
		StageDateIntegratedStage is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV9FamilialCancerSyndromeSubsidiaryComment%20mapping){: .btn }
### CosdV8SourceOfReferralOutPatients
* Value copied from `SourceOfReferralOutPatients`

* `SourceOfReferralOutPatients` For specific National Code usage, see SOURCE OF REFERRAL FOR OUT-PATIENTS. [SOURCE OF REFERRAL FOR OUT-PATIENTS](https://www.datadictionary.nhs.uk/data_elements/source_of_referral_for_out-patients.html)

```sql
;with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD81),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD81:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
		and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
		Id,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/SpecialistDateFirstSeen)[1]', 'varchar(max)') as SpecialistDateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as IntegratedStageTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as FinalPreTreatmentTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/CancerTreatmentStartDate)[1]', 'varchar(max)') as CancerTreatmentStartDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/SourceOfReferralOutPatients/@code)[1]', 'varchar(max)') as SourceOfReferralOutPatients,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          SourceOfReferralOutPatients,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (SpecialistDateFirstSeen),
                (ClinicalDateCancerDiagnosis),
                (IntegratedStageTNMStageGroupingDate),
                (FinalPreTreatmentTNMStageGroupingDate),
                (CancerTreatmentStartDate),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.SourceOfReferralOutPatients is not null
  and not (
		DateFirstSeen is null and
		SpecialistDateFirstSeen is null and
		ClinicalDateCancerDiagnosis is null and
		IntegratedStageTNMStageGroupingDate is null and
		FinalPreTreatmentTNMStageGroupingDate is null and
		CancerTreatmentStartDate is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV8SourceOfReferralOutPatients%20mapping){: .btn }
### CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway
* Value copied from `SourceOfReferralForOutPatientsNonPrimaryCancerPathway`

* `SourceOfReferralForOutPatientsNonPrimaryCancerPathway` SOURCE OF REFERRAL FOR OUT-PATIENTS (NON PRIMARY CANCER PATHWAY) identifies the source of referral for a Non Primary Cancer Pathway. [SOURCE OF REFERRAL FOR OUT-PATIENTS (NON PRIMARY CANCER PATHWAY)](https://www.datadictionary.nhs.uk/data_elements/source_of_referral_for_out-patients__non_primary_cancer_pathway_.html)

```sql
;with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD81),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD81:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
		and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
		Id,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/SpecialistDateFirstSeen)[1]', 'varchar(max)') as SpecialistDateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as IntegratedStageTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as FinalPreTreatmentTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/CancerTreatmentStartDate)[1]', 'varchar(max)') as CancerTreatmentStartDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreNonPrimaryCancerPathway/SourceOfReferralForOutPatientsNonPrimaryCancerPathway/@code)[1]', 'varchar(max)') as SourceOfReferralForOutPatientsNonPrimaryCancerPathway,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          SourceOfReferralForOutPatientsNonPrimaryCancerPathway,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (SpecialistDateFirstSeen),
                (ClinicalDateCancerDiagnosis),
                (IntegratedStageTNMStageGroupingDate),
                (FinalPreTreatmentTNMStageGroupingDate),
                (CancerTreatmentStartDate),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.SourceOfReferralForOutPatientsNonPrimaryCancerPathway is not null
  and not (
		DateFirstSeen is null and
		SpecialistDateFirstSeen is null and
		ClinicalDateCancerDiagnosis is null and
		IntegratedStageTNMStageGroupingDate is null and
		FinalPreTreatmentTNMStageGroupingDate is null and
		CancerTreatmentStartDate is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway%20mapping){: .btn }
### CosdV8PersonStatedSexualOrientationCodeAtDiagnosis
* Value copied from `PersonStatedSexualOrientationCodeAtDiagnosis`

* `PersonStatedSexualOrientationCodeAtDiagnosis` PERSON STATED SEXUAL ORIENTATION CODE (AT DIAGNOSIS) is the PERSON STATED SEXUAL ORIENTATION CODE at the time of the PATIENT DIAGNOSIS. [PERSON STATED SEXUAL ORIENTATION CODE (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/person_stated_sexual_orientation_code__at_diagnosis_.html)

```sql
;with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD81),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD81:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
		and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
		Id,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/CancerTreatmentStartDate)[1]', 'varchar(max)') as CancerTreatmentStartDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreDemographics/PersonStatedSexualOrientationCodeAtDiagnosis/@code)[1]', 'varchar(max)') as PersonStatedSexualOrientationCodeAtDiagnosis,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          PersonStatedSexualOrientationCodeAtDiagnosis,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (ClinicalDateCancerDiagnosis),
                (CancerTreatmentStartDate),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.PersonStatedSexualOrientationCodeAtDiagnosis is not null
  and not (
		ClinicalDateCancerDiagnosis is null and
		CancerTreatmentStartDate is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV8PersonStatedSexualOrientationCodeAtDiagnosis%20mapping){: .btn }
### CosdV8FamilialCancerSyndromeIndicator
* Value copied from `FamilialCancerSyndromeIndicator`

* `FamilialCancerSyndromeIndicator` An indication of whether there is a possible or confirmed familial cancer syndrome during a Cancer Care Spell. [FAMILIAL CANCER SYNDROME INDICATOR](https://www.datadictionary.nhs.uk/data_elements/familial_cancer_syndrome_indicator.html)

```sql
;with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD81),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD81:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
		and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
		Id,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/SpecialistDateFirstSeen)[1]', 'varchar(max)') as SpecialistDateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as IntegratedStageTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as FinalPreTreatmentTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/CancerTreatmentStartDate)[1]', 'varchar(max)') as CancerTreatmentStartDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreDiagnosis/ColorectalCoreDiagnosisAdditionalItems/FamilialCancerSyndromeIndicator/@code)[1]', 'varchar(max)') as FamilialCancerSyndromeIndicator,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          FamilialCancerSyndromeIndicator,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (SpecialistDateFirstSeen),
                (ClinicalDateCancerDiagnosis),
                (IntegratedStageTNMStageGroupingDate),
                (FinalPreTreatmentTNMStageGroupingDate),
                (CancerTreatmentStartDate),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.FamilialCancerSyndromeIndicator is not null
  and not (
		DateFirstSeen is null and
		SpecialistDateFirstSeen is null and
		ClinicalDateCancerDiagnosis is null and
		IntegratedStageTNMStageGroupingDate is null and
		FinalPreTreatmentTNMStageGroupingDate is null and
		CancerTreatmentStartDate is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV8FamilialCancerSyndromeIndicator%20mapping){: .btn }
### CosdV8AlcoholHistoryCancerInLastThreeMonths
* Value copied from `AlcoholHistoryCancerInLastThreeMonths`

* `AlcoholHistoryCancerInLastThreeMonths` The current history of alcohol consumption for the PATIENT during a Cancer Care Spell. [ALCOHOL HISTORY (CANCER IN LAST THREE MONTHS)](https://www.datadictionary.nhs.uk/data_elements/alcohol_history__cancer_in_last_three_months_.html)

```sql
;with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD81),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD81:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
		and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
		Id,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/SpecialistDateFirstSeen)[1]', 'varchar(max)') as SpecialistDateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as IntegratedStageTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as FinalPreTreatmentTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/CancerTreatmentStartDate)[1]', 'varchar(max)') as CancerTreatmentStartDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreClinicalNurseSpecialistAndRiskFactorAssessments/AlcoholHistoryCancerInLastThreeMonths/@code)[1]', 'varchar(max)') as AlcoholHistoryCancerInLastThreeMonths,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          AlcoholHistoryCancerInLastThreeMonths,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (SpecialistDateFirstSeen),
                (ClinicalDateCancerDiagnosis),
                (IntegratedStageTNMStageGroupingDate),
                (FinalPreTreatmentTNMStageGroupingDate),
                (CancerTreatmentStartDate),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.AlcoholHistoryCancerInLastThreeMonths is not null
  and not (
		DateFirstSeen is null and
		SpecialistDateFirstSeen is null and
		ClinicalDateCancerDiagnosis is null and
		IntegratedStageTNMStageGroupingDate is null and
		FinalPreTreatmentTNMStageGroupingDate is null and
		CancerTreatmentStartDate is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV8AlcoholHistoryCancerInLastThreeMonths%20mapping){: .btn }
### CosdV8AlcoholHistoryCancerBeforeLastThreeMonths
* Value copied from `AlcoholHistoryCancerBeforeLastThreeMonths`

* `AlcoholHistoryCancerBeforeLastThreeMonths` The past history of alcohol consumption for the PATIENT during a Cancer Care Spell. [ALCOHOL HISTORY (CANCER BEFORE LAST THREE MONTHS)](https://www.datadictionary.nhs.uk/data_elements/alcohol_history__cancer_before_last_three_months_.html)

```sql
;with 
	XMLNAMESPACES('http://www.datadictionary.nhs.uk/messages/COSD-v8-1' AS COSD81),
	CosdRecords as ( 

	select
		T.staging.value('(Id/@root)[1]', 'uniqueidentifier') as Id,
		T.staging.query('.') as Node
	from omop_staging.cosd_staging
	cross apply content.nodes('COSD81:COSD/*') as T(staging)
	where T.staging.exist('Id/@root') = 1
		and Content.value('namespace-uri((/*:COSD)[1])','nvarchar(max)') = 'http://www.datadictionary.nhs.uk/messages/COSD-v8-1'
		and substring (FileName, 15, 2) = 'CO'
), CO as (
	select
		Id,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/DateFirstSeen)[1]', 'varchar(max)') as DateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreReferralAndFirstStageOfPatientPathway/SpecialistDateFirstSeen)[1]', 'varchar(max)') as SpecialistDateFirstSeen,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkageDiagnosticDetails/ClinicalDateCancerDiagnosis)[1]', 'varchar(max)') as ClinicalDateCancerDiagnosis,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/IntegratedStageTNMStageGroupingDate)[1]', 'varchar(max)') as IntegratedStageTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreStaging/FinalPreTreatmentTNMStageGroupingDate)[1]', 'varchar(max)') as FinalPreTreatmentTNMStageGroupingDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/CancerTreatmentStartDate)[1]', 'varchar(max)') as CancerTreatmentStartDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreTreatment/ColorectalCoreSurgeryAndOtherProcedures/ProcedureDate)[1]', 'varchar(max)') as ProcedureDate,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreClinicalNurseSpecialistAndRiskFactorAssessments/AlcoholHistoryCancerBeforeLastThreeMonths/@code)[1]', 'varchar(max)') as AlcoholHistoryCancerBeforeLastThreeMonths,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          AlcoholHistoryCancerBeforeLastThreeMonths,
          NhsNumber,
          (
              select
                  min (i) as [Date]
              from
              (
                values
                (DateFirstSeen),
                (SpecialistDateFirstSeen),
                (ClinicalDateCancerDiagnosis),
                (IntegratedStageTNMStageGroupingDate),
                (FinalPreTreatmentTNMStageGroupingDate),
                (CancerTreatmentStartDate),
                (ProcedureDate)
              ) as T(i)
          ) as [Date]
from CO o
where o.AlcoholHistoryCancerBeforeLastThreeMonths is not null
  and not (
		DateFirstSeen is null and
		SpecialistDateFirstSeen is null and
		ClinicalDateCancerDiagnosis is null and
		IntegratedStageTNMStageGroupingDate is null and
		FinalPreTreatmentTNMStageGroupingDate is null and
		CancerTreatmentStartDate is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20CosdV8AlcoholHistoryCancerBeforeLastThreeMonths%20mapping){: .btn }
### Cds Total Previous Pregnancies Observation
* Value copied from `TotalPreviousPregnancies`

* `TotalPreviousPregnancies` PREGNANCY TOTAL PREVIOUS PREGNANCIES is the number of previous pregnancies resulting in one or more REGISTRABLE BIRTHS. [PREGNANCY TOTAL PREVIOUS PREGNANCIES](https://www.datadictionary.nhs.uk/data_elements/pregnancy_total_previous_pregnancies.html)

```sql
select 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	max(l1.CDSActivityDate) as CDSActivityDate, 
	l1.TotalPreviousPregnancies
from omop_staging.cds_line01 l1
	left outer join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where l1.TotalPreviousPregnancies is not null 
	and l1.NHSNumber is not null 
	and (l1.CdsRecordType = '140' or l1.CdsRecordType = '120')																			
group by 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	l1.CDSActivityDate, 
	l1.TotalPreviousPregnancies;		
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Total%20Previous%20Pregnancies%20Observation%20mapping){: .btn }
### Cds Source Of Referral For Outpatients Observation
* Value copied from `SourceOfReferralForOutpatients`

* `SourceOfReferralForOutpatients` The ORIGINAL REFERRAL REQUEST RECEIVED DATE must be recorded on any subsequent REFERRAL REQUESTS for the same health care service and should never be altered or removed, even if the Health Care Provider changes, until the specific health care service is provided for the PATIENT, or is no longer required. [ORIGINAL REFERRAL REQUEST RECEIVED DATE](https://www.datadictionary.nhs.uk/data_elements/original_referral_request_received_date.html)

```sql
select 
	l1.NHSNumber,
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	coalesce(max(l9.ReferralRequestReceivedDate), max(l1.CDSActivityDate)) as observation_date, 
	l9.SourceofReferralforOutpatients as SourceOfReferralForOutpatients
from [omop_staging].[cds_line01] l1
	inner join [omop_staging].[cds_line09] l9
		on l1.MessageId = l9.MessageId
	left outer join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where l9.SourceofReferralforOutpatients is not null 
	and l1.NHSNumber is not null 
group by 
	l1.NHSNumber, 
	l9.ReferralRequestReceivedDate, 
	l9.SourceofReferralforOutpatients,
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Source%20Of%20Referral%20For%20Outpatients%20Observation%20mapping){: .btn }
### Cds Carer Support Indicator Observation
* Value copied from `CarerSupportIndicator`

* `CarerSupportIndicator` An indication of whether Carer support is available to the PATIENT at their normal residence. [CARER SUPPORT INDICATOR](https://www.datadictionary.nhs.uk/data_elements/carer_support_indicator.html)

```sql
select 
	l1.NHSNumber, 
	max(l1.CDSActivityDate) as CDSActivityDate, 
	l1.CarerSupportIndicator,
	l5.HospitalProviderSpellNumber,
	l1.RecordConnectionIdentifier
from omop_staging.cds_line01 l1
	left outer join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where NHSNumber is not null
	and CarerSupportIndicator is not null																			
group by 
	l1.NHSNumber, 
	l1.CarerSupportIndicator,
	l5.HospitalProviderSpellNumber,
	l1.RecordConnectionIdentifier;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### Cds Birth Weight Observation
* Value copied from `BirthWeight`

* `BirthWeight` BIRTH WEIGHT is the result of the Clinical Investigation which measures the Birth Weight, where the UNIT OF MEASUREMENT is Grams (g). [BIRTH WEIGHT](https://www.datadictionary.nhs.uk/data_elements/birth_weight.html)

```sql
select 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	coalesce(max(l8.DeliveryDate), MAX(l1.CDSActivityDate)) as observation_date, 
	l1.BirthWeight
from omop_staging.cds_line01 l1																			
	inner join omop_staging.cds_line08 l8														
		on l1.MessageId = l8.MessageId	
	left outer join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where l1.BirthWeight is not null 
	and l1.NHSNumber is not null 
	and (l1.CdsRecordType = '140' or l1.CdsRecordType = '120')		
group by 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier, 
    l5.HospitalProviderSpellNumber,
	l8.DeliveryDate, 
	l1.BirthWeight;	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Birth%20Weight%20Observation%20mapping){: .btn }
### Cds Anaesthetic Given Post Labour Delivery Observation
* Value copied from `AnaestheticGivenPostLabourDelivery`

* `AnaestheticGivenPostLabourDelivery` Records whether anaesthetic was given after Delivery, and the type used. [ANAESTHETIC GIVEN POST LABOUR OR DELIVERY CODE](https://www.datadictionary.nhs.uk/data_elements/anaesthetic_given_post_labour_or_delivery_code.html)

```sql
select 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	coalesce(max(l8.DeliveryDate), max(l1.CDSActivityDate)) as observation_date, 
	l8.AnaestheticGivenPostLabourDelivery																			
from omop_staging.cds_line01 l1																			
	inner join omop_staging.cds_line08 l8														
		on l1.MessageId = l8.MessageId
	left outer join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where l8.AnaestheticGivenPostLabourDelivery is not null 
	and l1.NHSNumber is not null 
	and (l1.CdsRecordType = '140' or l1.CdsRecordType = '120')																			
group by 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier, 
	l5.HospitalProviderSpellNumber,
	l8.DeliveryDate, 
	l8.AnaestheticGivenPostLabourDelivery
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Anaesthetic%20Given%20Post%20Labour%20Delivery%20Observation%20mapping){: .btn }
### Cds Anaesthetic During Labour Delivery Observation
* Value copied from `AnaestheticDuringLabourDelivery`

* `AnaestheticDuringLabourDelivery` Records whether anaesthetic was given during Labour/ Delivery, and the type used. [ANAESTHETIC GIVEN DURING LABOUR OR DELIVERY CODE](https://www.datadictionary.nhs.uk/data_elements/anaesthetic_given_during_labour_or_delivery_code.html)

```sql
select 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier, 
	coalesce(max(l8.DeliveryDate), max(l1.CDSActivityDate)) as observation_date, 
	l8.AnaestheticDuringLabourDelivery
from  [omop_staging].[cds_line01] l1																		
	inner join [omop_staging].[cds_line08] l8												
		on l1.MessageId = l8.MessageId																			
where l8.AnaestheticDuringLabourDelivery is not null 
	and l1.NHSNumber is not null 
	and (l1.CdsRecordType = '140' or l1.CdsRecordType = '120')																			
group by 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier, 
	l8.DeliveryDate, 
	l8.AnaestheticDuringLabourDelivery
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Anaesthetic%20During%20Labour%20Delivery%20Observation%20mapping){: .btn }
