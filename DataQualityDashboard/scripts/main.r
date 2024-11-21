# fill out the connection details -----------------------------------------------------------------------
connectionDetails <- DatabaseConnector::createConnectionDetails(
dbms = "sql server",
user = Sys.getenv("USER"),
password = Sys.getenv("PASSWORD"),
server = Sys.getenv("SERVER"),
port = Sys.getenv("PORT"), 
extraSettings = Sys.getenv("SETTINGS"),
pathToDriver = Sys.getenv("DRIVER")
)

# Schema and database details
cdmDatabaseSchema <- "cdm"
resultsDatabaseSchema <- "results"
cdmSourceName <- "cdm source"
cdmVersion <- "5.4"

# Set the number of threads for parallel processing
numThreads <- 1

# Specify whether to execute queries or just generate SQL scripts
sqlOnly <- FALSE
sqlOnlyIncrementalInsert <- FALSE
sqlOnlyUnionCount <- 1  # Adjust for performance as needed

# Results output configuration
outputFolder <- "output"
outputFile <- "results.json"

# Logging configuration
verboseMode <- TRUE

# Write results to SQL table and/or CSV file
writeToTable <- TRUE
writeToCsv <- FALSE
csvFile <- ""

# List of DQ check levels and checks to run
checkLevels <- c("TABLE", "FIELD", "CONCEPT")
checkNames <- c()

# Tables to exclude from checks
tablesToExclude <- c(
  "CONCEPT",
  "VOCABULARY",
  "CONCEPT_ANCESTOR",
  "CONCEPT_RELATIONSHIP",
  "CONCEPT_CLASS",
  "CONCEPT_SYNONYM",
  "RELATIONSHIP",
  "DOMAIN"
)

# Execute the data quality checks
DataQualityDashboard::executeDqChecks(
  connectionDetails = connectionDetails, 
  cdmDatabaseSchema = cdmDatabaseSchema, 
  resultsDatabaseSchema = resultsDatabaseSchema,
  cdmSourceName = cdmSourceName, 
  cdmVersion = cdmVersion,
  numThreads = numThreads,
  sqlOnly = sqlOnly, 
  sqlOnlyUnionCount = sqlOnlyUnionCount,
  sqlOnlyIncrementalInsert = sqlOnlyIncrementalInsert,
  outputFolder = outputFolder,
  outputFile = outputFile,
  verboseMode = verboseMode,
  writeToTable = writeToTable,
  writeToCsv = writeToCsv,
  csvFile = csvFile,
  checkLevels = checkLevels,
  tablesToExclude = tablesToExclude,
  checkNames = checkNames
)
