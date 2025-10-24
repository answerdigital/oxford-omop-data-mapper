---
layout: default
title: observation_datetime
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# observation_datetime
### SUS OP Source Of Referral For Outpatients
Source columns  `AppointmentDate`, `AppointmentTime`.
Combines a date with a time of day.

* `AppointmentDate` Event date [APPOINTMENT DATE](https://www.datadictionary.nhs.uk/data_elements/appointment_date.html)

* `AppointmentTime` The time, advised to a PATIENT for when they can expect to see a relevant CARE PROFESSIONAL at an Out-Patient Clinic. [APPOINTMENT TIME](https://www.datadictionary.nhs.uk/data_elements/appointment_time.html)

```sql
select
	NHSNumber,
	GeneratedRecordIdentifier,
	AppointmentDate,
	AppointmentTime,
	ReferrerCode   -- Referrer code is the code of the person making the referral request
from omop_staging.sus_OP
	where ReferrerCode is not null
	and NHSNumber is not null
	and AttendedorDidNotAttend in ('5','6')
order by NHSNumber,
	GeneratedRecordIdentifier,
	AppointmentDate,
	AppointmentTime,
	ReferrerCode
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20OP%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS OP Referral Received Date For Outpatients
Source columns  `AppointmentDate`, `AppointmentTime`.
Combines a date with a time of day.

* `AppointmentDate` Event date [APPOINTMENT DATE](https://www.datadictionary.nhs.uk/data_elements/appointment_date.html)

* `AppointmentTime` The time, advised to a PATIENT for when they can expect to see a relevant CARE PROFESSIONAL at an Out-Patient Clinic. [APPOINTMENT TIME](https://www.datadictionary.nhs.uk/data_elements/appointment_time.html)

```sql
	select
		op.NHSNumber, 
		op.AppointmentDate,
		op.AppointmentTime,
		op.ReferralRequestReceivedDate,
		op.GeneratedRecordIdentifier
	from omop_staging.sus_OP op
	where ReferralRequestReceivedDate is not null
		and op.NHSNumber is not null
		and AttendedorDidNotAttend in ('5','6')
	order by op.NHSNumber, 
		op.AppointmentDate,
		op.AppointmentTime,
		op.ReferralRequestReceivedDate,
		op.GeneratedRecordIdentifier
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20OP%20Referral%20Received%20Date%20For%20Outpatients%20mapping){: .btn }
### SUS Outpatient Carer Support Indicator Observation
Source column  `CDSActivityDate`.
Converts text to dates.

* `CDSActivityDate` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html)

```sql
select 
	op.NHSNumber, 
	max(op.CDSActivityDate) as CDSActivityDate, 
	op.CarerSupportIndicator,
	op.GeneratedRecordIdentifier
from omop_staging.sus_OP op
where op.CarerSupportIndicator is not null
	and op.NHSNumber is not null
	and AttendedorDidNotAttend in ('5','6')
group by
	op.NHSNumber, 
	op.CarerSupportIndicator,
	op.GeneratedRecordIdentifier;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20Outpatient%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### Sus CCMDS High Cost Drugs
Source columns  `ObservationDate`, `ObservationDateTime`.
Combines a date with a time of day.

* `ObservationDate` Start date of the visit [CRITICAL CARE START DATE](https://www.datadictionary.nhs.uk/data_elements/critical_care_start_date.html)

* `ObservationDateTime` Start time of the visit, if exists, else midnight. [CRITICAL CARE START TIME](https://www.datadictionary.nhs.uk/data_elements/critical_care_start_time.html)

```sql
		select distinct
			apc.NHSNumber,
			apc.HospitalProviderSpellNumber,
			cc.CriticalCareStartDate as ObservationDate,
			coalesce(cc.CriticalCareStartTime, '00:00:00') as ObservationDateTime,
			d.CriticalCareHighCostDrugs as ObservationSourceValue
		from omop_staging.sus_CCMDS_CriticalCareHighCostDrugs d
		inner join omop_staging.sus_CCMDS cc on d.MessageId = cc.MessageId
		inner join omop_staging.sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20Sus%20CCMDS%20High%20Cost%20Drugs%20mapping){: .btn }
