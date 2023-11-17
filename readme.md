# Person
## CNSRecord xml record
### person_source_value column
Value copied from `NhsNumber`
### OmopTargetTypeDescription column
## CdsInpatientDemographics table
### gender_concept_id column


|before|after|notes|
|------|-----|-----|
|m|123|value notes can go here|
|f|345||
|u|567||

Notes
* Overall gender notes can go here.
### person_source_value column
Value copied from `nhs_number`
### month_of_birth column
Source column  `person_birth_date`.
Selects the month of the year or null if the date is null.
### OmopTargetTypeDescription column
# Observation Period
### observation_period_start_date column
* Is the earliest date using `v_CDS_AccidentEmergency.cdw_arrival_date_time` and `v_CDS_Inpatient_ConsultantEpisode.start_date_episode` records.

```
;with PatientIdentifer as (
select
	nhs_number,
	cds_unique_identifier
from [standardised].[v_CDS_AccidentEmergency]
union
select
	d.nhs_number,
	d.cds_unique_identifier
from [standardised].[v_CDS_Inpatient_Demographics] d
	inner join [standardised].[v_CDS_Inpatient_ConsultantEpisode] ce
		on d.cds_unique_identifier = ce.cds_unique_identifier
), Episode as (
select
	(
		select 
			min(cdw_arrival_date_time) as cdw_arrival_date_time
		from [standardised].[v_CDS_AccidentEmergency] ae
		where ae.nhs_number = patientIdentifier.nhs_number
	) as EDArrival,
	(
		select 
			max(cdw_departure_date_time) as cdw_arrival_date_time
		from [standardised].[v_CDS_AccidentEmergency] ae
		where ae.nhs_number = patientIdentifier.nhs_number
	) as EDDeparture,
	(
		select 
			min(ce.start_date_episode) as start_date_episode
		from [standardised].[v_CDS_Inpatient_Demographics] id
			inner join [standardised].[v_CDS_Inpatient_ConsultantEpisode] ce
				on id.cds_unique_identifier = ce.cds_unique_identifier
		where id.nhs_number = patientIdentifier.nhs_number
	) as InpatientArrival,
	(
		select 
			max(ce.end_date_episode) as end_date_episode
		from [standardised].[v_CDS_Inpatient_Demographics] id
			inner join [standardised].[v_CDS_Inpatient_ConsultantEpisode] ce
				on id.cds_unique_identifier = ce.cds_unique_identifier
		where id.nhs_number = patientIdentifier.nhs_number
	) as InpatientDeparture,
	patientIdentifier.*
from PatientIdentifer patientIdentifier
)
select
	(select min(Date) from (values (e.EDArrival), (e.InpatientArrival)) as Dates(Date)) as Arrival,
	(select max(Date) from (values (e.EDDeparture), (e.InpatientDeparture)) as Dates(Date)) as Discharge,
	e.nhs_number
from Episode e;
```

### observation_period_end_date column
* Is the most recent date using `v_CDS_AccidentEmergency.cdw_departure_date_time` and `v_CDS_Inpatient_ConsultantEpisode.end_date_episode` records.

```
;with PatientIdentifer as (
select
	nhs_number,
	cds_unique_identifier
from [standardised].[v_CDS_AccidentEmergency]
union
select
	d.nhs_number,
	d.cds_unique_identifier
from [standardised].[v_CDS_Inpatient_Demographics] d
	inner join [standardised].[v_CDS_Inpatient_ConsultantEpisode] ce
		on d.cds_unique_identifier = ce.cds_unique_identifier
), Episode as (
select
	(
		select 
			min(cdw_arrival_date_time) as cdw_arrival_date_time
		from [standardised].[v_CDS_AccidentEmergency] ae
		where ae.nhs_number = patientIdentifier.nhs_number
	) as EDArrival,
	(
		select 
			max(cdw_departure_date_time) as cdw_arrival_date_time
		from [standardised].[v_CDS_AccidentEmergency] ae
		where ae.nhs_number = patientIdentifier.nhs_number
	) as EDDeparture,
	(
		select 
			min(ce.start_date_episode) as start_date_episode
		from [standardised].[v_CDS_Inpatient_Demographics] id
			inner join [standardised].[v_CDS_Inpatient_ConsultantEpisode] ce
				on id.cds_unique_identifier = ce.cds_unique_identifier
		where id.nhs_number = patientIdentifier.nhs_number
	) as InpatientArrival,
	(
		select 
			max(ce.end_date_episode) as end_date_episode
		from [standardised].[v_CDS_Inpatient_Demographics] id
			inner join [standardised].[v_CDS_Inpatient_ConsultantEpisode] ce
				on id.cds_unique_identifier = ce.cds_unique_identifier
		where id.nhs_number = patientIdentifier.nhs_number
	) as InpatientDeparture,
	patientIdentifier.*
from PatientIdentifer patientIdentifier
)
select
	(select min(Date) from (values (e.EDArrival), (e.InpatientArrival)) as Dates(Date)) as Arrival,
	(select max(Date) from (values (e.EDDeparture), (e.InpatientDeparture)) as Dates(Date)) as Discharge,
	e.nhs_number
from Episode e;
```

