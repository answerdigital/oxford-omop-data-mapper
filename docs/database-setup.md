---
layout: default
title: Database Setup
parent: Quick Start Guide
---

# Database setup

The omop mapper tool requires a the latest omop database along with some additional tables and stored procedures.

The database needs to be setup in two steps because the Athena code list is too large to add to this repository. There is also an element of choice for which athana vocabularies are required. It is difficult to add more vocabularies retrospectively.

The process to setup the database has two steps

1. [Patch the database](#database-patching) - We run the database patching tool to bring the database to the latest version.
2. [Vocabulary Import](#vocabulary-import) - Add the athena codes.

## Database Patching

We use Flyway to patch our database. This script should be run if new database patches are issued, or repeatable migrations are added/eddited (eg new stored procedures).

1. Clone the repository `git clone https://github.com/answerdigital/oxford-omop-data-mapper.git`
2. Patch the database using the following guide [https://github.com/answerdigital/oxford-omop-data-mapper/tree/main/Database/Migrations](https://github.com/answerdigital/oxford-omop-data-mapper/tree/main/Database/Migrations)

## Vocabulary Import

1. Create an https://athena.ohdsi.org/ account and download at least the following vocabularies.
> | Id |  CDM | Code | Name |
> |-------|-----------|-------------------|-----------------------|
> |154	|	CDM 5	| NHS Ethnic Category	|NHS Ethnic Category |
> |148	|	CDM 5	| OMOP Invest Drug	| OMOP Investigational Drugs|
> |142	|	CDM 5	| OPS	| Operations and Procedures Classification (OPS)|
> |141	|   CDM 5   | Cancer Modifier	| Diagnostic Modifiers of Cancer (OMOP) |
> |90	    |   CDM 5   |ICDO3 |	International Classification of Diseases for Oncology, Third Edition (WHO) |
> |82       |   CDM 5   | RxNorm Extension | OMOP RxNorm Extension |
> |75		|	CDM 5	| dm+d	| Dictionary of Medicines and Devices (NHS)|
> |71	| CDM 5 | ABMS	 | Provider Specialty (American Board of Medical Specialties)	 |
> |57	| CDM 5 | HES Specialty	| Hospital Episode Statistics Specialty (NHS) |
> |55		|	CDM 5	| OPCS4| 	OPCS Classification of Interventions and Procedures version 4 (NHS)|
> |48       |    CDM 5  | Medicare Specialty | Medicare provider/supplier specialty codes (CMS) |
> |47     |   CDM 5   | NUCC  | 	National Uniform Claim Committee Health Care Provider Taxonomy Code Set (NUCC) |
> |44		|	CDM 5	| Ethnicity |	OMOP Ethnicity|
> |34		|	CDM 5	| ICD10	| International Classification of Diseases, Tenth Revision (WHO)|
> |14     |   CDM 5   | CMS Place of Service | CMS Place of Service |
> |13		|	CDM 5	| Race	| Race and Ethnicity Code Set (USBC)|
> |12		|	CDM 5	| Gender|	OMOP Gender|
> |8        |  CDM 5   | RxNorm | RxNorm (NLM) |
> |6	    | CDM 5     |  LOINC |	Logical Observation Identifiers Names and Codes (Regenstrief Institute) |
> |3	    |	CDM 5	| ICD9Proc |	International Classification of Diseases, Ninth Revision, Clinical Modification, Volume 3 (NCHS) |
> |2      |	CDM 5	| ICD9CM	| International Classification of Diseases, Ninth Revision, Clinical Modification, Volume 1 and 2 (NCHS) |
> |1		|	CDM 5	| SNOMED	|Systematic Nomenclature of Medicine - Clinical Terms (IHTSDO)|
2. Unpack the archive and import the files using the `import-athena.sql` script.
3. Run the following scripts

```
Database/Setup/V1 Oxford Anaesthtic Concepts.sql
Database/Setup/V2 Oxford Concepts.sql
Database/Setup/V3 Oxford Concepts.sql
```