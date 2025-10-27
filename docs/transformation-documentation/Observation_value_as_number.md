---
layout: default
title: value_as_number
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# value_as_number
### SUS Inpatient Total Previous Pregnancies Observation
Source column  `TotalPreviousPregnancies`.
Converts text to number.

* `TotalPreviousPregnancies` PREGNANCY TOTAL PREVIOUS PREGNANCIES is the number of previous pregnancies resulting in one or more REGISTRABLE BIRTHS. [PREGNANCY TOTAL PREVIOUS PREGNANCIES](https://www.datadictionary.nhs.uk/data_elements/pregnancy_total_previous_pregnancies.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20SUS%20Inpatient%20Total%20Previous%20Pregnancies%20Observation%20mapping){: .btn }
### SUS Inpatient NumberofBabies Observation
Source column  `NumberofBabies`.
Converts text to number.

* `NumberofBabies` The number of REGISTRABLE BIRTHS (live or still born at a particular delivery). [NUMBER OF BABIES INDICATION CODE](https://www.datadictionary.nhs.uk/data_elements/number_of_babies_indication_code.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20SUS%20Inpatient%20NumberofBabies%20Observation%20mapping){: .btn }
### SUS Inpatient Gestation Length Labour Onset Observation
Source column  `GestationLengthLabourOnset`.
Converts text to number.

* `GestationLengthLabourOnset` GESTATION LENGTH (LABOUR ONSET) records a period of between 10 to 49 weeks in completed weeks at the onset of Labour. [GESTATION LENGTH (LABOUR ONSET)](https://www.datadictionary.nhs.uk/data_elements/gestation_length__labour_onset_.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20SUS%20Inpatient%20Gestation%20Length%20Labour%20Onset%20Observation%20mapping){: .btn }
### CosdV9TobaccoSmokingStatus
Source column  `TobaccoSmokingStatus`.
Converts text to number.

* `TobaccoSmokingStatus` SMOKING STATUS (CANCER) is for use in the Cancer Outcomes and Services Data Set: Core to identify if the PATIENT smokes tobacco only. [SMOKING STATUS (CANCER)](https://www.datadictionary.nhs.uk/data_elements/smoking_status__cancer_.html)

```sql
with CO as (
	select
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeen' as DateFirstSeen,
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeenCancerSpecialist' as DateFirstSeenCancerSpecialist,
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
		Record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage' as StageDateFinalPretreatmentStage,
		Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage' as StageDateIntegratedStage,
		  coalesce(Record ->> '$.Treatment[0].TreatmentStartDateCancer', Record ->> '$.Treatment.TreatmentStartDateCancer') as TreatmentStartDateCancer,
		coalesce(Record ->> '$.Treatment[0].Surgery.ProcedureDate', Record ->> '$.Treatment.Surgery.ProcedureDate') as ProcedureDate,
		Record ->> '$.ClinicalNurseSpecialistAndRiskFactorAssessments.TobaccoSmokingStatus.@code' as TobaccoSmokingStatus,
		Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber
	from omop_staging.cosd_staging_901
	where type = 'CO'
)
select
	distinct
		TobaccoSmokingStatus,
		NhsNumber,
		least(
			cast(DateFirstSeen as date),
			cast(DateFirstSeenCancerSpecialist as date),
			cast(DateOfPrimaryDiagnosisClinicallyAgreed as date),
			cast(StageDateFinalPretreatmentStage as date),
			cast(StageDateIntegratedStage as date),
			cast(TreatmentStartDateCancer as date),
			cast(ProcedureDate as date)
		) as Date
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
    );
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV9TobaccoSmokingStatus%20mapping){: .btn }
### CosdV9TobaccoSmokingCessation
Source column  `TobaccoSmokingCessation`.
Converts text to number.

* `TobaccoSmokingCessation` An indication of whether treatment was given to the PATIENT for tobacco smoking cessation. [TOBACCO SMOKING CESSATION TREATMENT INDICATION CODE](https://www.datadictionary.nhs.uk/data_elements/tobacco_smoking_cessation_treatment_indication_code.html)

```sql
with CO as (
	select
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeen' as DateFirstSeen,
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeenCancerSpecialist' as DateFirstSeenCancerSpecialist,
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
		Record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage' as StageDateFinalPretreatmentStage,
		Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage' as StageDateIntegratedStage,
		  coalesce(Record ->> '$.Treatment[0].TreatmentStartDateCancer', Record ->> '$.Treatment.TreatmentStartDateCancer') as TreatmentStartDateCancer,
		coalesce(Record ->> '$.Treatment[0].Surgery.ProcedureDate', Record ->> '$.Treatment.Surgery.ProcedureDate') as ProcedureDate,
		Record ->> '$.ClinicalNurseSpecialistAndRiskFactorAssessments.TobaccoSmokingCessation.@code' as TobaccoSmokingCessation,
		Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber
	from omop_staging.cosd_staging_901
	where type = 'CO'
)
select
	distinct
		TobaccoSmokingCessation,
		NhsNumber,
		least(
			cast(DateFirstSeen as date),
			cast(DateFirstSeenCancerSpecialist as date),
			cast(DateOfPrimaryDiagnosisClinicallyAgreed as date),
			cast(StageDateFinalPretreatmentStage as date),
			cast(StageDateIntegratedStage as date),
			cast(TreatmentStartDateCancer as date),
			cast(ProcedureDate as date)
		) as Date
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
    );
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV9TobaccoSmokingCessation%20mapping){: .btn }
### CosdV9PerformanceStatusAdult
Source column  `PerformanceStatusAdult`.
Converts text to number.

* `PerformanceStatusAdult` A World Health Organisation classification indicating a PERSON's status relating to activity/DISABILITY. [PERFORMANCE STATUS (ADULT)](https://www.datadictionary.nhs.uk/data_elements/performance_status__adult_.html)

```sql
with CO as (
	select
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeen' as DateFirstSeen,
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeenCancerSpecialist' as DateFirstSeenCancerSpecialist,
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
		Record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage' as StageDateFinalPretreatmentStage,
		Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage' as StageDateIntegratedStage,
		  coalesce(Record ->> '$.Treatment[0].TreatmentStartDateCancer', Record ->> '$.Treatment.TreatmentStartDateCancer') as TreatmentStartDateCancer,
		coalesce(Record ->> '$.Treatment[0].Surgery.ProcedureDate', Record ->> '$.Treatment.Surgery.ProcedureDate') as ProcedureDate,
		Record ->> '$.PrimaryPathway.Diagnosis.PerformanceStatusAdult.@code' as PerformanceStatusAdult,
		Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber
	from omop_staging.cosd_staging_901
	where type = 'CO'
)
select
	distinct
		PerformanceStatusAdult,
		NhsNumber,
		least(
			cast(DateFirstSeen as date),
			cast(DateFirstSeenCancerSpecialist as date),
			cast(DateOfPrimaryDiagnosisClinicallyAgreed as date),
			cast(StageDateFinalPretreatmentStage as date),
			cast(StageDateIntegratedStage as date),
			cast(TreatmentStartDateCancer as date),
			cast(ProcedureDate as date)
		) as Date
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
    );
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV9PerformanceStatusAdult%20mapping){: .btn }
### CosdV9MenopausalStatus
Source column  `MenopausalStatus`.
Converts text to number.

* `MenopausalStatus` MENOPAUSAL STATUS (AT DIAGNOSIS) is the MENOPAUSAL STATUS of a PATIENT at PATIENT DIAGNOSIS. [MENOPAUSAL STATUS (AT DIAGNOSIS)](https://www.datadictionary.nhs.uk/data_elements/menopausal_status__at_diagnosis_.html)

```sql
with CO as (
	select
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
		  coalesce(Record ->> '$.Treatment[0].TreatmentStartDateCancer', Record ->> '$.Treatment.TreatmentStartDateCancer') as TreatmentStartDateCancer,
		coalesce(Record ->> '$.Treatment[0].Surgery.ProcedureDate', Record ->> '$.Treatment.Surgery.ProcedureDate') as ProcedureDate,
		Record ->> '$.ClinicalNurseSpecialistAndRiskFactorAssessments.MenopausalStatus.@code' as MenopausalStatus,
		Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber
	from omop_staging.cosd_staging_901
	where type = 'CO'
)
select
	distinct
		MenopausalStatus,
		NhsNumber,
		least(
			cast(DateOfPrimaryDiagnosisClinicallyAgreed as date),
			cast(TreatmentStartDateCancer as date),
			cast(ProcedureDate as date)
		) as Date
from CO o
where o.MenopausalStatus is not null
  and not (
		DateOfPrimaryDiagnosisClinicallyAgreed is null and
		TreatmentStartDateCancer is null and
		ProcedureDate is null
    );
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV9MenopausalStatus%20mapping){: .btn }
### CosdV9AsaScore
Source column  `AsaScore`.
Converts text to number.

* `AsaScore` The physical status of the PATIENT as recorded by an anaesthetist for the operative procedure. [ASA PHYSICAL STATUS CLASSIFICATION SYSTEM CODE](https://www.datadictionary.nhs.uk/data_elements/asa_physical_status_classification_system_code.html)

```sql
with CO as (
	select
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeen' as DateFirstSeen,
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeenCancerSpecialist' as DateFirstSeenCancerSpecialist,
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
		Record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage' as StageDateFinalPretreatmentStage,
		Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage' as StageDateIntegratedStage,
		coalesce(Record ->> '$.Treatment[0].TreatmentStartDateCancer', Record ->> '$.Treatment.TreatmentStartDateCancer') as TreatmentStartDateCancer,
		coalesce(Record ->> '$.Treatment[0].Surgery.ProcedureDate', Record ->> '$.Treatment.Surgery.ProcedureDate') as ProcedureDate,
		coalesce(Record ->> '$.Treatment[0].Surgery.AsaScore.@code', Record ->> '$.Treatment.Surgery.AsaScore.@code') as AsaScore,
		Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber
	from omop_staging.cosd_staging_901
	where type = 'CO'
)
select
	distinct
		AsaScore,
		NhsNumber,
		least(
			cast(DateFirstSeen as date),
			cast(DateFirstSeenCancerSpecialist as date),
			cast(DateOfPrimaryDiagnosisClinicallyAgreed as date),
			cast(StageDateFinalPretreatmentStage as date),
			cast(StageDateIntegratedStage as date),
			cast(TreatmentStartDateCancer as date),
			cast(ProcedureDate as date)
		) as Date
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
    );
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV9AsaScore%20mapping){: .btn }
### CosdV9AdultComorbidityEvaluation
Source column  `AdultComorbidityEvaluation`.
Converts text to number.

* `AdultComorbidityEvaluation` The PERSON SCORE recorded during a Cancer Care Spell, where the ASSESSMENT TOOL is 'Adult Comorbidity Evaluation - 27'. [ADULT COMORBIDITY EVALUATION - 27 SCORE](https://www.datadictionary.nhs.uk/data_elements/adult_comorbidity_evaluation_-_27_score.html)

```sql
with CO as (
	select
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeen' as DateFirstSeen,
		Record ->> '$.PrimaryPathway.ReferralAndFirstStageOfPatientPathway.DateFirstSeenCancerSpecialist' as DateFirstSeenCancerSpecialist,
		Record ->> '$.PrimaryPathway.LinkageDiagnosticDetails.DateOfPrimaryDiagnosisClinicallyAgreed' as DateOfPrimaryDiagnosisClinicallyAgreed,
		Record ->> '$.PrimaryPathway.Staging.StageDateFinalPretreatmentStage' as StageDateFinalPretreatmentStage,
		Record ->> '$.PrimaryPathway.Staging.StageDateIntegratedStage' as StageDateIntegratedStage,
		coalesce(Record ->> '$.Treatment[0].TreatmentStartDateCancer', Record ->> '$.Treatment.TreatmentStartDateCancer') as TreatmentStartDateCancer,
		coalesce(Record ->> '$.Treatment[0].Surgery.ProcedureDate', Record ->> '$.Treatment.Surgery.ProcedureDate') as ProcedureDate,
		Record ->> '$."CancerCarePlan"."AdultComorbidityEvaluation-27Score"."@code"' as AdultComorbidityEvaluation,
		Record ->> '$.LinkagePatientId.NhsNumber.@extension' as NhsNumber
	from omop_staging.cosd_staging_901
	where type = 'CO'
)
select
	distinct
		AdultComorbidityEvaluation,
		NhsNumber,
		least(
			cast(DateFirstSeen as date),
			cast(DateFirstSeenCancerSpecialist as date),
			cast(DateOfPrimaryDiagnosisClinicallyAgreed as date),
			cast(StageDateFinalPretreatmentStage as date),
			cast(StageDateIntegratedStage as date),
			cast(TreatmentStartDateCancer as date),
			cast(ProcedureDate as date)
		) as Date
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
    );
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV9AdultComorbidityEvaluation%20mapping){: .btn }
### CosdV8SmokingStatusCode
Source column  `SmokingStatusCode`.
Converts text to number.