### SUS Inpatient Total Previous Pregnancies Observation
Source column  `observation_date`.
Converts text to dates.

* `observation_date` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html)

```sql
select 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
	max(apc.CDSActivityDate) as observation_date,
	apc.PregnancyTotalPreviousPregnancies
from omop_staging.sus_APC apc
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20Inpatient%20Total%20Previous%20Pregnancies%20Observation%20mapping){: .btn }
### SUS APC Source Of Referral For Inpatients
Source columns  `StartDateHospitalProviderSpell`, `StartTimeHospitalProviderSpell`.
Combines a date with a time of day.

* `StartDateHospitalProviderSpell` Event date [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html)

* `StartTimeHospitalProviderSpell` Records whether anaesthetic was given during Labour/ Delivery, and the type used. [START TIME (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_time__hospital_provider_spell_.html)

```sql
select	
	NHSNumber,
	GeneratedRecordIdentifier,
	StartDateHospitalProviderSpell,
	StartTimeHospitalProviderSpell,
	ReferrerCode   -- Referrer code is the code of the person making the referral request
FROM omop_staging.sus_APC
where NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20APC%20Source%20Of%20Referral%20For%20Inpatients%20mapping){: .btn }
### SUS APC Referral Received Date For Inpatients
Source columns  `StartDateHospitalProviderSpell`, `StartTimeHospitalProviderSpell`.
Combines a date with a time of day.

* `StartDateHospitalProviderSpell` START DATE (HOSPITAL PROVIDER SPELL) is the Start Date of the Hospital Provider Spell. [START DATE (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_date__hospital_provider_spell_.html)

* `StartTimeHospitalProviderSpell` START TIME (HOSPITAL PROVIDER SPELL)  is the Start Time  of the Hospital Provider Spell . [START TIME (HOSPITAL PROVIDER SPELL)](https://www.datadictionary.nhs.uk/data_elements/start_time__hospital_provider_spell_.html)

```sql
	select
		apc.NHSNumber, 
		apc.StartDateHospitalProviderSpell,
		apc.StartTimeHospitalProviderSpell,
		apc.ReferralToTreatmentPeriodStartDate,
		apc.GeneratedRecordIdentifier
	from omop_staging.sus_APC apc
	where ReferralToTreatmentPeriodStartDate is not null
		and apc.NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20APC%20Referral%20Received%20Date%20For%20Inpatients%20mapping){: .btn }
### SUS Inpatient NumberofBabies Observation
Source column  `observation_date`.
Converts text to dates.

* `observation_date` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [DELIVERY DATE](https://www.datadictionary.nhs.uk/data_elements/delivery_date.html)

```sql
select
	apc.NHSNumber,
	apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
	coalesce(max(apc.DeliveryDate), max(apc.CDSActivityDate)) as observation_date,
	apc.NumberofBabies
from omop_staging.sus_APC apc													
where apc.NHSNumber is not null
	and apc.NumberofBabies is not null
	and apc.CDSType in ('120','140')
group by
	apc.NHSNumber,
	apc.GeneratedRecordIdentifier, 
    apc.HospitalProviderSpellNumber,
	apc.DeliveryDate,
	apc.NumberofBabies;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20Inpatient%20NumberofBabies%20Observation%20mapping){: .btn }
### SUS Inpatient Gestation Length Labour Onset Observation
Source column  `observation_date`.
Converts text to dates.

* `observation_date` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [DELIVERY DATE](https://www.datadictionary.nhs.uk/data_elements/delivery_date.html)

```sql
select 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
	coalesce(max(apc.DeliveryDate), max(apc.CDSActivityDate)) as observation_date, 
	apc.GestationLengthLabourOnset
from omop_staging.sus_APC as apc																			
where apc.NHSNumber is not null
  and apc.GestationLengthLabourOnset is not null
  and apc.CDSType in ('120', '140')
group by 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier, 
    apc.HospitalProviderSpellNumber,
	apc.DeliveryDate, 
	apc.GestationLengthLabourOnset;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20Inpatient%20Gestation%20Length%20Labour%20Onset%20Observation%20mapping){: .btn }
### SUS Inpatient Carer Support Indicator Observation
Source column  `CDSActivityDate`.
Converts text to dates.

* `CDSActivityDate` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20Inpatient%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### Sus APC Birth Weight Observation
Source column  `observation_date`.
Converts text to dates.

* `observation_date` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [DELIVERY DATE](https://www.datadictionary.nhs.uk/data_elements/delivery_date.html)

```sql
select 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
	coalesce(max(apc.DeliveryDate), max(apc.CDSActivityDate)) as observation_date, 
	b.BirthWeightBaby as BirthWeight
from omop_staging.sus_APC apc
	inner join omop_staging.sus_Birth as b
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20Sus%20APC%20Birth%20Weight%20Observation%20mapping){: .btn }
### SUS APC Anaesthetic Given Post Labour Delivery Observation
Source column  `observation_date`.
Converts text to dates.

* `observation_date` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20APC%20Anaesthetic%20Given%20Post%20Labour%20Delivery%20Observation%20mapping){: .btn }
### SUS APC Anaesthetic During Labour Delivery Observation
Source column  `observation_date`.
Converts text to dates.

