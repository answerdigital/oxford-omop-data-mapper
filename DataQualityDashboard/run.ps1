param (
    [string]$outpath
)

# Generate container name
$containerName = "temp-container"

# Generate host path locations
$resultsPath = "$outpath\results.json"
$failedPath = "$outpath\failed_checks.json"

# Run the container, run Rscript, run python script & Copy the results to the local machine
docker run --env-file="drivers\.env" --name $containerName dqdash /bin/bash -c "Rscript main.r && python3 parser.py"
docker cp "$containerName`:/etl/output/results.json" $resultsPath
docker cp "$containerName`:/etl/failed_checks.json" $failedPath

# Remove container
docker rm -f $containerName
