# `Location` `zip`
### SACT
Source column  `Patient_Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
### COSD Demographics
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
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

### CDS Structured Address
Source column  `Postcode`.
Uppercase the postcode then insert the space in the correct location, if needed.
* `Postcode` Postcode
<details>
<summary>SQL</summary>

```sql
select
	PatientUnstructuredAddress,
	Postcode
from omop_staging.cds_line01
where PatientAddressType = '01'
	and Postcode is not null;
	
```
</details>

