# `VisitDetail` `HospitalProviderSpellNumber`
### CDS VisitDetails
* Value copied from `HospitalProviderSpellNumber`
* `HospitalProviderSpellNumber` CDS specific hospital spell number that binds many episodes together.
<details>
<summary>SQL</summary>

```sql
select  
	distinct
    
		l1.NHSNumber,
		l5.HospitalProviderSpellNumber,

		case 
			when l5.AdmissionMethodCode in ('21','24') and l5.PatientClassification = 1 then 262 
			when l5.AdmissionMethodCode in ('21','24') then 9203
			when l5.PatientClassification in (1) then 9201
			when l4.LocationClass in ('02') then 581476
			else 9202
		end as VisitOccurrenceConceptId,    -- ""visit_concept_id""

		l1.RecordConnectionIdentifier,

		coalesce(l5.EpisodeStartDate, l5.StartDateHospitalProviderSpell, l1.CDSActivityDate) as VisitStartDate,  -- visit_start_date
		coalesce(l5.EpisodeStartTime, l5.StartTimeHospitalProviderSpell, '000000') as VisitStartTime,  -- visit_start_time

		coalesce(l5.EpisodeEndDate, l5.DischargeDateHospitalProviderSpell, l1.CDSActivityDate) as VisitEndDate,

		coalesce(l5.EpisodeEndTime, l5.DischargeTimeHospitalProviderSpell, '000000') as VisitEndTime,

		case 
			when l5.EpisodeEndDate is null and l5.DischargeDateHospitalProviderSpell is null then 32220
			else 32818 
		end as VisitTypeConceptId,
		,
		l5.SourceofAdmissionCode,
		l5.DischargeDestinationCode
from [omop_staging].[cds_line01] l1
	left join [omop_staging].[cds_line04] l4 
		on l1.MessageId = l4.MessageId -- Location Details
	left join [omop_staging].[cds_line05] l5 
		on l1.MessageId = l5.MessageId -- Hospital Provider Spell
	inner join dbo.Code c 
		on l1.ActivityTreatmentFunctionCode = c.Code
where l1.CDSUpdateType = 9   -- New/Modification     (1 = Delete)
	and l1.NHSNumber is not null
	and c.CodeTypeId = 2 -- activity_treatment_function_code
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20VisitDetail%20table%20HospitalProviderSpellNumber%20field%20CDS%20VisitDetails%20mapping)
