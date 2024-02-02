# `Location` `zip`
### SACT
Source column  `Patient_Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20mapping)
### Rtds PAS Location
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
* `Postcode` The patient's Postcode.
<details>
<summary>SQL</summary>

```sql
select
	distinct
		p.FirstOfNHSNUMBER as NhsNumber,
		p.FirstOfPOSTCODE as Postcode
from omop_staging.RTDS_PASDATA p
where p.FirstOfPOSTCODE is not null
	and p.FirstOfNHSNUMBER is not null;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20mapping)
### COSD Demographics
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.

[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20mapping)
### CDS Structured Address
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
* `Postcode` Postcode
<details>
<summary>SQL</summary>

```sql
select
	distinct
		PatientUnstructuredAddress,
		Postcode,
		NHSNumber
from omop_staging.cds_line01
where PatientAddressType = '01'
	and Postcode is not null;
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20mapping)
### CDS UnstructuredAddress
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
* `Postcode` Postcode
<details>
<summary>SQL</summary>

```sql
select
	PatientAddressStructured1,
	PatientAddressStructured2,
	PatientAddressStructured3,
	PatientAddressStructured4,
	PatientAddressStructured5,
	Postcode
from omop_staging.cds_line01
where PatientAddressType = '02'
	and 
	(
		PatientAddressStructured1 is not null or 
		PatientAddressStructured2 is not null or 
		PatientAddressStructured3 is not null or 
		PatientAddressStructured4 is not null or 
		PatientAddressStructured5 is not null or 
		Postcode is not null
	);
	
```
</details>


[Comment or raise an issue for this mapping.](https://github.com/answerdigital/oxford-omop-data-mapper/issues/new?title=OMOP%20Location%20table%20zip%20field%20mapping)
