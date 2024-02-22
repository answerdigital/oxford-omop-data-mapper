# Database setup

The omop mapper tool requires a the latest omop database along with some additional tables and stored procedures.

The database needs to be setup in two steps because the Athena code list is too large to add to this repository. There is also an element of choice for which athana vocabularies are required. It is difficult to add more vocabularies retrospectively.

The process to setup the database has two steps
1) [Initial setup](#initial-setup) - Where we add the official OMOP schema to an empty database. Then add the athena codes.
2) [Patch the database](#database-patching) - We run the database patching tool to bring the database to the latest version.

## Initial setup

1) Run the following scripts on an empty database

```
Setup/V01__OMOPCDM_sql_server_5.4_ddl.sql
Setup/V02__OMOPCDM_sql_server_5.4_primary_keys.sql
Setup/V03__OMOPCDM_sql_server_5.4_indices.sql
Setup/V04__OMOPCDM_sql_server_5.4_constraints.sql
```

2) Create an https://athena.ohdsi.org/ account and download at least the following vocabularies. [You may be alternatively be able to use this link](https://athena.ohdsi.org/api/v1/vocabularies/zip/e9b7c119-2e16-413d-a8d3-64e17c5e77d2).

| Id |  CDM | Code | Name |
|-------|-----------|-------------------|-----------------------|
|154	|	CDM 5	| NHS Ethnic Category	|NHS Ethnic Category |
|148	|	CDM 5	| OMOP Invest Drug	| OMOP Investigational Drugs|
|142	|	CDM 5	| OPS	| Operations and Procedures Classification (OPS)|
|90	    |   CDM 5   |ICDO3 |	International Classification of Diseases for Oncology, Third Edition (WHO) |
|75		|	CDM 5	| dm+d	| Dictionary of Medicines and Devices (NHS)|
|55		|	CDM 5	| OPCS4| 	OPCS Classification of Interventions and Procedures version 4 (NHS)|
|47     |   CDM 5   | NUCC  | 	National Uniform Claim Committee Health Care Provider Taxonomy Code Set (NUCC) |
|44		|	CDM 5	| Ethnicity |	OMOP Ethnicity|
|34		|	CDM 5	| ICD10	| International Classification of Diseases, Tenth Revision (WHO)|
|14     |   CDM 5   | CMS Place of Service | CMS Place of Service |
|13		|	CDM 5	| Race	| Race and Ethnicity Code Set (USBC)|
|12		|	CDM 5	| Gender|	OMOP Gender|
|3	    |	CDM 5	| ICD9Proc |	International Classification of Diseases, Ninth Revision, Clinical Modification, Volume 3 (NCHS) |
|2      |	CDM 5	| ICD9CM	| International Classification of Diseases, Ninth Revision, Clinical Modification, Volume 1 and 2 (NCHS) |
|1		|	CDM 5	| SNOMED	|Systematic Nomenclature of Medicine - Clinical Terms (IHTSDO)|

3) Unpack the archive and import the files using the `import-athena.sql` script.

## Database Patching

We use Flyway to patch our database. This script should be run if new database patches are issued, or repeatable migrations are added/eddited (eg new stored procedures).

1) Alter the `Migrations/migrate.ps1` script to configure your database address, database name, username and password.
2) Run `Migrations/migrate.ps1`. This script will patch the database using [Flyway](https://flywaydb.org/) to the latest version. It can be run many times.