* `SmokingStatusCode` SMOKING STATUS (CANCER) is for use in the Cancer Outcomes and Services Data Set: Core to identify if the PATIENT smokes tobacco only. [SMOKING STATUS (CANCER)](https://www.datadictionary.nhs.uk/data_elements/smoking_status__cancer_.html)

```sql
with CO as (
select 
  Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreReferralAndFirstStageOfPatientPathway.DateFirstSeen' as DateFirstSeen,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreReferralAndFirstStageOfPatientPathway.SpecialistDateFirstSeen' as SpecialistDateFirstSeen,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTNMStageGroupingDate' as IntegratedStageTNMStageGroupingDate,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTNMStageGroupingDate' as FinalPreTreatmentTNMStageGroupingDate,
coalesce(Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment[0].CancerTreatmentStartDate', Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.CancerTreatmentStartDate') as CancerTreatmentStartDate,
coalesce(Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment[0].ColorectalCoreSurgeryAndOtherProcedures.ProcedureDate', Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.ColorectalCoreSurgeryAndOtherProcedures.ProcedureDate') as ProcedureDate,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreClinicalNurseSpecialistAndRiskFactorAssessments.SmokingStatusCode.@code' as SmokingStatusCode,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber
from omop_staging.cosd_staging_81
where Type = 'CO'
)
select
      distinct
          SmokingStatusCode,
          NhsNumber,
          least(
                cast (DateFirstSeen as date),
                cast (SpecialistDateFirstSeen as date),
                cast (ClinicalDateCancerDiagnosis as date),
                cast (IntegratedStageTNMStageGroupingDate as date),
                cast (FinalPreTreatmentTNMStageGroupingDate as date),
                cast (CancerTreatmentStartDate as date),
                cast (ProcedureDate as date)
              ) as Date
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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV8SmokingStatusCode%20mapping){: .btn }
### CosdV8AdultPerformanceStatus
Source column  `AdultPerformanceStatus`.
Converts text to number.

* `AdultPerformanceStatus` A World Health Organisation classification indicating a PERSON's status relating to activity/DISABILITY. [PERFORMANCE STATUS (ADULT)](https://www.datadictionary.nhs.uk/data_elements/performance_status__adult_.html)

```sql
with CO as (
select 
  Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreReferralAndFirstStageOfPatientPathway.DateFirstSeen' as DateFirstSeen,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreReferralAndFirstStageOfPatientPathway.SpecialistDateFirstSeen' as SpecialistDateFirstSeen,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTNMStageGroupingDate' as IntegratedStageTNMStageGroupingDate,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTNMStageGroupingDate' as FinalPreTreatmentTNMStageGroupingDate,
coalesce(Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment[0].CancerTreatmentStartDate', Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.CancerTreatmentStartDate') as CancerTreatmentStartDate,
coalesce(Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment[0].ColorectalCoreSurgeryAndOtherProcedures.ProcedureDate', Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.ColorectalCoreSurgeryAndOtherProcedures.ProcedureDate') as ProcedureDate,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreDiagnosis.AdultPerformanceStatus.@code' as AdultPerformanceStatus,
Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber
from omop_staging.cosd_staging_81
where Type = 'CO'
)
select
      distinct
          AdultPerformanceStatus,
          NhsNumber,
          least(
                cast (DateFirstSeen as date),
                cast (SpecialistDateFirstSeen as date),
                cast (ClinicalDateCancerDiagnosis as date),
                cast (IntegratedStageTNMStageGroupingDate as date),
                cast (FinalPreTreatmentTNMStageGroupingDate as date),
                cast (CancerTreatmentStartDate as date),
                cast (ProcedureDate as date)
              ) as Date
from CO o
where o.AdultPerformanceStatus is not null
 and not (
		DateFirstSeen is null  and
		SpecialistDateFirstSeen is null  and
		ClinicalDateCancerDiagnosis is null  and
  	IntegratedStageTNMStageGroupingDate is null  and
		FinalPreTreatmentTNMStageGroupingDate is null and
		CancerTreatmentStartDate is null and
		ProcedureDate is null 
  )
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV8AdultPerformanceStatus%20mapping){: .btn }
### CosdV8AdultComorbidityEvaluation
Source column  `AdultComorbidityEvaluation`.
Converts text to number.

