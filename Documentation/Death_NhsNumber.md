# `Death` `NhsNumber`
### CDS Death
* Value copied from `nhs_number`
* `nhs_number` The patient's NHS Number.
<details>
<summary>SQL</summary>

```sql
select
	distinct	
		l1.NHSNumber as nhs_number,
		l5.DischargeDateHospitalProviderSpell as death_date
from omop_staging.cds_line01 l1
	inner join omop_staging.cds_line05 l5
		on l1.MessageId = l5.MessageId
where l1.NHSNumber is not null
	and 
	(
		l5.DischargeMethod = '4' -- "Patient died"
		or 
		(
			l5.DischargeDestinationCode = '79' and -- Not applicable - PATIENT died or stillbirth
			l5.DischargeMethod != '5' -- not stillbirth
		)
	);
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Death%20table%20NhsNumber%20field%20CDS%20Death%20mapping)