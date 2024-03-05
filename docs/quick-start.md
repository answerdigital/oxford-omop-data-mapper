---
layout: default
title: Quick Start Guide
nav_order: 2
---

# Quick Start Guide

In this guide we will clone and build the product, and then use it to transform a COSD 9.0.1 archive to OMOP.

## Prerequisites
* Git [Install guide](https://git-scm.com/book/en/v2/Getting-Started-Installing-Git)
* .NET 8 [.NET download page](https://dotnet.microsoft.com/en-us/download)

## Build

Clone the repository.

```
git clone https://github.com/answerdigital/oxford-omop-data-mapper.git
```

Build the product targeting the windows-x64 platform to the `publish` directory. Include .NET runtime with the product. (Avoding the need to install the runtime on the location where the tool is used) 

### Build for Windows x64

```
dotnet publish -r win-x64 --self-contained true -o ./publish
```

### Build for other platforms

```
dotnet publish -r PLATFORMRID --self-contained true -o ./publish
```

Replace `PLATFORMRID` with a platform RID, e.g `linux-x64`. [See full list of supported RIDs](https://learn.microsoft.com/en-us/dotnet/core/rid-catalog#known-rids)

## Configure the tool

Update the connection string in `appsettings.json` to point to your OMOP database. [See ConnectionString examples](https://www.connectionstrings.com/sql-server/).

## Transform a COSD 9.0.1 archive.

Stage the COSD submission file `December 2020 Submission.zip`.

```
.\omop.exe stage --type cosd load "COSD\December 2020 Submission.zip"
```

Output

```
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD data.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Code\oxford-omop-transformer\publish
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Found 14 entries.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(BA)_RTH_2020-12-01_2020-12-31_2021-02-05T09_54_21.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(BR)_RTH_2020-12-01_2020-12-31_2021-02-05T10_03_55.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(CO)_RTH_2020-12-01_2020-12-31_2021-02-05T10_08_09.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(CT)_RTH_2020-12-01_2020-12-31_2021-02-05T10_13_49.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(GY)_RTH_2020-12-01_2020-12-31_2021-02-05T10_19_30.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(HA)_RTH_2020-12-01_2020-12-31_2021-02-05T10_23_37.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(HN)_RTH_2020-12-01_2020-12-31_2021-02-05T10_25_33.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(LU)_RTH_2020-12-01_2020-12-31_2021-02-05T10_27_26.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(LV)_RTH_2020-12-01_2020-12-31_2021-02-05T10_30_19.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(SA)_RTH_2020-12-01_2020-12-31_2021-02-05T10_32_06.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(SK)_RTH_2020-12-01_2020-12-31_2021-02-05T10_33_11.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(UG)_RTH_2020-12-01_2020-12-31_2021-02-05T10_36_24.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(UR)_RTH_2020-12-01_2020-12-31_2021-02-05T10_38_39.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging COSD_INFOFLEX(CR)_RTH_2020-12-01_2020-12-31_2021-02-05T10_10_53.xml.
info: OmopTransformer.COSD.Staging.CosdStaging[0]
      Staging complete.
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...
```

Transform the staged data.

```
.\omop.exe transform --type cosd
```

Output

```
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: OmopTransformer.Transformation.IRecordTransformer[0]
      Transforming COSD Person.
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Code\oxford-omop-transformer\publish
info: OmopTransformer.RecordProvider[0]
      Querying OmopTransformer.COSD.Demographics.CosdDemographics
info: OmopTransformer.Transformation.IRecordTransformer[0]
      Extracted 3849 COSD Person in 1 seconds.
info: OmopTransformer.Omop.Person.PersonRecorder[0]
      Recording 3849 persons.
info: OmopTransformer.Omop.Person.PersonRecorder[0]
      Batch 1 of 1 completed in 2717ms.
info: OmopTransformer.Omop.Person.PersonRecorder[0]
      procedure occurrences completed in 2.7180059 seconds.
info: OmopTransformer.Transformation.IRecordTransformer[0]
      Transformation took 2922ms.
info: OmopTransformer.Transformation.IRecordTransformer[0]
      Transforming COSD Location.
info: OmopTransformer.RecordProvider[0]
      Querying OmopTransformer.COSD.Demographics.CosdDemographics
info: OmopTransformer.Transformation.IRecordTransformer[0]
      Extracted 3849 COSD Location in 1 seconds.
info: OmopTransformer.Omop.Location.LocationRecorder[0]
      Recording 3849 locations.
info: OmopTransformer.Omop.Location.LocationRecorder[0]
      Batch 1 of 1 completed in 690ms.
info: OmopTransformer.Omop.Location.LocationRecorder[0]
      locations completed in 0.6902594 seconds.
info: OmopTransformer.Transformation.IRecordTransformer[0]
      Transformation took 869ms.
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...
```

Then clear the staging tables.

```
.\omop.exe stage clear --type cosd
```

Output 

```
info: Microsoft.Hosting.Lifetime[0]
      Application started. Press Ctrl+C to shut down.
info: Microsoft.Hosting.Lifetime[0]
      Hosting environment: Production
info: Microsoft.Hosting.Lifetime[0]
      Content root path: C:\Code\oxford-omop-transformer\publish
info: OmopTransformer.COSD.Staging.CosdStagingSchema[0]
      Clearing staging tables.
info: Microsoft.Hosting.Lifetime[0]
      Application is shutting down...
```

View the transformed patients and their locations.

```sql
select *
from cdm.person p
	inner join cdm.location l
		on p.location_id = l.location_id;
```