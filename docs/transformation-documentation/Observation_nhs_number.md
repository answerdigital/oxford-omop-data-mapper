---
layout: default
title: nhs_number
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# nhs_number
### SUS OP Source Of Referral For Outpatients
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select
	NHSNumber,
	GeneratedRecordIdentifier,
	AppointmentDate,
	AppointmentTime,
	ReferrerCode   -- Referrer code is the code of the person making the referral request
from [omop_staging].[sus_OP]
	where ReferrerCode is not null
	and NHSNumber is not null
	and AttendedorDidNotAttend in ('5','6')
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20OP%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS OP Referral Received Date For Outpatients
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20OP%20Referral%20Received%20Date%20For%20Outpatients%20mapping){: .btn }
### SUS Outpatient Carer Support Indicator Observation
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20Outpatient%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### Sus CCMDS High Cost Drugs
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
		select distinct
			apc.NHSNumber,
			apc.HospitalProviderSpellNumber,
			cc.CriticalCareStartDate as ObservationDate,
			coalesce(cc.CriticalCareStartTime, '00:00:00') as ObservationDateTime,
			d.CriticalCareHighCostDrugs as ObservationSourceValue
		from [omop_staging].[sus_CCMDS_CriticalCareHighCostDrugs] d
		inner join [omop_staging].[sus_CCMDS] cc on d.MessageId = cc.MessageId
		inner join [omop_staging].sus_APC apc on cc.GeneratedRecordID = apc.GeneratedRecordIdentifier
		where apc.NHSNumber is not null
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20Sus%20CCMDS%20High%20Cost%20Drugs%20mapping){: .btn }
### SUS Inpatient Total Previous Pregnancies Observation
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20Inpatient%20Total%20Previous%20Pregnancies%20Observation%20mapping){: .btn }
### SUS APC Source Of Referral For Outpatients
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20APC%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS Inpatient NumberofBabies Observation
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select
	apc.NHSNumber,
	apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
	coalesce(max(apc.DeliveryDate), max(apc.CDSActivityDate)) as observation_date,
	apc.NumberofBabies
from [omop_staging].[sus_APC] apc													
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20Inpatient%20NumberofBabies%20Observation%20mapping){: .btn }
### SUS Inpatient Gestation Length Labour Onset Observation
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

```sql
select 
	apc.NHSNumber, 
	apc.GeneratedRecordIdentifier,
	apc.HospitalProviderSpellNumber,
	coalesce(max(apc.DeliveryDate), max(apc.CDSActivityDate)) as observation_date, 
	apc.GestationLengthLabourOnset
from [omop_staging].[sus_APC] as apc																			
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20Inpatient%20Gestation%20Length%20Labour%20Onset%20Observation%20mapping){: .btn }
### SUS Inpatient Carer Support Indicator Observation
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20Inpatient%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### Sus APC Birth Weight Observation
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20Sus%20APC%20Birth%20Weight%20Observation%20mapping){: .btn }
### SUS APC Anaesthetic Given Post Labour Delivery Observation
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20APC%20Anaesthetic%20Given%20Post%20Labour%20Delivery%20Observation%20mapping){: .btn }
### SUS APC Anaesthetic During Labour Delivery Observation
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20APC%20Anaesthetic%20During%20Labour%20Delivery%20Observation%20mapping){: .btn }
### SUS AE Source Of Referral For Outpatients
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20AE%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS AE Diabetic Patient
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20AE%20Diabetic%20Patient%20mapping){: .btn }
### SUS AE Diabetic Patient
* Value copied from `NHSNumber`

* `NHSNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20SUS%20AE%20Diabetic%20Patient%20mapping){: .btn }
### CosdV9TobaccoSmokingStatus
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9TobaccoSmokingStatus%20mapping){: .btn }
### CosdV9TobaccoSmokingCessation
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9TobaccoSmokingCessation%20mapping){: .btn }
### CosdV9SourceOfReferralForOutpatients
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9SourceOfReferralForOutpatients%20mapping){: .btn }
### CosdV9SourceOfReferralForNonPrimaryCancerPathway
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9SourceOfReferralForNonPrimaryCancerPathway%20mapping){: .btn }
### CosdV9PersonSexualOrientationCodeAtDiagnosis
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9PersonSexualOrientationCodeAtDiagnosis%20mapping){: .btn }
### CosdV9PerformanceStatusAdult
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9PerformanceStatusAdult%20mapping){: .btn }
### CosdV9MenopausalStatus
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9MenopausalStatus%20mapping){: .btn }
### CosdV9HistoryOfAlcoholPast
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9HistoryOfAlcoholPast%20mapping){: .btn }
### CosdV9HistoryOfAlcoholCurrent
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9HistoryOfAlcoholCurrent%20mapping){: .btn }
### CosdV9FamilialCancerSyndrome
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9FamilialCancerSyndrome%20mapping){: .btn }
### CosdV9FamilialCancerSyndromeSubsidiaryComment
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9FamilialCancerSyndromeSubsidiaryComment%20mapping){: .btn }
### CosdV9AsaScore
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9AsaScore%20mapping){: .btn }
### CosdV9AdultComorbidityEvaluation
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV9AdultComorbidityEvaluation%20mapping){: .btn }
### CosdV8SourceOfReferralOutPatients
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8SourceOfReferralOutPatients%20mapping){: .btn }
### CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8SourceOfReferralForOutPatientsNonPrimaryCancerPathway%20mapping){: .btn }
### CosdV8SmokingStatusCode
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8SmokingStatusCode%20mapping){: .btn }
### CosdV8PersonStatedSexualOrientationCodeAtDiagnosis
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8PersonStatedSexualOrientationCodeAtDiagnosis%20mapping){: .btn }
### CosdV8FamilialCancerSyndromeIndicator
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8FamilialCancerSyndromeIndicator%20mapping){: .btn }
### CosdV8AlcoholHistoryCancerInLastThreeMonths
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8AlcoholHistoryCancerInLastThreeMonths%20mapping){: .btn }
### CosdV8AlcoholHistoryCancerBeforeLastThreeMonths
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8AlcoholHistoryCancerBeforeLastThreeMonths%20mapping){: .btn }
### CosdV8AdultPerformanceStatus
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8AdultPerformanceStatus%20mapping){: .btn }
### CosdV8AdultComorbidityEvaluation
* Value copied from `NhsNumber`

* `NhsNumber` Patient NHS Number [NHS NUMBER](https://www.datadictionary.nhs.uk/data_elements/nhs_number.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20nhs_number%20field%20CosdV8AdultComorbidityEvaluation%20mapping){: .btn }
