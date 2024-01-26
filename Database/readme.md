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

2) Create an https://athena.ohdsi.org/ account and download at least the following vocabularies. [You may be alternatively be able to use this link](https://athena.ohdsi.org/api/v1/vocabularies/zip/a02908aa-757d-4f38-aea3-e4a70f6c5f00).

| Id |  CDM | Code | Name |
|-------|-----------|-------------------|-----------------------|
|154	|	CDM 5	| NHS Ethnic Category	|NHS Ethnic Category |
|148	|	CDM 5	| OMOP Invest Drug	| OMOP Investigational Drugs|
|142	|	CDM 5	| OPS	| Operations and Procedures Classification (OPS)|
|75		|	CDM 5	| dm+d	| Dictionary of Medicines and Devices (NHS)|
|55		|	CDM 5	| OPCS4| 	OPCS Classification of Interventions and Procedures version 4 (NHS)|
|44		|	CDM 5	| Ethnicity |	OMOP Ethnicity|
|34		|	CDM 5	| ICD10	| International Classification of Diseases, Tenth Revision (WHO)|
|13		|	CDM 5	| Race	| Race and Ethnicity Code Set (USBC)|
|12		|	CDM 5	| Gender|	OMOP Gender|
|1		|	CDM 5	| SNOMED	|Systematic Nomenclature of Medicine - Clinical Terms (IHTSDO)|

3) Unpack the archive and import the files using the `import-athena.sql` script.

## Database Patching

We use Flyway to patch our database. This script should be run if new database patches are issued, or repeatable migrations are added/eddited (eg new stored procedures).

1) Alter the `Migrations/migrate.ps1` script to configure your database address, database name, username and password.
2) Run `Migrations/migrate.ps1`. This script will patch the database using [Flyway](https://flywaydb.org/) to the latest version. It can be run many times.