* `AdultComorbidityEvaluation` The PERSON SCORE recorded during a Cancer Care Spell, where the ASSESSMENT TOOL is 'Adult Comorbidity Evaluation - 27'. [ADULT COMORBIDITY EVALUATION - 27 SCORE](https://www.datadictionary.nhs.uk/data_elements/adult_comorbidity_evaluation_-_27_score.html)

```sql
with CO as (
	select 
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreReferralAndFirstStageOfPatientPathway.DateFirstSeen' as DateFirstSeen,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreReferralAndFirstStageOfPatientPathway.SpecialistDateFirstSeen' as SpecialistDateFirstSeen,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkageDiagnosticDetails.ClinicalDateCancerDiagnosis' as ClinicalDateCancerDiagnosis,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.IntegratedStageTNMStageGroupingDate' as IntegratedStageTNMStageGroupingDate,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreStaging.FinalPreTreatmentTNMStageGroupingDate' as FinalPreTreatmentTNMStageGroupingDate,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.CancerTreatmentStartDate' as CancerTreatmentStartDate,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreTreatment.ColorectalCoreSurgeryAndOtherProcedures.ProcedureDate' as ProcedureDate,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreCancerCarePlan.AdultComorbidityEvaluation.@code' as AdultComorbidityEvaluation,
		Record ->> '$.Colorectal.ColorectalCore.ColorectalCoreLinkagePatientId.NHSNumber.@extension' as NhsNumber
	from omop_staging.cosd_staging_81
	where Type = 'CO'
)
select
      distinct
          AdultComorbidityEvaluation,
          NhsNumber,
          least(
                cast (DateFirstSeen as date),
                cast (SpecialistDateFirstSeen as date),
                cast (ClinicalDateCancerDiagnosis as date),
                cast (IntegratedStageTNMStageGroupingDate as date),
                cast (FinalPreTreatmentTNMStageGroupingDate as date),
                cast (CancerTreatmentStartDate as date),
                cast (ProcedureDate as date)
              ) as Date
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

--tested
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_number%20field%20CosdV8AdultComorbidityEvaluation%20mapping){: .btn }