* `observation_date` Event date [CDS ACTIVITY DATE](https://www.datadictionary.nhs.uk/data_elements/cds_activity_date.html), [DELIVERY DATE](https://www.datadictionary.nhs.uk/data_elements/delivery_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20APC%20Anaesthetic%20During%20Labour%20Delivery%20Observation%20mapping){: .btn }
### SUS AE Source Of Referral For AE
Source columns  `ArrivalDate`, `ArrivalTime`.
Combines a date with a time of day.

* `ArrivalDate` Event date [ARRIVAL DATE]()

* `ArrivalTime` The time (using a 24 hour clock) that is of relevance to an ACTIVITY. [ARRIVAL TIME AT ACCIDENT AND EMERGENCY DEPARTMENT]()

```sql
select
	NHSNumber,
	GeneratedRecordIdentifier,
    ArrivalDate,
    ArrivalTime,
	SourceofReferralForAE   -- Referrer code is the code of the person making the referral request
from omop_staging.sus_AE
where SourceofReferralForAE is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20AE%20Source%20Of%20Referral%20For%20AE%20mapping){: .btn }
### SUS AE Diabetic Patient
Source columns  `ArrivalDate`, `ArrivalTime`.
Combines a date with a time of day.

* `ArrivalDate` Event date [ARRIVAL DATE]()

* `ArrivalTime` The time (using a 24 hour clock) that is of relevance to an ACTIVITY. [ARRIVAL TIME AT ACCIDENT AND EMERGENCY DEPARTMENT]()

```sql
select
	distinct
		d.AccidentAndEmergencyDiagnosis,
		ae.GeneratedRecordIdentifier,
		ae.NHSNumber,
		ae.ArrivalDate,
		ae.ArrivalTime
from omop_staging.sus_AE_diagnosis d
	inner join omop_staging.sus_AE ae
		on d.MessageId = ae.MessageId
where ae.NHSNumber is not null
and d.AccidentAndEmergencyDiagnosis in ('30','301')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20AE%20Diabetic%20Patient%20mapping){: .btn }
### SUS AE Diabetic Patient
Source columns  `ArrivalDate`, `ArrivalTime`.
Combines a date with a time of day.

* `ArrivalDate` Event date [ARRIVAL DATE]()

