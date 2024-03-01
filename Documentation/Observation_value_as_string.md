# `Observation` `value_as_string`
### Cds Total Previous Pregnancies Observation
* Value copied from `TotalPreviousPregnancies`

* `TotalPreviousPregnancies` PREGNANCY TOTAL PREVIOUS PREGNANCIES is the number of previous pregnancies resulting in one or more REGISTRABLE BIRTHS. [PREGNANCY TOTAL PREVIOUS PREGNANCIES](https://www.datadictionary.nhs.uk/data_elements/pregnancy_total_previous_pregnancies.html)
<details>
<summary>SQL</summary>

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
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Total%20Previous%20Pregnancies%20Observation%20mapping)
### Cds Source Of Referral For Outpatients Observation
* Value copied from `SourceOfReferralForOutpatients`

* `SourceOfReferralForOutpatients` The ORIGINAL REFERRAL REQUEST RECEIVED DATE must be recorded on any subsequent REFERRAL REQUESTS for the same health care service and should never be altered or removed, even if the Health Care Provider changes, until the specific health care service is provided for the PATIENT, or is no longer required. [ORIGINAL REFERRAL REQUEST RECEIVED DATE](https://www.datadictionary.nhs.uk/data_elements/original_referral_request_received_date.html)
<details>
<summary>SQL</summary>

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
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Source%20Of%20Referral%20For%20Outpatients%20Observation%20mapping)
### Cds Carer Support Indicator Observation
* Value copied from `CarerSupportIndicator`

* `CarerSupportIndicator` An indication of whether Carer support is available to the PATIENT at their normal residence. [CARER SUPPORT INDICATOR](https://www.datadictionary.nhs.uk/data_elements/carer_support_indicator.html)
<details>
<summary>SQL</summary>

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
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Carer%20Support%20Indicator%20Observation%20mapping)
### Cds Birth Weight Observation
* Value copied from `BirthWeight`

* `BirthWeight` BIRTH WEIGHT is the result of the Clinical Investigation which measures the Birth Weight, where the UNIT OF MEASUREMENT is Grams (g). [BIRTH WEIGHT](https://www.datadictionary.nhs.uk/data_elements/birth_weight.html)
<details>
<summary>SQL</summary>

```sql
select 
	l1.NHSNumber, 
	l1.RecordConnectionIdentifier,
	l5.HospitalProviderSpellNumber,
	coalesce(max(l8.DeliveryDate), MAX(l1.CDSActivityDate)) as observation_date, 
	max(l1.BirthWeight) as BirthWeight 
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
	l8.GestationLengthLabourOnset;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Birth%20Weight%20Observation%20mapping)
### Cds Anaesthetic Given Post Labour Delivery Observation
* Value copied from `AnaestheticGivenPostLabourDelivery`

* `AnaestheticGivenPostLabourDelivery` Records whether anaesthetic was given after Delivery, and the type used. [ANAESTHETIC GIVEN POST LABOUR OR DELIVERY CODE](https://www.datadictionary.nhs.uk/data_elements/anaesthetic_given_post_labour_or_delivery_code.html)
<details>
<summary>SQL</summary>

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
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Anaesthetic%20Given%20Post%20Labour%20Delivery%20Observation%20mapping)
### Cds Anaesthetic During Labour Delivery Observation
* Value copied from `AnaestheticDuringLabourDelivery`

* `AnaestheticDuringLabourDelivery` Records whether anaesthetic was given during Labour/ Delivery, and the type used. [ANAESTHETIC GIVEN DURING LABOUR OR DELIVERY CODE](https://www.datadictionary.nhs.uk/data_elements/anaesthetic_given_during_labour_or_delivery_code.html)
<details>
<summary>SQL</summary>

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
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Observation%20table%20value_as_string%20field%20Cds%20Anaesthetic%20During%20Labour%20Delivery%20Observation%20mapping)
