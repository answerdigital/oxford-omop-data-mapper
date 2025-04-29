---
layout: default
title: Commands
parent: User Guide
nav_order: 2
has_children: false
---

# Navigation Structure
{: .no_toc }

<details open markdown="block">
  <summary>
    Table of contents
  </summary>
  {: .text-delta }
- TOC
{:toc}
</details>

## Docs command

Generates transformation documentation and records it to a specified directory.

### Example

Generates transformation documentation to the current directory.

```
omop docs .
```

### Remarks

The documentation comprises of
* Markdown documents
* SVG diagrams
* Machine readable JSON transformation explanations

Each OMOP field has a document that describes how each field is mapped from all known data sources. This could be as simple as a copy, or include complex transformations or lookups. If a transformation includes a SQL query, this is included with an explanation of the query output.

#### JSON example

```
{
  "omopTable": "Observation",
  "origin": "SUS-APC",
  "omopColumns": [
    {
      "name": "nhs_number",
      "operation_description": "Value copied from `NHSNumber`",
      "dataSource": [
        {
          "name": "NHSNumber",
          "description": "Patient NHS Number",
          "origins": [
            {
              "origin": "NHS NUMBER",
              "url": "https://www.datadictionary.nhs.uk/data_elements/nhs_number.html"
            }
          ]
        }
      ],
      "query": "\nselect \n\tl1.NHSNumber, \n\tmax(l1.CDSActivityDate) as CDSActivityDate, \n\tl1.CarerSupportIndicator,\n\tl5.HospitalProviderSpellNumber,\n\tl1.RecordConnectionIdentifier\nfrom omop_staging.cds_line01 l1\n\tleft outer join omop_staging.cds_line05 l5\n\t\ton l1.MessageId = l5.MessageId\nwhere NHSNumber is not null\n\tand CarerSupportIndicator is not null\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t\ngroup by \n\tl1.NHSNumber, \n\tl1.CarerSupportIndicator,\n\tl5.HospitalProviderSpellNumber,\n\tl1.RecordConnectionIdentifier;\n\t",
      "lookup_table_markdown": null
    }
  ]
}
```

---

## Stage command

Loads staging data from a filesystem.

### Example

#### Stage a COSD file

```
omop stage load --type cosd "Cancer_Reporting\COSD\April 2022 Submission.zip"
```

#### Stage a SACT file

```
omop stage load --type sact "SACT_v3-20200101-20200131.csv"
```

#### Stage a RTDS file

```
omop stage load --type rtds "Rtds.zip"
```

#### Stage a CDS file

```
omop stage load --type cds BNC62_1_20231020232835673
```

### Remarks

Supported data formats include
* CDS - EMIS Infoflex 6.2 fixed width multiline text format
* COSD - v8-1 and v9-0-1 xml formats
* [SACT - v3.0](https://digital.nhs.uk/data-and-information/information-standards/information-standards-and-data-collections-including-extractions/publications-and-notifications/standards-and-collections/dcb1533-systemic-anti-cancer-therapy-data-set)
* RTDS

Staged data is appended to existing staging tables. If the staging tables need to be cleared run the [`clear staging command`](#clear-staging-command) first.

---

## Clear staging command

Clears the staging tables.

### Example

```
omop stage clear --type cds
```

### Remarks

Supported type flags are `cds`, `rtds`, `cosd` and `sact`.

---

## Transform command

Transforms and inserts the staged data and its origin to the OMOP database.

### Example 

```
omop transform --type cds
```

### Remarks

Supported type flags are `cds`, `rtds`, `cosd` and `sact`.

The OMOP data provenance is recorded as each data set is transformed. [See data provenance.]({% link docs/data-provenance.md %}#data-provenance)

---

## Finalise command

Finalises the OMOP dataset by
* Pruning incomplete OMOP records
* Rebuilding era tables (`condition_era` and `drug_era`)

### Example

```
omop finalise
```

### Remarks

Removes any Person records that either
* Have no gender
* Have no ethnicity

Removes any locations that are not used.