* `ArrivalTime` The time (using a 24 hour clock) that is of relevance to an ACTIVITY. [ARRIVAL TIME AT ACCIDENT AND EMERGENCY DEPARTMENT]()

```sql
select
	distinct
		d.AccidentAndEmergencyDiagnosis,
		ae.GeneratedRecordIdentifier,
		ae.NHSNumber,
		ae.ArrivalDate,
		ae.ArrivalTime
from omop_staging.sus_AE_diagnosis d
	inner join omop_staging.sus_AE ae
		on d.MessageId = ae.MessageId
where ae.NHSNumber is not null
and d.AccidentAndEmergencyDiagnosis in ('20','201')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20SUS%20AE%20Diabetic%20Patient%20mapping){: .btn }
### Oxford Lab General Comment Observation
Source column  `EVENT_START_DT_TM`.
Converts text to dates.

* `EVENT_START_DT_TM` Lab test event start datetime [EVENT START DT TM]()

```sql
select
    NHS_NUMBER,
    EVENT,
    EVENT_START_DT_TM,
    RESULT_VALUE
from ##duckdb_source##
where lower(EVENT) like '%comment%'
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20Oxford%20Lab%20General%20Comment%20Observation%20mapping){: .btn }
### CosdV9TobaccoSmokingStatus
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(ColorectalRecord/ClinicalNurseSpecialistAndRiskFactorAssessments/TobaccoSmokingStatus/@code)[1]', 'varchar(max)') as TobaccoSmokingStatus,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          TobaccoSmokingStatus,
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
where o.TobaccoSmokingStatus is not null
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9TobaccoSmokingStatus%20mapping){: .btn }
### CosdV9TobaccoSmokingCessation
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(ColorectalRecord/ClinicalNurseSpecialistAndRiskFactorAssessments/TobaccoSmokingCessation/@code)[1]', 'varchar(max)') as TobaccoSmokingCessation,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          TobaccoSmokingCessation,
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
where o.TobaccoSmokingCessation is not null
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9TobaccoSmokingCessation%20mapping){: .btn }
### CosdV9SourceOfReferralForOutpatients
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9SourceOfReferralForOutpatients%20mapping){: .btn }
### CosdV9SourceOfReferralForNonPrimaryCancerPathway
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9SourceOfReferralForNonPrimaryCancerPathway%20mapping){: .btn }
### CosdV9PersonSexualOrientationCodeAtDiagnosis
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9PersonSexualOrientationCodeAtDiagnosis%20mapping){: .btn }
### CosdV9PerformanceStatusAdult
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(ColorectalRecord/PrimaryPathway/Diagnosis/PerformanceStatusAdult/@code)[1]', 'varchar(max)') as PerformanceStatusAdult,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          PerformanceStatusAdult,
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
where o.PerformanceStatusAdult is not null
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9PerformanceStatusAdult%20mapping){: .btn }
### CosdV9MenopausalStatus
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(ColorectalRecord/ClinicalNurseSpecialistAndRiskFactorAssessments/MenopausalStatus/@code)[1]', 'varchar(max)') as MenopausalStatus,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          MenopausalStatus,
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
where o.MenopausalStatus is not null
  and not (
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
)
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9MenopausalStatus%20mapping){: .btn }
### CosdV9HistoryOfAlcoholPast
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9HistoryOfAlcoholPast%20mapping){: .btn }
### CosdV9HistoryOfAlcoholCurrent
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9HistoryOfAlcoholCurrent%20mapping){: .btn }
### CosdV9FamilialCancerSyndrome
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9FamilialCancerSyndrome%20mapping){: .btn }
### CosdV9FamilialCancerSyndromeSubsidiaryComment
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9FamilialCancerSyndromeSubsidiaryComment%20mapping){: .btn }
### CosdV9AsaScore
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(ColorectalRecord/Treatment/Surgery/AsaScore/@code)[1]', 'varchar(max)') as AsaScore,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          AsaScore,
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
where o.AsaScore is not null
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9AsaScore%20mapping){: .btn }
### CosdV9AdultComorbidityEvaluation
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DATE OF PRIMARY CANCER DIAGNOSIS (CLINICALLY AGREED)](https://www.datadictionary.nhs.uk/data_elements/date_of_primary_cancer_diagnosis__clinically_agreed_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(ColorectalRecord/CancerCarePlan/AdultComorbidityEvaluation-27Score/@code)[1]', 'varchar(max)') as AdultComorbidityEvaluation,
		Node.value('(ColorectalRecord/LinkagePatientId/NhsNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          AdultComorbidityEvaluation,
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
where o.AdultComorbidityEvaluation is not null
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV9AdultComorbidityEvaluation%20mapping){: .btn }
### CosdV8SourceOfReferralOutPatients
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8SourceOfReferralOutPatients%20mapping){: .btn }
### CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway%20mapping){: .btn }
### CosdV8SmokingStatusCode
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreClinicalNurseSpecialistAndRiskFactorAssessments/SmokingStatusCode/@code)[1]', 'varchar(max)') as SmokingStatusCode,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          SmokingStatusCode,
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
where o.SmokingStatusCode is not null
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8SmokingStatusCode%20mapping){: .btn }
### CosdV8PersonStatedSexualOrientationCodeAtDiagnosis
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8PersonStatedSexualOrientationCodeAtDiagnosis%20mapping){: .btn }
### CosdV8FamilialCancerSyndromeIndicator
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8FamilialCancerSyndromeIndicator%20mapping){: .btn }
### CosdV8AlcoholHistoryCancerInLastThreeMonths
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8AlcoholHistoryCancerInLastThreeMonths%20mapping){: .btn }
### CosdV8AlcoholHistoryCancerBeforeLastThreeMonths
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8AlcoholHistoryCancerBeforeLastThreeMonths%20mapping){: .btn }
### CosdV8AdultPerformanceStatus
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreDiagnosis/AdultPerformanceStatus/@code)[1]', 'varchar(max)') as AdultPerformanceStatus,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          AdultPerformanceStatus,
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
where o.AdultPerformanceStatus is not null
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8AdultPerformanceStatus%20mapping){: .btn }
### CosdV8AdultComorbidityEvaluation
Source column  `Date`.
Converts text to dates.

