# Flyway Database Patching Tool

## Overview
This PowerShell script (`migrate.ps1`) automates database migrations using Flyway in a Docker container. It loads environment variables from a `.env` file and executes Flyway migrations against a SQL Server database.

## Prerequisites
- Docker Desktop
- SQL Server installed and running locally
- A `.env` file in the current directory
- SQL migration files in the `./sql` directory
- Flyway configuration files in the `./conf` directory

## Initial Setup

### 1. SQL Server Configuration
1. Install SQL Server if not already installed
2. [Enable Remote TCP/IP Connections](https://legacysupport.timextender.com/hc/en-us/articles/360042584612-Enable-Remote-Connections-to-SQL-Server-using-IP-address) by following these steps:
   - Open SQL Server Configuration Manager
   - Enable TCP/IP protocol
   - Configure port settings
   - Restart SQL Server service

### 2. Database Setup
1. Open SQL Server Management Studio (SSMS)
2. Create a new database named `OMOP`
3. Create a server login account

### 3. Environment Configuration
Create a `.env` file in the Migrations folder with the following structure:
```
dbname="omop"
user="user"
pass="password"
```

⚠️ **Note:** The `.env` file is excluded from Git via `.gitignore` to protect sensitive credentials.

## Directory Structure
```
├── migrate.ps1
├── .env
├── sql/
│   └── [your migration files]
└── conf/
    └── [flyway configuration files]
```

## How It Works
1. Loads environment variables from `.env`
2. Runs a Flyway Docker container
3. Mounts local `sql` and `conf` directories
4. Connects to SQL Server using `host.docker.internal` (Docker's way of accessing localhost)
5. Executes pending migrations

## Usage
Run the migration script from PowerShell:

```
cd oxford-omop-data-mapper\Database\Migrations
```

```powershell
powershell .\migrate.ps1
```

## Troubleshooting

### Docker Connection Issues
- Ensure Docker Desktop is running
- Keep `host.docker.internal` in the connection string as is - this is Docker's way of referring to your local machine
- Verify SQL Server is accessible on port 1433

### SQL Server Issues
1. Verify SQL Server is running:
   - Open Services (services.msc)
   - Look for "SQL Server (MSSQLSERVER)" or your named instance
   - Ensure its status is "Running"

2. Check TCP/IP Configuration:
   - Confirm you followed the [remote connections guide](https://legacysupport.timextender.com/hc/en-us/articles/360042584612-Enable-Remote-Connections-to-SQL-Server-using-IP-address)
   - Verify TCP/IP is enabled in SQL Server Configuration Manager
   - Ensure port 1433 is open and configured

3. Database Access:
   - Confirm the OMOP database exists in SSMS
   - Verify your user account has appropriate permissions
   - Test the connection using SSMS with the same credentials

### Common Issues
- Verify your `.env` file contains the correct credentials
- Ensure the SQL Server account has appropriate permissions on the OMOP database
