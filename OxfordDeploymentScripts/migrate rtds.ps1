# Define the root path where top-level directories are located
$rootPath = "D:\Cancer_Reporting\RTDS"

# Get all top-level directories
$topLevelDirectories = Get-ChildItem -Path $rootPath -Directory

# Iterate over each top-level directory
foreach ($dir in $topLevelDirectories) {
    Write-Host "Processing top-level directory: $($dir.FullName)"

    # Get subdirectories and ZIP files within the current top-level directory
    $subItems = Get-ChildItem -Path $dir.FullName -Recurse | Where-Object { $_.PSIsContainer -or $_.Extension -eq '.zip' }

    foreach ($item in $subItems) {
        if ($item.PSIsContainer) {
            Write-Host "Subdirectory: $($item.FullName)"
        }
        elseif ($item.Extension -eq '.zip') {
            Write-Host "ZIP file: $($item.FullName)"
        }
		
		.\publish\publish\omop.exe stage load --type rtds $item.FullName
    }
}