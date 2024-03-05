---
layout: default
title: Data Provenance
---

# Data Provenance

The tool supports recording to a field level the origin of a OMOP record.

This data is held in the `provenance` table that is defined by the following columns.

| Column              | Explanation |
|---------------------|-------------|
| `table_type_id`    |  Table type, eg `21` for Location or `31` for Person.           |
| `table_key`   |  Key of the reference table, eg `123` from the `location_id` table.           |
| `column_name`   | Name of the tracked column, eg `address_1`.            |
| `data_source`   |   Explanation of the data origin, eg `CDS`          |

## Example usage - Persons report

The following query reports the breakdown of the data sources for every `person` in the person table. 

```
select
	data_source,
	count (*)
from provenance
where table_type_id = 31 -- person
	and column_name = 'person_source_value'
group by data_source
```

## Example usage - Reveal data source for person 123

The following query reports the data sources for each field in the `person` table for person id `123`.

```
select *
from provenance
where table_type_id = 31 -- person
	and table_key = 123;
```