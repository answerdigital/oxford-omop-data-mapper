# Function to read .env file and return hashtable of values
function Get-EnvValues {
    param (
        [string]$EnvPath = ".\.env"
    )
    
    # Check if file exists
    if (-not (Test-Path $EnvPath)) {
        Write-Error "Environment file not found at: $EnvPath"
        return $null
    }
    
    # Create hashtable to store values
    $envValues = @{}
    
    # Read and parse the .env file
    Get-Content $EnvPath | ForEach-Object {
        if ($_ -match '^\s*$' -or $_ -match '^\s*#') {
            return
        }
        
        $keyValue = $_ -split '=', 2
        if ($keyValue.Count -eq 2) {
            $key = $keyValue[0].Trim()
            $value = $keyValue[1].Trim()
            
            $value = $value -replace '^[''"]|[''"]$'
            
            $envValues[$key] = $value
        }
    }
    
    return $envValues
}

$env = Get-EnvValues

docker run `
    --rm `
    -v ${pwd}/sql:/flyway/sql `
    -v ${pwd}/conf:/flyway/conf `
    flyway/flyway `
    -url=jdbc:"sqlserver://host.docker.internal:1433;databaseName=$($env.dbname);encrypt=false" `
    -user="$($env.user)" `
    -password="$($env.password)" `
    migrate migrate
""
