---
layout: default
title: Configuration
parent: User Guide
---

# Configuration

This application can be configured by altering the `appsettings.json` file.

An example configuration

```
{
    "ConnectionString": "Server=host.docker.internal;Database=yourDatabase;User Id=user;Password=password;Encrypt=false",
    "BatchSize": 200000
}
```

| Property         | Remarks                                                                                                                                    |
|------------------|--------------------------------------------------------------------------------------------------------------------------------------------|
| ConnectionString | This ConnectionString is used to specify the OMOP database where the data will be staged into and transformed. [More ConnectionString examples](https://www.connectionstrings.com/sql-server/)                             |
| BatchSize        | The maximum number of rows that can be inserted by any operation. Increasing this value can increase the speed of the transform operation. |