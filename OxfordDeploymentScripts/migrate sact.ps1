# Define the base directory
$baseDirectory = "D:\Cancer_Reporting\SACT\SACT V.3"

# Define the years
$years = @("2019", "2020", "2022", "2023")

# Loop through each year
foreach ($year in $years) {
    # Construct the path to the year directory
    $yearDirectory = Join-Path -Path $baseDirectory -ChildPath $year

    # Check if the directory exists
    if (Test-Path $yearDirectory) {
        # Get all CSV files in the directory
        $csvFiles = Get-ChildItem -Path $yearDirectory -Filter "*.csv"

        # Loop through each CSV file
        foreach ($csvFile in $csvFiles) {
            # Your processing logic here
            # Example: Output the file name
            Write-Output "Processing file: $($csvFile.FullName)"
			Invoke-Expression ".\publish\publish\omop.exe stage clear --type sact"
			Invoke-expression ".\publish\publish\omop.exe stage load --type sact ""$($csvFile.FullName)"""
			Invoke-expression ".\publish\publish\omop.exe transform --type sact"
        }
    } else {
        Write-Warning "Directory not found: $yearDirectory"
    }
}