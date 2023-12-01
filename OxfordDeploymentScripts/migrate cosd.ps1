# Define the directory to search for zip files
$directory = "D:\Cancer_Reporting\COSD"

# Get all zip files in the directory
$zipFiles = Get-ChildItem -Path $directory -Filter *.zip

# Iterate over each zip file
foreach ($zipFile in $zipFiles) {
    .\publish\publish\omop.exe stage clear --type cosd
    .\publish\publish\omop.exe stage load --type cosd $directory\$zipFile
    .\publish\publish\omop.exe transform --type cosd
}