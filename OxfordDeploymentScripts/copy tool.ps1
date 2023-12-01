
rm publish -Recurse

copy "\\tsclient\C\Code\oxford-omop-transformer\publish.zip" publish.zip

# Define the source ZIP file and the destination folder
$sourceZip = "publish.zip"
$destinationFolder = "publish" # You can change this to your desired folder name

# Copy the ZIP file to the current directory
Copy-Item -Path $sourceZip -Destination ".\publish.zip"

# Create the destination folder if it does not exist
if (-not (Test-Path -Path $destinationFolder)) {
    New-Item -ItemType Directory -Path $destinationFolder
}

# Unzip the archive to the destination folder
Expand-Archive -Path ".\publish.zip" -DestinationPath $destinationFolder

# Copy the appsettings.json file to the unzipped directory
Copy-Item -Path ".\appsettings.json" -Destination $destinationFolder\publish