* `Date` Observation date [DATE FIRST SEEN](https://www.datadictionary.nhs.uk/data_elements/date_first_seen.html), [DATE FIRST SEEN (CANCER SPECIALIST)](https://www.datadictionary.nhs.uk/data_elements/date_first_seen__cancer_specialist_.html), [DIAGNOSIS DATE](https://www.datadictionary.nhs.uk/data_elements/diagnosis_date.html), [TNM STAGE GROUPING DATE (INTEGRATED)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__integrated_.html), [TNM STAGE GROUPING DATE (FINAL PRETREATMENT)](https://www.datadictionary.nhs.uk/data_elements/tnm_stage_grouping_date__final_pretreatment_.html), [TREATMENT START DATE (CANCER)](https://www.datadictionary.nhs.uk/data_elements/treatment_start_date__cancer_.html), [PROCEDURE DATE](https://www.datadictionary.nhs.uk/data_elements/procedure_date.html)

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
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreCancerCarePlan/AdultComorbidityEvaluation/@code)[1]', 'varchar(max)') as AdultComorbidityEvaluation,
		Node.value('(COSDRecord/Colorectal/ColorectalCore/ColorectalCoreLinkagePatientId/NHSNumber/@extension)[1]', 'varchar(max)') as NhsNumber
  from CosdRecords
)
select
      distinct
          AdultComorbidityEvaluation,
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
where o.AdultComorbidityEvaluation is not null
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20observation_datetime%20field%20CosdV8AdultComorbidityEvaluation%20mapping){: .btn }
