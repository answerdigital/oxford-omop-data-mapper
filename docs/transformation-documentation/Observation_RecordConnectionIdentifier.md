---
layout: default
title: RecordConnectionIdentifier
parent: Observation
grand_parent: Transformation Documentation
has_toc: false
---
# RecordConnectionIdentifier
### SUS OP Source Of Referral For Outpatients
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

```sql
select
	NHSNumber,
	GeneratedRecordIdentifier,
	AppointmentDate,
	AppointmentTime,
	ReferrerCode   -- Referrer code is the code of the person making the referral request
from [omop_staging].[sus_OP]
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20OP%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS Outpatient Carer Support Indicator Observation
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20Outpatient%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### SUS Inpatient Total Previous Pregnancies Observation
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20Inpatient%20Total%20Previous%20Pregnancies%20Observation%20mapping){: .btn }
### SUS APC Source Of Referral For Outpatients
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20APC%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS Inpatient NumberofBabies Observation
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20Inpatient%20NumberofBabies%20Observation%20mapping){: .btn }
### SUS Inpatient Gestation Length Labour Onset Observation
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20Inpatient%20Gestation%20Length%20Labour%20Onset%20Observation%20mapping){: .btn }
### SUS Inpatient Carer Support Indicator Observation
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20Inpatient%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### Sus APC Birth Weight Observation
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Sus%20APC%20Birth%20Weight%20Observation%20mapping){: .btn }
### SUS APC Anaesthetic Given Post Labour Delivery Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20APC%20Anaesthetic%20Given%20Post%20Labour%20Delivery%20Observation%20mapping){: .btn }
### SUS APC Anaesthetic During Labour Delivery Observation
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20APC%20Anaesthetic%20During%20Labour%20Delivery%20Observation%20mapping){: .btn }
### SUS AE Source Of Referral For Outpatients
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20AE%20Source%20Of%20Referral%20For%20Outpatients%20mapping){: .btn }
### SUS AE Diabetic Patient
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20AE%20Diabetic%20Patient%20mapping){: .btn }
### SUS AE Diabetic Patient
* Value copied from `GeneratedRecordIdentifier`

* `GeneratedRecordIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20SUS%20AE%20Diabetic%20Patient%20mapping){: .btn }
### Cds Total Previous Pregnancies Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20Total%20Previous%20Pregnancies%20Observation%20mapping){: .btn }
### Cds Source Of Referral For Outpatients Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20Source%20Of%20Referral%20For%20Outpatients%20Observation%20mapping){: .btn }
### Cds Person Weight Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

```sql
select 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	coalesce(max(l7.ActivityDateCriticalCare), MAX(l1.CDSActivityDate)) as observation_date, 
	l7.PersonWeight
from [omop_staging].[cds_line01] l1																			
	inner join [omop_staging].[cds_line07] l7													
		on l1.MessageId = l7.MessageId
	left outer join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where l7.PersonWeight is not null 
	and l1.NHSNumber is not null 				
group by 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	l7.ActivityDateCriticalCare, 
	l7.PersonWeight;		
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20Person%20Weight%20Observation%20mapping){: .btn }
### Cds NumberofBabies Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

```sql
select 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	coalesce(max(l8.DeliveryDate), max(l1.CDSActivityDate)) as observation_date, 
	l8.NumberofBabies 																			
from omop_staging.cds_line01 l1																			
	inner join omop_staging.cds_line08 l8														
		on l1.MessageId = l8.MessageId
	left outer join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where 
	l8.NumberofBabies is not null 
	and l1.NHSNumber is not null  
	and (l1.CdsRecordType = '140' or l1.CdsRecordType = '120')																			
group by 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier, 
	l5.HospitalProviderSpellNumber,
	l8.DeliveryDate, 
	l8.NumberofBabies;	
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20NumberofBabies%20Observation%20mapping){: .btn }
### Cds Gestation Length Labour Onset Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

```sql
select 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	coalesce(max(l8.DeliveryDate), MAX(l1.CDSActivityDate)) as observation_date, 
	l8.GestationLengthLabourOnset 
from omop_staging.cds_line01 l1																			
	inner join omop_staging.cds_line08 l8														
		on l1.MessageId = l8.MessageId
	left outer join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where l8.GestationLengthLabourOnset is not null 
	and l1.NHSNumber is not null 
	and (l1.CdsRecordType = '140' or l1.CdsRecordType = '120')		
group by 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier, 
	l5.HospitalProviderSpellNumber,
	l8.DeliveryDate, 
	l8.GestationLengthLabourOnset;
	
```


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20Gestation%20Length%20Labour%20Onset%20Observation%20mapping){: .btn }
### Cds Carer Support Indicator Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20Carer%20Support%20Indicator%20Observation%20mapping){: .btn }
### Cds Birth Weight Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20Birth%20Weight%20Observation%20mapping){: .btn }
### Cds Anaesthetic Given Post Labour Delivery Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20Anaesthetic%20Given%20Post%20Labour%20Delivery%20Observation%20mapping){: .btn }
### Cds Anaesthetic During Labour Delivery Observation
* Value copied from `RecordConnectionIdentifier`

* `RecordConnectionIdentifier` CDS specific identifier that binds multiple CDS messages together. [CDS RECORD IDENTIFIER](https://www.datadictionary.nhs.uk/data_elements/cds_record_identifier.html)

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


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20RecordConnectionIdentifier%20field%20Cds%20Anaesthetic%20During%20Labour%20Delivery%20Observation%20mapping){: .btn }
