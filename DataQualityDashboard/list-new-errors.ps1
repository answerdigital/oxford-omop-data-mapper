param(
    [Parameter(Mandatory=$false)]
    [string]$JsonFilePath= "failed_checks.json",
    
    [Parameter(Mandatory=$false)]
    [string]$KnownErrorsPath = "known_errors.txt"
)

# Function to check if an error is already known
function Is-KnownError {
    param([string]$CheckId)
    
    # If known errors file doesn't exist, return false
    if (-not (Test-Path $KnownErrorsPath)) {
        return $false
    }
    
    # Read known errors file and check if CheckId exists
    $knownErrors = Get-Content $KnownErrorsPath
    return $CheckId -in $knownErrors
}

# Validate input file exists
if (-not (Test-Path $JsonFilePath)) {
    Write-Error "JSON file not found: $JsonFilePath"
    exit 1
}

try {
    # Read and parse JSON file
    $jsonContent = Get-Content $JsonFilePath | ConvertFrom-Json
    
    # Track new errors
    $newErrors = @()
    
    # Check each CheckResults entry
    foreach ($checkResult in $jsonContent.CheckResults) {
        $checkId = $checkResult.checkId
        
        # Only add to new errors if not a known error
        if (-not (Is-KnownError -CheckId $checkId)) {
            $newErrors += $checkId
        }
    }
    
    # If any new errors exist, print them and exit with error code
    if ($newErrors.Count -gt 0) {
        Write-Error "New errors detected:"
        $newErrors | ForEach-Object { Write-Error $_ }
        exit 1
    }
    
    # If no new errors, exit successfully
    Write-Host "No new errors detected."
    exit 0
}
catch {
    Write-Error "Error processing JSON file: $_"
    exit 1
}